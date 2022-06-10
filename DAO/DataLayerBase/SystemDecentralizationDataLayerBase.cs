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
     /// Base class for SystemDecentralizationDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the SystemDecentralizationDataLayer class
     /// </summary>
     public class SystemDecentralizationDataLayerBase
     {
         // constructor
         public SystemDecentralizationDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static SystemDecentralizationModel SelectByPrimaryKey(int id)
         {
              SystemDecentralizationModel objSystemDecentralization = null;
              string storedProcName = "[dbo].[SystemDecentralization_SelectByPrimaryKey]";

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
                                  objSystemDecentralization = CreateSystemDecentralizationFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objSystemDecentralization;
         }

         /// <summary>
         /// Gets the total number of records in the SystemDecentralization table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[SystemDecentralization_GetRecordCount]", null, null, true, null);
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
         /// Gets the total number of records in the SystemDecentralization table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, int? userId, int? staffId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[SystemDecentralization_GetRecordCountWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, userId, staffId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted);

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
         /// Selects SystemDecentralization records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<SystemDecentralizationModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[SystemDecentralization_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects SystemDecentralization records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<SystemDecentralizationModel> SelectSkipAndTakeDynamicWhere(int? id, int? userId, int? staffId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, string sortByExpression, int startRowIndex, int rows)
         {
            List<SystemDecentralizationModel> objSystemDecentralizationCol = null;
              string storedProcName = "[dbo].[SystemDecentralization_SelectSkipAndTakeWhereDynamic]";

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
                      AddSearchCommandParamsShared(command, id, userId, staffId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemDecentralizationCol = new List<SystemDecentralizationModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemDecentralizationModel objSystemDecentralization = CreateSystemDecentralizationFromDataRowShared(dr);
                                      objSystemDecentralizationCol.Add(objSystemDecentralization);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemDecentralizationCol;
         }

         /// <summary>
         /// Selects all SystemDecentralization
         /// </summary>
         public static List<SystemDecentralizationModel> SelectAll()
         {
             return SelectShared("[dbo].[SystemDecentralization_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemDecentralization.
         /// </summary>
         public static List<SystemDecentralizationModel> SelectAllDynamicWhere(int? id, int? userId, int? staffId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted)
         {
            List<SystemDecentralizationModel> objSystemDecentralizationCol = null;
              string storedProcName = "[dbo].[SystemDecentralization_SelectAllWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, userId, staffId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemDecentralizationCol = new List<SystemDecentralizationModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemDecentralizationModel objSystemDecentralization = CreateSystemDecentralizationFromDataRowShared(dr);
                                      objSystemDecentralizationCol.Add(objSystemDecentralization);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemDecentralizationCol;
         }

         /// <summary>
         /// Selects Id and UserId columns for use with a DropDownList web control
         /// </summary>
         public static List<SystemDecentralizationModel> SelectSystemDecentralizationDropDownListData()
         {
            List<SystemDecentralizationModel> objSystemDecentralizationCol = null;
              string storedProcName = "[dbo].[SystemDecentralization_SelectDropDownListData]";

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
                                  objSystemDecentralizationCol = new List<SystemDecentralizationModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemDecentralizationModel objSystemDecentralization = new SystemDecentralizationModel();
                                      objSystemDecentralization.Id = (int)dr["Id"];

                                      if (dr["UserId"] != System.DBNull.Value)
                                          objSystemDecentralization.UserId = (int)(dr["UserId"]);
                                      else
                                          objSystemDecentralization.UserId = null;

                                      objSystemDecentralizationCol.Add(objSystemDecentralization);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemDecentralizationCol;
         }

         public static List<SystemDecentralizationModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<SystemDecentralizationModel> objSystemDecentralizationCol = null;

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
                                  objSystemDecentralizationCol = new List<SystemDecentralizationModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemDecentralizationModel objSystemDecentralization = CreateSystemDecentralizationFromDataRowShared(dr);
                                      objSystemDecentralizationCol.Add(objSystemDecentralization);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemDecentralizationCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(SystemDecentralizationModel objSystemDecentralization)
         {
             string storedProcName = "[dbo].[SystemDecentralization_Insert]";
             return InsertUpdate(objSystemDecentralization, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(SystemDecentralizationModel objSystemDecentralization)
         {
             string storedProcName = "[dbo].[SystemDecentralization_Update]";
             InsertUpdate(objSystemDecentralization, true, storedProcName);
         }

         private static int InsertUpdate(SystemDecentralizationModel objSystemDecentralization, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objSystemDecentralization.Id;

              object userId = objSystemDecentralization.UserId;
              object staffId = objSystemDecentralization.StaffId;
              object createdDate = objSystemDecentralization.CreatedDate;
              object modifiedDate = objSystemDecentralization.ModifiedDate;
              object createdUserId = objSystemDecentralization.CreatedUserId;
              object modifiedUserId = objSystemDecentralization.ModifiedUserId;

              if (objSystemDecentralization.UserId == null)
                  userId = System.DBNull.Value;

              if (objSystemDecentralization.StaffId == null)
                  staffId = System.DBNull.Value;

              if (objSystemDecentralization.CreatedDate == null)
                  createdDate = System.DBNull.Value;

              if (objSystemDecentralization.ModifiedDate == null)
                  modifiedDate = System.DBNull.Value;

              if (objSystemDecentralization.CreatedUserId == null)
                  createdUserId = System.DBNull.Value;

              if (objSystemDecentralization.ModifiedUserId == null)
                  modifiedUserId = System.DBNull.Value;

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
                          command.Parameters.AddWithValue("@id", objSystemDecentralization.Id);
                      }

                      command.Parameters.AddWithValue("@userId", userId);
                      command.Parameters.AddWithValue("@staffId", staffId);
                      command.Parameters.AddWithValue("@createdDate", createdDate);
                      command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                      command.Parameters.AddWithValue("@createdUserId", createdUserId);
                      command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                      command.Parameters.AddWithValue("@isDeleted", objSystemDecentralization.IsDeleted);

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
              string storedProcName = "[dbo].[SystemDecentralization_Delete]";

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, int? userId, int? staffId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(userId != null)
                  command.Parameters.AddWithValue("@userId", userId);
              else
                  command.Parameters.AddWithValue("@userId", System.DBNull.Value);

              if(staffId != null)
                  command.Parameters.AddWithValue("@staffId", staffId);
              else
                  command.Parameters.AddWithValue("@staffId", System.DBNull.Value);

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

              if(isDeleted != null)
                  command.Parameters.AddWithValue("@isDeleted", isDeleted);
              else
                  command.Parameters.AddWithValue("@isDeleted", System.DBNull.Value);

         }

         /// <summary>
         /// Creates a SystemDecentralization object from the passed data row
         /// </summary>
         private static SystemDecentralizationModel CreateSystemDecentralizationFromDataRowShared(DataRow dr)
         {
             SystemDecentralizationModel objSystemDecentralization = new SystemDecentralizationModel();

             objSystemDecentralization.Id = (int)dr["Id"];

             if (dr["UserId"] != System.DBNull.Value)
                 objSystemDecentralization.UserId = (int)dr["UserId"];
             else
                 objSystemDecentralization.UserId = null;

             if (dr["StaffId"] != System.DBNull.Value)
                 objSystemDecentralization.StaffId = (int)dr["StaffId"];
             else
                 objSystemDecentralization.StaffId = null;

             if (dr["CreatedDate"] != System.DBNull.Value)
                 objSystemDecentralization.CreatedDate = (DateTime)dr["CreatedDate"];
             else
                 objSystemDecentralization.CreatedDate = null;

             if (dr["ModifiedDate"] != System.DBNull.Value)
                 objSystemDecentralization.ModifiedDate = (DateTime)dr["ModifiedDate"];
             else
                 objSystemDecentralization.ModifiedDate = null;

             if (dr["CreatedUserId"] != System.DBNull.Value)
                 objSystemDecentralization.CreatedUserId = (int)dr["CreatedUserId"];
             else
                 objSystemDecentralization.CreatedUserId = null;

             if (dr["ModifiedUserId"] != System.DBNull.Value)
                 objSystemDecentralization.ModifiedUserId = (int)dr["ModifiedUserId"];
             else
                 objSystemDecentralization.ModifiedUserId = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objSystemDecentralization.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objSystemDecentralization.IsDeleted = false;

             return objSystemDecentralization;
         }
     }
}
