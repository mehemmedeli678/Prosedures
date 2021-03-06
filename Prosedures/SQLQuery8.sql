USE [MetaDB2]
GO
/****** Object:  StoredProcedure [dbo].[GetCategoryBycontent]    Script Date: 15.01.2022 14:43:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[GetCategoryBycontent]
	-- Add the parameters for the stored procedure here
	@id int,
	@key nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

       SELECT d.ID,d.IsActive,d.IsDeleted,d.ModifiedOn,cl.Name from Category d
		join ContentToCategory cd on cd.CategoryID=d.ID
		join CategoryLanguage cl on cl.CategoryID=d.ID
		where cd.ContentID=@id and cl.LanguageKey=@key
END
