CREATE PROCEDURE [dbo].[GetEmployeesWithFilters]
    @StatusFilter VARCHAR(100) = NULL,
    @DepartmentFilter VARCHAR(100) = NULL,
    @PositionFilter VARCHAR(100) = NULL,
    @LastNameFilter VARCHAR(100) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        p.id,
        p.last_name,
        p.first_name,
        p.second_name,
        s.name AS status_name,
        d.name AS department_name,
        po.name AS position_name,
        p.date_employ,
        p.date_uneploy
    FROM 
        persons p
        INNER JOIN status s ON p.status = s.id
        INNER JOIN deps d ON p.id_dep = d.id
        INNER JOIN posts po ON p.id_post = po.id
    WHERE
        (@StatusFilter IS NULL OR s.name = @StatusFilter)
        AND (@DepartmentFilter IS NULL OR d.name = @DepartmentFilter)
        AND (@PositionFilter IS NULL OR po.name = @PositionFilter)
        AND (@LastNameFilter IS NULL OR p.last_name LIKE '%' + @LastNameFilter + '%')
    ORDER BY
        p.last_name, p.first_name, p.second_name;
END
GO