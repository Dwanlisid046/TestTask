using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using TestTask.Entity;

namespace TestTask.Service
{
    public class DatabaseService
    {
        private readonly string connectionString;

        public DatabaseService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Employee> GetEmployees(string statusFilter = null, string departmentFilter = null,
                                          string positionFilter = null, string lastNameFilter = null)
        {
            var employees = new List<Employee>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("GetEmployeesWithFilters", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@StatusFilter", (object)statusFilter ?? DBNull.Value);
                command.Parameters.AddWithValue("@DepartmentFilter", (object)departmentFilter ?? DBNull.Value);
                command.Parameters.AddWithValue("@PositionFilter", (object)positionFilter ?? DBNull.Value);
                command.Parameters.AddWithValue("@LastNameFilter", (object)lastNameFilter ?? DBNull.Value);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employees.Add(new Employee
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            LastName = Convert.ToString(reader["last_name"]),
                            FirstName = Convert.ToString(reader["first_name"]),
                            MiddleName = Convert.ToString(reader["second_name"]),
                            StatusName = Convert.ToString(reader["status_name"]),
                            DepartmentName = Convert.ToString(reader["department_name"]),
                            PositionName = Convert.ToString(reader["position_name"]),
                            HireDate = (DateTime)(reader["date_employ"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["date_employ"])),
                            FireDate = reader["date_uneploy"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["date_uneploy"])
                        });
                    }
                }
            }

            return employees;
        }

        public (List<DictionaryItem> statuses, List<DictionaryItem> departments, List<DictionaryItem> positions) GetDictionaries()
        {
            var statuses = new List<DictionaryItem>();
            var departments = new List<DictionaryItem>();
            var positions = new List<DictionaryItem>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("GetDictionaries", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        statuses.Add(new DictionaryItem
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = Convert.ToString(reader["name"]),
                        });
                    }

                    if (reader.NextResult())
                    {
                        while (reader.Read())
                        {
                            departments.Add(new DictionaryItem
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Name = Convert.ToString(reader["name"]),
                            });
                        }
                    }

                    if (reader.NextResult())
                    {
                        while (reader.Read())
                        {
                            positions.Add(new DictionaryItem
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Name = Convert.ToString(reader["name"]),
                            });
                        }
                    }
                }
            }

            return (statuses, departments, positions);
        }

        public List<StatisticsItem> GetHiredStatistics(string statusName, DateTime startDate, DateTime endDate)
        {
            return GetStatistics("GetHiredStatistics", statusName, startDate, endDate);
        }

        public List<StatisticsItem> GetFiredStatistics(string statusName, DateTime startDate, DateTime endDate)
        {
            return GetStatistics("GetFiredStatistics", statusName, startDate, endDate);
        }

        private List<StatisticsItem> GetStatistics(string procedureName, string statusName, DateTime startDate, DateTime endDate)
        {
            var statistics = new List<StatisticsItem>();

            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(procedureName, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@StatusName", (object)statusName ?? DBNull.Value);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        statistics.Add(new StatisticsItem
                        {
                            Date = reader.GetDateTime(0),
                            Count = reader.GetInt32(1)
                        });
                    }
                }
            }

            return statistics;
        }
    }
}