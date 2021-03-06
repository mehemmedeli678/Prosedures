USE [MetaDB2]
GO
/****** Object:  StoredProcedure [dbo].[GetFilmByContent]    Script Date: 15.01.2022 14:43:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[GetFilmByContent]
	-- Add the parameters for the stored procedure here
@id int ,
@key nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT f.ID as FilmID,f.Imdb,f.IsSubscribe ,c.ID as ContentID,c.MainPicture,c.Age,c.IsFree,c.Hit,c.AddDate,c.ContentDate,cl.Name,cl.Description,u.ID as UrlId, u.UrlName FROM Film f
	JOIN Url u on u.ID= f.ID
	JOIN Content c on c.ID=f.ContentID
	join ContentLanguage cl on cl.ContentID=c.ID
	where c.ID=2 and cl.LanguageKey='AZ'
END
