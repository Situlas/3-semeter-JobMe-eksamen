﻿using ModelLayer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DbJobCategory : IDataAccess<JobCategory>
    {
        //Is an instance of DBConnection
        private string ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        /// <summary>
        /// Is  a mathod that creates a JobCategory in the databse with the variables....
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Create(JobCategory obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Is a method that deletes a JobCategory from the databse by its Id
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a JobCategory Object from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JobCategory Get(int id)
        {
            JobCategory jobCategory = new JobCategory();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM JobCategories WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("Id", id);

                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            jobCategory.Id = (int)reader["Id"];
                            jobCategory.Title = (string)reader["Title"];
                        }
                    }
                    return jobCategory;
                }
            }
        }

        /// <summary>
        /// Returns a A list of all JobCategories from the database
        /// </summary>
        /// <returns></returns>
        public List<JobCategory> GetAll()
        {
            List<JobCategory> jobCategoryList = new List<JobCategory>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM JobCategories";
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        JobCategory jobCategory = new JobCategory
                        {
                            Id = (int)reader["Id"],
                            Title = (string)reader["Title"]
                        };
                        jobCategoryList.Add(jobCategory);
                    }
                }
            }
            return jobCategoryList;
        }

        /// <summary>
        /// Updates the JobCategory Object in the databse.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Update(JobCategory obj)
        {
            throw new NotImplementedException();
        }
    }
}
