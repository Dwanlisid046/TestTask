CREATE PROCEDURE [dbo].[GetHiredStatistics]
    @StatusName VARCHAR(100) = NULL,
    @StartDate DATETIME,
    @EndDate DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        CAST(p.date_employ AS DATE) AS HireDate,
        COUNT(*) AS HireCount
    FROM 
        persons p
        INNER JOIN status s ON p.status = s.id
    WHERE
        p.date_employ IS NOT NULL
        AND p.date_employ BETWEEN @StartDate AND @EndDate
        AND (@StatusName IS NULL OR s.name = @StatusName)
    GROUP BY 
        CAST(p.date_employ AS DATE)
    ORDER BY 
        HireDate;
END
GO