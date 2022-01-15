using Meta.Models;
using Meta.VM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Meta.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MetaDBContext _context;
        public HomeController(ILogger<HomeController> logger, MetaDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(string ID)
        {
           var con= _context.Contents.Include(x=>x.ContentToCategories).ThenInclude(x=>x.Category).Include(x => x.Films).Include(x => x.ContentLanguages).Include(x => x.Type).ToList();
            HomeVM vm = new()
            {
                Contents = con,
                Categories = _context.Categories.Include(x=>x.CategoryLanguages).ToList(),
                Languages=_context.Languages.ToList()
            };
            vm.Lang = "AZ";
            if (ID!=null)
            {
                vm.Lang = ID;
            }
            return View(vm);
        }
        public IActionResult FilmDetail(int ID)
        {
            //var film = _context.Films.Include(x => x.Url.Audios).Include(x => x.Url).ThenInclude(x => x.Subtitles).Include(x => x.Content.ContentToCategories)
            //      .ThenInclude(x => x.Category).ThenInclude(x => x.CategoryLanguages)
            //      .Include(x => x.Content.ContentLanguages).
            //      Include(x => x.FilmToComments).ThenInclude(x => x.Comment).ThenInclude(x => x.CommentToCommentComments)
            //      .FirstOrDefault(x => x.ContentId == ID);

            var film = _context.GetFilmByContent.FromSqlRaw($"EXECUTE dbo.GetFilmByContent {ID},{"AZ"}").AsEnumerable().First();
            var comments = _context.FilmToComments.Include(x => x.Comment).ThenInclude(x=>x.User).Where(x => x.FilmId == film.FilmID).ToList();
            var getCategory = _context.GetCategoryBycontent.FromSqlRaw($"EXECUTE dbo.GetCategoryBycontent {ID},{"AZ"}").ToList();
            var subtitles = _context.Subtitles.Where(x => x.UrlId == film.UrlId).ToList();
            var audios = _context.Audios.Where(x => x.UrlId == film.UrlId).ToList();

            FilmVM vm = new()
            { 
                Film=film,
                FilmToComments=comments,
                Category=getCategory,
                Subtitles=subtitles,
                Audios=audios
            };

            return View(vm);
        }
        public IActionResult TvShowDetail(int ID)
        {
            var GetTvshow = _context.GetTvShowById.FromSqlRaw($"EXECUTE dbo.GetTvShowById {ID},{"AZ"}").AsEnumerable().First();
            var GetDirectors = _context.Directors.FromSqlRaw($"EXECUTE dbo.GetDirectorBycontent {GetTvshow.ContentId}").ToList();
            var GetCategories=_context.GetCategoryBycontent.FromSqlRaw($"EXECUTE dbo.GetCategoryBycontent {GetTvshow.ContentId},{"AZ"}").ToList();
            var GetActors = _context.Actors.FromSqlRaw($"EXECUTE dbo.GetActorByContent {GetTvshow.ContentId}").ToList();
            var GetSeason = _context.Seasons.Include(x => x.Series).ThenInclude(x => x.Url).Where(x => x.TvShowId == GetTvshow.ID).ToList();
            TvShowVM vm = new TvShowVM()
            {
                TvShow=GetTvshow,
                Directors=GetDirectors,
                Categories=GetCategories,
                Seasons=GetSeason,
                Actors= GetActors
            };
            return View(vm);
        }
        public IActionResult SeriesDetail(int ID)
        {
            //var series = _context.Series
            //    .Include(x => x.Url).Include(x => x.Season)
            //    .Include(x => x.SeriesLanguages)
            //    .FirstOrDefault(x => x.Id == ID);
            //var tv = _context.TvShows.Include(x => x.Seasons).ThenInclude(x => x.Series)
            //    .Include(x => x.Content).ThenInclude(x => x.ContentToCategories)
            //    .ThenInclude(x => x.Category).ThenInclude(x => x.CategoryLanguages)
            //    .Include(x => x.Content).ThenInclude(x => x.ContentLanguages)
            //    .FirstOrDefault(x => x.Seasons.First(x => x.Id == series.Season.Id).Id == series.Season.Id);

            //SeriesVM vm = new SeriesVM()
            //{
            //    Series = series,
            //    TvShow = tv,
            //    CommentVM = new List<CommentVM>()
            //};
            //var comms = _context.SeriesToComments.Include(x => x.Comment).ThenInclude(x => x.User).Where(x => x.SeriesId == ID).ToList();
            //foreach (var item in comms)
            //{
            //    CommentVM nm = new CommentVM()
            //    {
            //        Name = item.Comment.User.Name,
            //        Comment = item.Comment.Text
            //    };
            //    vm.CommentVM.Add(nm);
            //}

            var GetSeries =_context.GetSeriesById.FromSqlRaw($"EXECUTE GetSeriesById {ID},{"AZ"}").AsEnumerable().First();
            var Season = _context.Seasons.Include(x => x.Series).Where(x => x.TvShowId==GetSeries.TwShowId).ToList();
            var Comments = _context.SeriesToComments.Include(x=>x.Comment).ThenInclude(x=>x.User).Where(x => x.SeriesId == GetSeries.ID).Select(x=>x.Comment).ToList();
            var subtitles = _context.Subtitles.Where(x => x.UrlId == GetSeries.UrlId).ToList();
            var Audios = _context.Audios.Where(x => x.UrlId == GetSeries.UrlId).ToList();
            var getCategory = _context.GetCategoryBycontent.FromSqlRaw($"EXECUTE dbo.GetCategoryBycontent {GetSeries.ContentId},{"AZ"}").ToList();
            SeriesVM vm = new SeriesVM()
            {
                Series = GetSeries,
                Seasons = Season,
                Comment = Comments,
                Audios = Audios,
                Subtitles = subtitles,
                Categories = getCategory
            };
            return View(vm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
