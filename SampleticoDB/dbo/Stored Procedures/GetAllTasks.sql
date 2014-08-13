CREATE PROCEDURE [dbo].[GetAllTasks]
AS
	SELECT t.*
	FROM Tasks t
		