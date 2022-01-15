using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Meta.Models
{
    public partial class MetaDBContext : DbContext
    {
        public MetaDBContext(DbContextOptions<MetaDBContext> options)
            : base(options)
        {
        }
        [NotMapped]
        public DbSet<GetFilmByContent> GetFilmByContent { get; set; }
        [NotMapped]
        public virtual DbSet<GetTvShowById>  GetTvShowById { get; set; }
        [NotMapped]
        public virtual DbSet<GetSeriesById> GetSeriesById { get; set; }
        [NotMapped]
        public virtual DbSet<GetCategoryBycontent> GetCategoryBycontent { get; set; }
        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Audio> Audios { get; set; }
        public virtual DbSet<Buying> Buyings { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryLanguage> CategoryLanguages { get; set; }
        public virtual DbSet<CinemaLab> CinemaLabs { get; set; }
        public virtual DbSet<CinemaLabToComment> CinemaLabToComments { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<CommentToComment> CommentToComments { get; set; }
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<ContentLanguage> ContentLanguages { get; set; }
        public virtual DbSet<ContentToActor> ContentToActors { get; set; }
        public virtual DbSet<ContentToCategory> ContentToCategories { get; set; }
        public virtual DbSet<ContentToDirector> ContentToDirectors { get; set; }
        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<FavoryContent> FavoryContents { get; set; }
        public virtual DbSet<FavorySeries> FavorySeries { get; set; }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<FilmToComment> FilmToComments { get; set; }
        public virtual DbSet<History> Histories { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LikedContent> LikedContents { get; set; }
        public virtual DbSet<LikedSeries> LikedSeries { get; set; }
        public virtual DbSet<Paket> Pakets { get; set; }
        public virtual DbSet<PayFullFilm> PayFullFilms { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
        public virtual DbSet<Series> Series { get; set; }
        public virtual DbSet<SeriesLanguage> SeriesLanguages { get; set; }
        public virtual DbSet<SeriesToComment> SeriesToComments { get; set; }
        public virtual DbSet<Subscriber> Subscribers { get; set; }
        public virtual DbSet<SubscriperToPaket> SubscriperToPakets { get; set; }
        public virtual DbSet<Subtitle> Subtitles { get; set; }
        public virtual DbSet<Trailer> Trailers { get; set; }
        public virtual DbSet<TrailerToContent> TrailerToContents { get; set; }
        public virtual DbSet<TrailerToSeason> TrailerToSeasons { get; set; }
        public virtual DbSet<TrailerToSeries> TrailerToSeries { get; set; }
        public virtual DbSet<TvShow> TvShows { get; set; }
        public virtual DbSet<Url> Urls { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserToRole> UserToRoles { get; set; }
        public DbSet<Type>  Type { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Actor>(entity =>
            {
                entity.ToTable("Actor");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Audio>(entity =>
            {
                entity.ToTable("Audio");

                entity.HasIndex(e => e.UrlId, "IX_Audio_UrlID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.ModifiedOn).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.UrlId).HasColumnName("UrlID");

                entity.HasOne(d => d.Url)
                    .WithMany(p => p.Audios)
                    .HasForeignKey(d => d.UrlId);
            });

            modelBuilder.Entity<Buying>(entity =>
            {
                entity.ToTable("Buying");

                entity.HasIndex(e => e.FilmId, "IX_Buying_FilmID");

                entity.HasIndex(e => e.UserId, "IX_Buying_UserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.Buyings)
                    .HasForeignKey(d => d.FilmId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Buyings)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<CategoryLanguage>(entity =>
            {
                entity.ToTable("CategoryLanguage");

                entity.HasIndex(e => e.CategoryId, "IX_CategoryLanguage_CategoryID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryLanguages)
                    .HasForeignKey(d => d.CategoryId);
            });

            modelBuilder.Entity<CinemaLab>(entity =>
            {
                entity.ToTable("CinemaLab");

                entity.HasIndex(e => e.ContentId, "IX_CinemaLab_ContentID");

                entity.HasIndex(e => e.UrlId, "IX_CinemaLab_UrlID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.Property(e => e.UrlId).HasColumnName("UrlID");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.CinemaLabs)
                    .HasForeignKey(d => d.ContentId);

                entity.HasOne(d => d.Url)
                    .WithMany(p => p.CinemaLabs)
                    .HasForeignKey(d => d.UrlId);
            });

            modelBuilder.Entity<CinemaLabToComment>(entity =>
            {
                entity.ToTable("CinemaLabToComment");

                entity.HasIndex(e => e.CinemaLabId, "IX_CinemaLabToComment_CinemaLabID");

                entity.HasIndex(e => e.CommentId, "IX_CinemaLabToComment_CommentID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CinemaLabId).HasColumnName("CinemaLabID");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.HasOne(d => d.CinemaLab)
                    .WithMany(p => p.CinemaLabToComments)
                    .HasForeignKey(d => d.CinemaLabId);

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.CinemaLabToComments)
                    .HasForeignKey(d => d.CommentId);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.ToTable("Comment");

                entity.HasIndex(e => e.UserId, "IX_Comment_UserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<CommentToComment>(entity =>
            {
                entity.ToTable("CommentToComment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.CommentToCommentComments)
                    .HasForeignKey(d => d.CommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommentToComment_Comment");

                entity.HasOne(d => d.ReplyCommentNavigation)
                    .WithMany(p => p.CommentToCommentReplyCommentNavigations)
                    .HasForeignKey(d => d.ReplyCommentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CommentToComment_Comment1");
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.ToTable("Content");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<ContentLanguage>(entity =>
            {
                entity.ToTable("ContentLanguage");

                entity.HasIndex(e => e.ContentId, "IX_ContentLanguage_ContentID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.ContentLanguages)
                    .HasForeignKey(d => d.ContentId);
            });

            modelBuilder.Entity<ContentToActor>(entity =>
            {
                entity.ToTable("ContentToActor");

                entity.HasIndex(e => e.ActorId, "IX_ContentToActor_ActorID");

                entity.HasIndex(e => e.ContentId, "IX_ContentToActor_ContentID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActorId).HasColumnName("ActorID");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.HasOne(d => d.Actor)
                    .WithMany(p => p.ContentToActors)
                    .HasForeignKey(d => d.ActorId);

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.ContentToActors)
                    .HasForeignKey(d => d.ContentId);
            });

            modelBuilder.Entity<ContentToCategory>(entity =>
            {
                entity.ToTable("ContentToCategory");

                entity.HasIndex(e => e.CategoryId, "IX_ContentToCategory_CategoryID");

                entity.HasIndex(e => e.ContentId, "IX_ContentToCategory_ContentID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ContentToCategories)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.ContentToCategories)
                    .HasForeignKey(d => d.ContentId);
            });

            modelBuilder.Entity<ContentToDirector>(entity =>
            {
                entity.ToTable("ContentToDirector");

                entity.HasIndex(e => e.ContentId, "IX_ContentToDirector_ContentID");

                entity.HasIndex(e => e.DirectorId, "IX_ContentToDirector_DirectorID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.Property(e => e.DirectorId).HasColumnName("DirectorID");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.ContentToDirectors)
                    .HasForeignKey(d => d.ContentId);

                entity.HasOne(d => d.Director)
                    .WithMany(p => p.ContentToDirectors)
                    .HasForeignKey(d => d.DirectorId);
            });

            modelBuilder.Entity<Director>(entity =>
            {
                entity.ToTable("Director");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<FavoryContent>(entity =>
            {
                entity.ToTable("FavoryContent");

                entity.HasIndex(e => e.ContentId, "IX_FavoryContent_ContentID");

                entity.HasIndex(e => e.UserId, "IX_FavoryContent_UserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.FavoryContents)
                    .HasForeignKey(d => d.ContentId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FavoryContents)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<FavorySeries>(entity =>
            {
                entity.HasIndex(e => e.SeriesId, "IX_FavorySeries_SeriesID");

                entity.HasIndex(e => e.UserId, "IX_FavorySeries_UserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SeriesId).HasColumnName("SeriesID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Series)
                    .WithMany(p => p.FavorySeries)
                    .HasForeignKey(d => d.SeriesId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FavorySeries)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Film>(entity =>
            {
                entity.ToTable("Film");

                entity.HasIndex(e => e.ContentId, "IX_Film_ContentID");

                entity.HasIndex(e => e.UrlId, "IX_Film_UrlID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.Property(e => e.UrlId).HasColumnName("UrlID");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.ContentId);

                entity.HasOne(d => d.Url)
                    .WithMany(p => p.Films)
                    .HasForeignKey(d => d.UrlId);
            });

            modelBuilder.Entity<FilmToComment>(entity =>
            {
                entity.ToTable("FilmToComment");

                entity.HasIndex(e => e.CommentId, "IX_FilmToComment_CommentID");

                entity.HasIndex(e => e.FilmId, "IX_FilmToComment_FilmID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.FilmToComments)
                    .HasForeignKey(d => d.CommentId);

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.FilmToComments)
                    .HasForeignKey(d => d.FilmId);
            });

            modelBuilder.Entity<History>(entity =>
            {
                entity.ToTable("History");

                entity.HasIndex(e => e.UrlId, "IX_History_UrlID");

                entity.HasIndex(e => e.UserId, "IX_History_UserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UrlId).HasColumnName("UrlID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Url)
                    .WithMany(p => p.Histories)
                    .HasForeignKey(d => d.UrlId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Histories)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("Language");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<LikedContent>(entity =>
            {
                entity.ToTable("LikedContent");

                entity.HasIndex(e => e.ContentId, "IX_LikedContent_ContentID");

                entity.HasIndex(e => e.UserId, "IX_LikedContent_UserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.LikedContents)
                    .HasForeignKey(d => d.ContentId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LikedContents)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<LikedSeries>(entity =>
            {
                entity.HasIndex(e => e.ContentId, "IX_LikedSeries_ContentID");

                entity.HasIndex(e => e.SeriesId, "IX_LikedSeries_SeriesID");

                entity.HasIndex(e => e.UserId, "IX_LikedSeries_UserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.Property(e => e.SeriesId).HasColumnName("SeriesID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.LikedSeries)
                    .HasForeignKey(d => d.ContentId);

                entity.HasOne(d => d.Series)
                    .WithMany(p => p.LikedSeries)
                    .HasForeignKey(d => d.SeriesId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LikedSeries)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Paket>(entity =>
            {
                entity.ToTable("Paket");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<PayFullFilm>(entity =>
            {
                entity.ToTable("PayFullFilm");

                entity.HasIndex(e => e.FilmId, "IX_PayFullFilm_FilmID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FilmId).HasColumnName("FilmID");

                entity.HasOne(d => d.Film)
                    .WithMany(p => p.PayFullFilms)
                    .HasForeignKey(d => d.FilmId);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Season>(entity =>
            {
                entity.ToTable("Season");

                entity.HasIndex(e => e.TvShowId, "IX_Season_TvShowID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TvShowId).HasColumnName("TvShowID");

                entity.HasOne(d => d.TvShow)
                    .WithMany(p => p.Seasons)
                    .HasForeignKey(d => d.TvShowId);
            });

            modelBuilder.Entity<Series>(entity =>
            {
                entity.HasIndex(e => e.SeasonId, "IX_Series_SeasonID");

                entity.HasIndex(e => e.UrlId, "IX_Series_UrlID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SeasonId).HasColumnName("SeasonID");

                entity.Property(e => e.UrlId).HasColumnName("UrlID");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.SeasonId);

                entity.HasOne(d => d.Url)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.UrlId);
            });

            modelBuilder.Entity<SeriesLanguage>(entity =>
            {
                entity.ToTable("SeriesLanguage");

                entity.HasIndex(e => e.SeriesId, "IX_SeriesLanguage_SeriesID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SeriesId).HasColumnName("SeriesID");

                entity.HasOne(d => d.Series)
                    .WithMany(p => p.SeriesLanguages)
                    .HasForeignKey(d => d.SeriesId);
            });

            modelBuilder.Entity<SeriesToComment>(entity =>
            {
                entity.ToTable("SeriesToComment");

                entity.HasIndex(e => e.CommentId, "IX_SeriesToComment_CommentID");

                entity.HasIndex(e => e.SeriesId, "IX_SeriesToComment_SeriesID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.SeriesId).HasColumnName("SeriesID");

                entity.HasOne(d => d.Comment)
                    .WithMany(p => p.SeriesToComments)
                    .HasForeignKey(d => d.CommentId);

                entity.HasOne(d => d.Series)
                    .WithMany(p => p.SeriesToComments)
                    .HasForeignKey(d => d.SeriesId);
            });

            modelBuilder.Entity<Subscriber>(entity =>
            {
                entity.ToTable("Subscriber");

                entity.HasIndex(e => e.UserId, "IX_Subscriber_UserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Subscribers)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<SubscriperToPaket>(entity =>
            {
                entity.ToTable("SubscriperToPaket");

                entity.HasIndex(e => e.PaketId, "IX_SubscriperToPaket_PaketID");


                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PaketId).HasColumnName("PaketID");

                entity.HasOne(d => d.Paket)
                    .WithMany(p => p.SubscriperToPakets)
                    .HasForeignKey(d => d.PaketId);
            });

            modelBuilder.Entity<Subtitle>(entity =>
            {
                entity.ToTable("Subtitle");

                entity.HasIndex(e => e.UrlId, "IX_Subtitle_UrlID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.IsDeleted)
                    .IsRequired()
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");

                entity.Property(e => e.ModifiedOn).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.Property(e => e.UrlId).HasColumnName("UrlID");

                entity.HasOne(d => d.Url)
                    .WithMany(p => p.Subtitles)
                    .HasForeignKey(d => d.UrlId);
            });

            modelBuilder.Entity<Trailer>(entity =>
            {
                entity.ToTable("Trailer");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<TrailerToContent>(entity =>
            {
                entity.ToTable("TrailerToContent");

                entity.HasIndex(e => e.ContentId, "IX_TrailerToContent_ContentID");

                entity.HasIndex(e => e.TrailerId, "IX_TrailerToContent_TrailerID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentId).HasColumnName("ContentID");

                entity.Property(e => e.TrailerId).HasColumnName("TrailerID");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.TrailerToContents)
                    .HasForeignKey(d => d.ContentId);

                entity.HasOne(d => d.Trailer)
                    .WithMany(p => p.TrailerToContents)
                    .HasForeignKey(d => d.TrailerId);
            });

            modelBuilder.Entity<TrailerToSeason>(entity =>
            {
                entity.ToTable("TrailerToSeason");

                entity.HasIndex(e => e.SeasonId, "IX_TrailerToSeason_SeasonID");

                entity.HasIndex(e => e.TrailerId, "IX_TrailerToSeason_TrailerID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SeasonId).HasColumnName("SeasonID");

                entity.Property(e => e.TrailerId).HasColumnName("TrailerID");

                entity.HasOne(d => d.Season)
                    .WithMany(p => p.TrailerToSeasons)
                    .HasForeignKey(d => d.SeasonId);

                entity.HasOne(d => d.Trailer)
                    .WithMany(p => p.TrailerToSeasons)
                    .HasForeignKey(d => d.TrailerId);
            });

            modelBuilder.Entity<TrailerToSeries>(entity =>
            {
                entity.HasIndex(e => e.SeriesId, "IX_TrailerToSeries_SeriesID");

                entity.HasIndex(e => e.TrailerId, "IX_TrailerToSeries_TrailerID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SeriesId).HasColumnName("SeriesID");

                entity.Property(e => e.TrailerId).HasColumnName("TrailerID");

                entity.HasOne(d => d.Series)
                    .WithMany(p => p.TrailerToSeries)
                    .HasForeignKey(d => d.SeriesId);

                entity.HasOne(d => d.Trailer)
                    .WithMany(p => p.TrailerToSeries)
                    .HasForeignKey(d => d.TrailerId);
            });

            modelBuilder.Entity<TvShow>(entity =>
            {
                entity.ToTable("TvShow");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Url>(entity =>
            {
                entity.ToTable("Url");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<UserToRole>(entity =>
            {
                entity.ToTable("UserToRole");

                entity.HasIndex(e => e.RoleId, "IX_UserToRole_RoleID");

                entity.HasIndex(e => e.UserId, "IX_UserToRole_UserID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserToRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserToRoles)
                    .HasForeignKey(d => d.UserId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
