USE [MetaDB2]
GO
/****** Object:  StoredProcedure [dbo].[GetTvShowById]    Script Date: 15.01.2022 14:43:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[GetTvShowById]
	-- Add the parameters for the stored procedure here
	@id int,
	@key nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT c.ID as ContentId, ctl.Name,ctl.Description,c.MainPicture, tv.ID,tv.Imdb,t.Name as Type,c.Age,c.ContentDate,c.AddDate, c.IsFree,c.Hit,c.IsActive,c.IsDeleted from TvShow tv
	join Content c on c.ID=tv.ContentID
	join ContentLanguage ctl on ctl.ContentID=c.ID
	join Type t on c.TypeID=t.ID
	where c.ID=@id  and ctl.LanguageKey=@key
END
