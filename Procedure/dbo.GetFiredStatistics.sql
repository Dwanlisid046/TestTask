CREATE PROCEDURE [dbo].[GetFiredStatistics]
    @StatusName VARCHAR(100) = NULL,
    @StartDate DATETIME,
    @EndDate DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        CAST(p.date_uneploy AS DATE) AS FireDate,
        COUNT(*) AS FireCount
    FROM 
        persons p
        INNER JOIN status s ON p.status = s.id
    WHERE
        p.date_uneploy IS NOT NULL
        AND p.date_uneploy BETWEEN @StartDate AND @EndDate
        AND (@StatusName IS NULL OR s.name = @StatusName)
    GROUP BY 
        CAST(p.date_uneploy AS DATE)
    ORDER BY 
        FireDate;
END
GO