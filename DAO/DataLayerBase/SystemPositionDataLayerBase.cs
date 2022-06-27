using DTO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DataLayerBase
{
     /// <summary>
     /// Base class for SystemPositionDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the SystemPositionDataLayer class
     /// </summary>
     public class SystemPositionDataLayerBase
     {
         // constructor
         public SystemPositionDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static SystemPositionModel SelectByPrimaryKey(int id)
         {
              SystemPositionModel  objSystemPosition = null;
              string storedProcName = "[dbo].[SystemPosition_SelectByPrimaryKey]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // parameters
                      command.Parameters.AddWithValue("@id", id);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemPosition = CreateSystemPositionFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objSystemPosition;
         }

         /// <summary>
         /// Gets the total number of records in the SystemPosition table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[SystemPosition_GetRecordCount]", null, null, true, null);
         }

         public static int GetRecordCountShared(string storedProcName = null, string param = null, object paramValue = null, bool isUseStoredProc = true, string dynamicSqlScript = null)
         {
              int recordCount = 0;

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  recordCount = (int)dt.Rows[0]["RecordCount"];
                              }
                          }
                      }
                  }
              }

              return recordCount;
         }

         /// <summary>
         /// Gets the total number of records in the SystemPosition table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, decimal? salaryPerHour, bool? isDeleted)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[SystemPosition_GetRecordCountWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, salaryPerHour, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  recordCount = (int)dt.Rows[0]["RecordCount"];
                              }
                          }
                      }
                  }
              }

              return recordCount;
         }

         /// <summary>
         /// Selects SystemPosition records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<SystemPositionModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[SystemPosition_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects SystemPosition records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<SystemPositionModel> SelectSkipAndTakeDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, decimal? salaryPerHour, bool? isDeleted, string sortByExpression, int startRowIndex, int rows)
         {
            List<SystemPositionModel> objSystemPositionCol = null;
              string storedProcName = "[dbo].[SystemPosition_SelectSkipAndTakeWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // select, skip, take, sort parameters
                      command.Parameters.AddWithValue("@start", startRowIndex);
                      command.Parameters.AddWithValue("@numberOfRows", rows);
                      command.Parameters.AddWithValue("@sortByExpression", sortByExpression);

                      // search parameters
                      AddSearchCommandParamsShared(command, id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, salaryPerHour, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemPositionCol = new List<SystemPositionModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemPositionModel objSystemPosition = CreateSystemPositionFromDataRowShared(dr);
                                      objSystemPositionCol.Add(objSystemPosition);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemPositionCol;
         }

         /// <summary>
         /// Gets the grand total or sum of fields with a money of decimal data type
         /// </summary>
         public static SystemPositionModel SelectTotals()
         {
              SystemPositionModel objSystemPosition = null;
              string storedProcName = "[dbo].[SystemPosition_SelectTotals]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  if(dt.Rows[0]["SalaryPerHourTotal"] != DBNull.Value)
                                       objSystemPosition.SalaryPerHourTotal = (decimal)dt.Rows[0]["SalaryPerHourTotal"];
                              }
                          }
                      }
                  }
              }

              return objSystemPosition;
         }

         /// <summary>
         /// Selects all SystemPosition
         /// </summary>
         public static List<SystemPositionModel> SelectAll()
         {
             return SelectShared("[dbo].[SystemPosition_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemPosition.
         /// </summary>
         public static List<SystemPositionModel> SelectAllDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, decimal? salaryPerHour, bool? isDeleted)
         {
            List<SystemPositionModel> objSystemPositionCol = null;
              string storedProcName = "[dbo].[SystemPosition_SelectAllWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, salaryPerHour, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemPositionCol = new List<SystemPositionModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemPositionModel objSystemPosition = CreateSystemPositionFromDataRowShared(dr);
                                      objSystemPositionCol.Add(objSystemPosition);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemPositionCol;
         }

         /// <summary>
         /// Selects Id and Name columns for use with a DropDownList web control
         /// </summary>
         public static List<SystemPositionModel> SelectSystemPositionDropDownListData()
         {
            List<SystemPositionModel> objSystemPositionCol = null;
              string storedProcName = "[dbo].[SystemPosition_SelectDropDownListData]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemPositionCol = new List<SystemPositionModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemPositionModel objSystemPosition = new SystemPositionModel();
                                      objSystemPosition.Id = (int)dr["Id"];

                                      if (dr["Name"] != System.DBNull.Value)
                                          objSystemPosition.Name = (string)(dr["Name"]);
                                      else
                                          objSystemPosition.Name = null;

                                      objSystemPositionCol.Add(objSystemPosition);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemPositionCol;
         }

         public static List<SystemPositionModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<SystemPositionModel> objSystemPositionCol = null;

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // select, skip, take, sort parameters
                      if (!String.IsNullOrEmpty(sortByExpression) && startRowIndex != null && rows != null)
                      {
                          command.Parameters.AddWithValue("@start", startRowIndex.Value);
                          command.Parameters.AddWithValue("@numberOfRows", rows.Value);
                          command.Parameters.AddWithValue("@sortByExpression", sortByExpression);
                      }

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemPositionCol = new List<SystemPositionModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemPositionModel objSystemPosition = CreateSystemPositionFromDataRowShared(dr);
                                      objSystemPositionCol.Add(objSystemPosition);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemPositionCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(SystemPositionModel objSystemPosition)
         {
             string storedProcName = "[dbo].[SystemPosition_Insert]";
             return InsertUpdate(objSystemPosition, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(SystemPositionModel objSystemPosition)
         {
             string storedProcName = "[dbo].[SystemPosition_Update]";
             InsertUpdate(objSystemPosition, true, storedProcName);
         }

         private static int InsertUpdate(SystemPositionModel objSystemPosition, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objSystemPosition.Id;

              object name = objSystemPosition.Name;
              object createdDate = objSystemPosition.CreatedDate;
              object modifiedDate = objSystemPosition.ModifiedDate;
              object createdUserId = objSystemPosition.CreatedUserId;
              object modifiedUserId = objSystemPosition.ModifiedUserId;
              object salaryPerHour = objSystemPosition.SalaryPerHour;

              if (String.IsNullOrEmpty(objSystemPosition.Name))
                  name = System.DBNull.Value;

              if (objSystemPosition.CreatedDate == null)
                  createdDate = System.DBNull.Value;

              if (objSystemPosition.ModifiedDate == null)
                  modifiedDate = System.DBNull.Value;

              if (objSystemPosition.CreatedUserId == null)
                  createdUserId = System.DBNull.Value;

              if (objSystemPosition.ModifiedUserId == null)
                  modifiedUserId = System.DBNull.Value;

              if (objSystemPosition.SalaryPerHour == null)
                  salaryPerHour = System.DBNull.Value;

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // parameters
                      if (isUpdate)
                      {
                          // for update only
                          command.Parameters.AddWithValue("@id", objSystemPosition.Id);
                      }

                      command.Parameters.AddWithValue("@name", name);
                      command.Parameters.AddWithValue("@createdDate", createdDate);
                      command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                      command.Parameters.AddWithValue("@createdUserId", createdUserId);
                      command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                      command.Parameters.AddWithValue("@salaryPerHour", salaryPerHour);
                      command.Parameters.AddWithValue("@isDeleted", objSystemPosition.IsDeleted);

                      if (isUpdate)
                          command.ExecuteNonQuery();
                      else
                          newlyCreatedId = (int)command.ExecuteScalar();
                  }
              }

              return newlyCreatedId;
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
              string storedProcName = "[dbo].[SystemPosition_Delete]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // parameters
                      command.Parameters.AddWithValue("@id", id);

                      // execute
                      command.ExecuteNonQuery();
                  }
              }
         }

         /// <summary>
         /// Adds search parameters to the Command object
         /// </summary>
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, decimal? salaryPerHour, bool? isDeleted)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(!String.IsNullOrEmpty(name))
                  command.Parameters.AddWithValue("@name", name);
              else
                  command.Parameters.AddWithValue("@name", System.DBNull.Value);

              if(createdDate != null)
                  command.Parameters.AddWithValue("@createdDate", createdDate);
              else
                  command.Parameters.AddWithValue("@createdDate", System.DBNull.Value);

              if(modifiedDate != null)
                  command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
              else
                  command.Parameters.AddWithValue("@modifiedDate", System.DBNull.Value);

              if(createdUserId != null)
                  command.Parameters.AddWithValue("@createdUserId", createdUserId);
              else
                  command.Parameters.AddWithValue("@createdUserId", System.DBNull.Value);

              if(modifiedUserId != null)
                  command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
              else
                  command.Parameters.AddWithValue("@modifiedUserId", System.DBNull.Value);

              if(salaryPerHour != null)
                  command.Parameters.AddWithValue("@salaryPerHour", salaryPerHour);
              else
                  command.Parameters.AddWithValue("@salaryPerHour", System.DBNull.Value);

              if(isDeleted != null)
                  command.Parameters.AddWithValue("@isDeleted", isDeleted);
              else
                  command.Parameters.AddWithValue("@isDeleted", System.DBNull.Value);

         }

         /// <summary>
         /// Creates a SystemPosition object from the passed data row
         /// </summary>
         private static SystemPositionModel CreateSystemPositionFromDataRowShared(DataRow dr)
         {
             SystemPositionModel objSystemPosition = new SystemPositionModel();

             objSystemPosition.Id = (int)dr["Id"];

             if (dr["Name"] != System.DBNull.Value)
                 objSystemPosition.Name = dr["Name"].ToString();
             else
                 objSystemPosition.Name = null;

             if (dr["CreatedDate"] != System.DBNull.Value)
                 objSystemPosition.CreatedDate = (DateTime)dr["CreatedDate"];
             else
                 objSystemPosition.CreatedDate = null;

             if (dr["ModifiedDate"] != System.DBNull.Value)
                 objSystemPosition.ModifiedDate = (DateTime)dr["ModifiedDate"];
             else
                 objSystemPosition.ModifiedDate = null;

             if (dr["CreatedUserId"] != System.DBNull.Value)
                 objSystemPosition.CreatedUserId = (int)dr["CreatedUserId"];
             else
                 objSystemPosition.CreatedUserId = null;

             if (dr["ModifiedUserId"] != System.DBNull.Value)
                 objSystemPosition.ModifiedUserId = (int)dr["ModifiedUserId"];
             else
                 objSystemPosition.ModifiedUserId = null;

             if (dr["SalaryPerHour"] != System.DBNull.Value)
                 objSystemPosition.SalaryPerHour = (decimal)dr["SalaryPerHour"];
             else
                 objSystemPosition.SalaryPerHour = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objSystemPosition.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objSystemPosition.IsDeleted = false;

             return objSystemPosition;
         }

         public DataTable LayDSCV()
        {
            string sql = "select * from dbo.[System_Position]";
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            DataTable tb = new DataTable();
            da.Fill(tb);
            conn.Close();
            return tb;
        }
     }
}
