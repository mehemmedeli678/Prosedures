USE [MetaDB2]
GO
/****** Object:  StoredProcedure [dbo].[GetDirectorBycontent]    Script Date: 15.01.2022 14:43:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[GetDirectorBycontent]
	-- Add the parameters for the stored procedure here
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	    SELECT d.ID ,d.Name ,d.Picture, d.IsActive,d.IsDeleted,d.ModifiedOn from Director d
		join ContentToDirector cd on cd.DirectorID=d.ID
		where cd.ContentID=@id
END
