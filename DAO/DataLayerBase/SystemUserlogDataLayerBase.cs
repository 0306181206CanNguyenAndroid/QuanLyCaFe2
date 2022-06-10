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
     /// Base class for SystemUserlogDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the SystemUserlogDataLayer class
     /// </summary>
     public class SystemUserlogDataLayerBase
     {
         // constructor
         public SystemUserlogDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static SystemUserlogModel SelectByPrimaryKey(int id)
         {
              SystemUserlogModel objSystemUserlog = null;
              string storedProcName = "[dbo].[SystemUserlog_SelectByPrimaryKey]";

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
                                  objSystemUserlog = CreateSystemUserlogFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objSystemUserlog;
         }

         /// <summary>
         /// Gets the total number of records in the SystemUserlog table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[SystemUserlog_GetRecordCount]", null, null, true, null);
         }

         /// <summary>
         /// Gets the total number of records in the SystemUserlog table by UserId
         /// </summary>
         public static int GetRecordCountByUserId(int userId)
         {
             return GetRecordCountShared("[dbo].[SystemUserlog_GetRecordCountByUserId]", "userId", userId, true, null);
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

                      // parameters
                      switch (param)
                      {
                          case "userId":
                              command.Parameters.AddWithValue("@userId", paramValue);
                              break;
                          default:
                              break;
                      }

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
         /// Gets the total number of records in the SystemUserlog table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, int? userId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[SystemUserlog_GetRecordCountWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, userId, action, modifiedDate, modifiedUserId, isDeleted);

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
         /// Selects SystemUserlog records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<SystemUserlogModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[SystemUserlog_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records by UserId as a collection (List) of SystemUserlog sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<SystemUserlogModel> SelectSkipAndTakeByUserId(string sortByExpression, int startRowIndex, int rows, int userId)
         {
             return SelectShared("[dbo].[SystemUserlog_SelectSkipAndTakeByUserId]", "userId", userId, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects SystemUserlog records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<SystemUserlogModel> SelectSkipAndTakeDynamicWhere(int? id, int? userId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted, string sortByExpression, int startRowIndex, int rows)
         {
            List<SystemUserlogModel> objSystemUserlogCol = null;
              string storedProcName = "[dbo].[SystemUserlog_SelectSkipAndTakeWhereDynamic]";

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
                      AddSearchCommandParamsShared(command, id, userId, action, modifiedDate, modifiedUserId, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemUserlogCol = new List<SystemUserlogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemUserlogModel objSystemUserlog = CreateSystemUserlogFromDataRowShared(dr);
                                      objSystemUserlogCol.Add(objSystemUserlog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemUserlogCol;
         }

         /// <summary>
         /// Selects all SystemUserlog
         /// </summary>
         public static List<SystemUserlogModel> SelectAll()
         {
             return SelectShared("[dbo].[SystemUserlog_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemUserlog.
         /// </summary>
         public static List<SystemUserlogModel> SelectAllDynamicWhere(int? id, int? userId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
            List<SystemUserlogModel> objSystemUserlogCol = null;
              string storedProcName = "[dbo].[SystemUserlog_SelectAllWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, userId, action, modifiedDate, modifiedUserId, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemUserlogCol = new List<SystemUserlogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemUserlogModel objSystemUserlog = CreateSystemUserlogFromDataRowShared(dr);
                                      objSystemUserlogCol.Add(objSystemUserlog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemUserlogCol;
         }

         /// <summary>
         /// Selects all SystemUserlog by SystemUser, related to column UserId
         /// </summary>
         public static List<SystemUserlogModel> SelectSystemUserlogCollectionByUserId(int id)
         {
             return SelectShared("[dbo].[SystemUserlog_SelectAllByUserId]", "userId", id);
         }

         /// <summary>
         /// Selects Id and Action columns for use with a DropDownList web control
         /// </summary>
         public static List<SystemUserlogModel> SelectSystemUserlogDropDownListData()
         {
            List<SystemUserlogModel> objSystemUserlogCol = null;
              string storedProcName = "[dbo].[SystemUserlog_SelectDropDownListData]";

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
                                  objSystemUserlogCol = new List<SystemUserlogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemUserlogModel objSystemUserlog = new SystemUserlogModel();
                                      objSystemUserlog.Id = (int)dr["Id"];

                                      if (dr["Action"] != System.DBNull.Value)
                                          objSystemUserlog.Action = (int)(dr["Action"]);
                                      else
                                          objSystemUserlog.Action = null;

                                      objSystemUserlogCol.Add(objSystemUserlog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemUserlogCol;
         }

         public static List<SystemUserlogModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<SystemUserlogModel> objSystemUserlogCol = null;

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

                      // parameters
                      switch (param)
                      {
                          case "userId":
                              command.Parameters.AddWithValue("@userId", paramValue);
                              break;
                          default:
                              break;
                      }

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemUserlogCol = new List<SystemUserlogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemUserlogModel objSystemUserlog = CreateSystemUserlogFromDataRowShared(dr);
                                      objSystemUserlogCol.Add(objSystemUserlog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemUserlogCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(SystemUserlogModel objSystemUserlog)
         {
             string storedProcName = "[dbo].[SystemUserlog_Insert]";
             return InsertUpdate(objSystemUserlog, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(SystemUserlogModel objSystemUserlog)
         {
             string storedProcName = "[dbo].[SystemUserlog_Update]";
             InsertUpdate(objSystemUserlog, true, storedProcName);
         }

         private static int InsertUpdate(SystemUserlogModel objSystemUserlog, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objSystemUserlog.Id;

              object userId = objSystemUserlog.UserId;
              object action = objSystemUserlog.Action;
              object modifiedDate = objSystemUserlog.ModifiedDate;
              object modifiedUserId = objSystemUserlog.ModifiedUserId;

              if (objSystemUserlog.UserId == null)
                  userId = System.DBNull.Value;

              if (objSystemUserlog.Action == null)
                  action = System.DBNull.Value;

              if (objSystemUserlog.ModifiedDate == null)
                  modifiedDate = System.DBNull.Value;

              if (objSystemUserlog.ModifiedUserId == null)
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
                          command.Parameters.AddWithValue("@id", objSystemUserlog.Id);
                      }

                      command.Parameters.AddWithValue("@userId", userId);
                      command.Parameters.AddWithValue("@action", action);
                      command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                      command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                      command.Parameters.AddWithValue("@isDeleted", objSystemUserlog.IsDeleted);

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
              string storedProcName = "[dbo].[SystemUserlog_Delete]";

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, int? userId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(userId != null)
                  command.Parameters.AddWithValue("@userId", userId);
              else
                  command.Parameters.AddWithValue("@userId", System.DBNull.Value);

              if(action != null)
                  command.Parameters.AddWithValue("@action", action);
              else
                  command.Parameters.AddWithValue("@action", System.DBNull.Value);

              if(modifiedDate != null)
                  command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
              else
                  command.Parameters.AddWithValue("@modifiedDate", System.DBNull.Value);

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
         /// Creates a SystemUserlog object from the passed data row
         /// </summary>
         private static SystemUserlogModel CreateSystemUserlogFromDataRowShared(DataRow dr)
         {
             SystemUserlogModel objSystemUserlog = new SystemUserlogModel();

             objSystemUserlog.Id = (int)dr["Id"];

             if (dr["UserId"] != System.DBNull.Value)
                 objSystemUserlog.UserId = (int)dr["UserId"];
             else
                 objSystemUserlog.UserId = null;


             if (dr["Action"] != System.DBNull.Value)
                 objSystemUserlog.Action = (int)dr["Action"];
             else
                 objSystemUserlog.Action = null;

             if (dr["ModifiedDate"] != System.DBNull.Value)
                 objSystemUserlog.ModifiedDate = (DateTime)dr["ModifiedDate"];
             else
                 objSystemUserlog.ModifiedDate = null;

             if (dr["ModifiedUserId"] != System.DBNull.Value)
                 objSystemUserlog.ModifiedUserId = (int)dr["ModifiedUserId"];
             else
                 objSystemUserlog.ModifiedUserId = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objSystemUserlog.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objSystemUserlog.IsDeleted = false;

             return objSystemUserlog;
         }
     }
}
