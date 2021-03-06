USE [MetaDB2]
GO
/****** Object:  StoredProcedure [dbo].[GetActorByContent]    Script Date: 15.01.2022 14:42:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[GetActorByContent]
	-- Add the parameters for the stored procedure here
	@id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    SELECT d.ID ,d.Name ,d.Picture, d.IsActive,d.IsDeleted,d.ModifiedOn from Actor d
		join ContentToActor cd on cd.ActorID=d.ID
		where cd.ContentID=@id
    -- Insert statements for procedure here
END
