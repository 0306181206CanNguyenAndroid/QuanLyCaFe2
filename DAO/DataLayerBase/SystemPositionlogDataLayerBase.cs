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
     /// Base class for SystemPositionlogDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the SystemPositionlogDataLayer class
     /// </summary>
     public class SystemPositionlogDataLayerBase
     {
         // constructor
         public SystemPositionlogDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static SystemPositionlogModel SelectByPrimaryKey(int id)
         {
              SystemPositionlogModel objSystemPositionlog = null;
              string storedProcName = "[dbo].[SystemPositionlog_SelectByPrimaryKey]";

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
                                  objSystemPositionlog = CreateSystemPositionlogFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objSystemPositionlog;
         }

         /// <summary>
         /// Gets the total number of records in the SystemPositionlog table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[SystemPositionlog_GetRecordCount]", null, null, true, null);
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
         /// Gets the total number of records in the SystemPositionlog table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, int? positionId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[SystemPositionlog_GetRecordCountWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, positionId, action, modifiedDate, modifiedUserId, isDeleted);

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
         /// Selects SystemPositionlog records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<SystemPositionlogModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[SystemPositionlog_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects SystemPositionlog records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<SystemPositionlogModel> SelectSkipAndTakeDynamicWhere(int? id, int? positionId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted, string sortByExpression, int startRowIndex, int rows)
         {
            List<SystemPositionlogModel> objSystemPositionlogCol = null;
              string storedProcName = "[dbo].[SystemPositionlog_SelectSkipAndTakeWhereDynamic]";

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
                      AddSearchCommandParamsShared(command, id, positionId, action, modifiedDate, modifiedUserId, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemPositionlogCol = new List<SystemPositionlogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemPositionlogModel objSystemPositionlog = CreateSystemPositionlogFromDataRowShared(dr);
                                      objSystemPositionlogCol.Add(objSystemPositionlog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemPositionlogCol;
         }

         /// <summary>
         /// Selects all SystemPositionlog
         /// </summary>
         public static List<SystemPositionlogModel> SelectAll()
         {
             return SelectShared("[dbo].[SystemPositionlog_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemPositionlog.
         /// </summary>
         public static List<SystemPositionlogModel> SelectAllDynamicWhere(int? id, int? positionId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
            List<SystemPositionlogModel> objSystemPositionlogCol = null;
              string storedProcName = "[dbo].[SystemPositionlog_SelectAllWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, positionId, action, modifiedDate, modifiedUserId, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemPositionlogCol = new List<SystemPositionlogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemPositionlogModel objSystemPositionlog = CreateSystemPositionlogFromDataRowShared(dr);
                                      objSystemPositionlogCol.Add(objSystemPositionlog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemPositionlogCol;
         }

         /// <summary>
         /// Selects Id and PositionId columns for use with a DropDownList web control
         /// </summary>
         public static List<SystemPositionlogModel> SelectSystemPositionlogDropDownListData()
         {
            List<SystemPositionlogModel> objSystemPositionlogCol = null;
              string storedProcName = "[dbo].[SystemPositionlog_SelectDropDownListData]";

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
                                  objSystemPositionlogCol = new List<SystemPositionlogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemPositionlogModel objSystemPositionlog = new SystemPositionlogModel();
                                      objSystemPositionlog.Id = (int)dr["Id"];

                                      if (dr["PositionId"] != System.DBNull.Value)
                                          objSystemPositionlog.PositionId = (int)(dr["PositionId"]);
                                      else
                                          objSystemPositionlog.PositionId = null;

                                      objSystemPositionlogCol.Add(objSystemPositionlog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemPositionlogCol;
         }

         public static List<SystemPositionlogModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<SystemPositionlogModel> objSystemPositionlogCol = null;

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
                                  objSystemPositionlogCol = new List<SystemPositionlogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemPositionlogModel objSystemPositionlog = CreateSystemPositionlogFromDataRowShared(dr);
                                      objSystemPositionlogCol.Add(objSystemPositionlog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemPositionlogCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(SystemPositionlogModel objSystemPositionlog)
         {
             string storedProcName = "[dbo].[SystemPositionlog_Insert]";
             return InsertUpdate(objSystemPositionlog, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(SystemPositionlogModel objSystemPositionlog)
         {
             string storedProcName = "[dbo].[SystemPositionlog_Update]";
             InsertUpdate(objSystemPositionlog, true, storedProcName);
         }

         private static int InsertUpdate(SystemPositionlogModel objSystemPositionlog, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objSystemPositionlog.Id;

              object positionId = objSystemPositionlog.PositionId;
              object action = objSystemPositionlog.Action;
              object modifiedDate = objSystemPositionlog.ModifiedDate;
              object modifiedUserId = objSystemPositionlog.ModifiedUserId;

              if (objSystemPositionlog.PositionId == null)
                  positionId = System.DBNull.Value;

              if (objSystemPositionlog.Action == null)
                  action = System.DBNull.Value;

              if (objSystemPositionlog.ModifiedDate == null)
                  modifiedDate = System.DBNull.Value;

              if (objSystemPositionlog.ModifiedUserId == null)
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
                          command.Parameters.AddWithValue("@id", objSystemPositionlog.Id);
                      }

                      command.Parameters.AddWithValue("@positionId", positionId);
                      command.Parameters.AddWithValue("@action", action);
                      command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                      command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                      command.Parameters.AddWithValue("@isDeleted", objSystemPositionlog.IsDeleted);

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
              string storedProcName = "[dbo].[SystemPositionlog_Delete]";

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, int? positionId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(positionId != null)
                  command.Parameters.AddWithValue("@positionId", positionId);
              else
                  command.Parameters.AddWithValue("@positionId", System.DBNull.Value);

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
         /// Creates a SystemPositionlog object from the passed data row
         /// </summary>
         private static SystemPositionlogModel CreateSystemPositionlogFromDataRowShared(DataRow dr)
         {
             SystemPositionlogModel objSystemPositionlog = new SystemPositionlogModel();

             objSystemPositionlog.Id = (int)dr["Id"];

             if (dr["PositionId"] != System.DBNull.Value)
                 objSystemPositionlog.PositionId = (int)dr["PositionId"];
             else
                 objSystemPositionlog.PositionId = null;

             if (dr["Action"] != System.DBNull.Value)
                 objSystemPositionlog.Action = (int)dr["Action"];
             else
                 objSystemPositionlog.Action = null;

             if (dr["ModifiedDate"] != System.DBNull.Value)
                 objSystemPositionlog.ModifiedDate = (DateTime)dr["ModifiedDate"];
             else
                 objSystemPositionlog.ModifiedDate = null;

             if (dr["ModifiedUserId"] != System.DBNull.Value)
                 objSystemPositionlog.ModifiedUserId = (int)dr["ModifiedUserId"];
             else
                 objSystemPositionlog.ModifiedUserId = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objSystemPositionlog.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objSystemPositionlog.IsDeleted = false;

             return objSystemPositionlog;
         }
     }
}
