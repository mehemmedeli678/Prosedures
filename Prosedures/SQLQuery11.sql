USE [MetaDB2]
GO
/****** Object:  StoredProcedure [dbo].[GetSeriesById]    Script Date: 15.01.2022 14:43:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[GetSeriesById]
	-- Add the parameters for the stored procedure here
@id int,
@key nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select ss.ID, sn.ID as SeasonID, ss.SeriaNumber,ss.IsActive,ss.IsDeleted,ss.ModifiedOn,sn.SeasonNumber,sn.MainPicture as SeasonPicture,tw.Imdb,tw.IsSubscribe,ct.ID as ContentId,ct.MainPicture as ContentPicture,ct.Age,ct.IsFree,ct.Hit,tw.ID as TwShowId,ctl.Name,u.ID as UrlId,u.UrlName,ssg.Description from Series ss
	join Season sn on ss.SeasonID=sn.ID
	join TvShow tw on sn.TvShowID=tw.ID
	join Content ct on ct.ID=tw.ContentID
	join ContentLanguage ctl on ctl.ContentID=ct.ID
	join Url u on u.ID=ss.UrlID
	join SeriesLanguage ssg on ssg.SeriesID=ss.ID
	where ss.ID=@id and ctl.LanguageKey=@key and ssg.LanguageKey=@key
END
