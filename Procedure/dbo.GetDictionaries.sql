CREATE PROCEDURE [dbo].[GetDictionaries]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT id, name FROM status ORDER BY name;

    SELECT id, name FROM deps ORDER BY name;

    SELECT id, name FROM posts ORDER BY name;
END
GO