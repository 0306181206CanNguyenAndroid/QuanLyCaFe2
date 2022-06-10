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
     /// Base class for SystemStafflogDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the SystemStafflogDataLayer class
     /// </summary>
     public class SystemStafflogDataLayerBase
     {
         // constructor
         public SystemStafflogDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static SystemStafflogModel SelectByPrimaryKey(int id)
         {
              SystemStafflogModel objSystemStafflog = null;
              string storedProcName = "[dbo].[SystemStafflog_SelectByPrimaryKey]";

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
                                  objSystemStafflog = CreateSystemStafflogFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objSystemStafflog;
         }

         /// <summary>
         /// Gets the total number of records in the SystemStafflog table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[SystemStafflog_GetRecordCount]", null, null, true, null);
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
         /// Gets the total number of records in the SystemStafflog table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, int? staffId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[SystemStafflog_GetRecordCountWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, staffId, action, modifiedDate, modifiedUserId, isDeleted);

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
         /// Selects SystemStafflog records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<SystemStafflogModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[SystemStafflog_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects SystemStafflog records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<SystemStafflogModel> SelectSkipAndTakeDynamicWhere(int? id, int? staffId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted, string sortByExpression, int startRowIndex, int rows)
         {
              List<SystemStafflogModel> objSystemStafflogCol = null;
              string storedProcName = "[dbo].[SystemStafflog_SelectSkipAndTakeWhereDynamic]";

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
                      AddSearchCommandParamsShared(command, id, staffId, action, modifiedDate, modifiedUserId, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemStafflogCol = new List<SystemStafflogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemStafflogModel objSystemStafflog = CreateSystemStafflogFromDataRowShared(dr);
                                      objSystemStafflogCol.Add(objSystemStafflog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemStafflogCol;
         }

         /// <summary>
         /// Selects all SystemStafflog
         /// </summary>
         public static List<SystemStafflogModel> SelectAll()
         {
             return SelectShared("[dbo].[SystemStafflog_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemStafflog.
         /// </summary>
         public static List<SystemStafflogModel> SelectAllDynamicWhere(int? id, int? staffId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
            List<SystemStafflogModel> objSystemStafflogCol = null;
              string storedProcName = "[dbo].[SystemStafflog_SelectAllWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, staffId, action, modifiedDate, modifiedUserId, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemStafflogCol = new List<SystemStafflogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemStafflogModel objSystemStafflog = CreateSystemStafflogFromDataRowShared(dr);
                                      objSystemStafflogCol.Add(objSystemStafflog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemStafflogCol;
         }

         /// <summary>
         /// Selects Id and StaffId columns for use with a DropDownList web control
         /// </summary>
         public static List<SystemStafflogModel> SelectSystemStafflogDropDownListData()
         {
            List<SystemStafflogModel> objSystemStafflogCol = null;
              string storedProcName = "[dbo].[SystemStafflog_SelectDropDownListData]";

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
                                  objSystemStafflogCol = new List<SystemStafflogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemStafflogModel objSystemStafflog = new SystemStafflogModel();
                                      objSystemStafflog.Id = (int)dr["Id"];

                                      if (dr["StaffId"] != System.DBNull.Value)
                                          objSystemStafflog.StaffId = (int)(dr["StaffId"]);
                                      else
                                          objSystemStafflog.StaffId = null;

                                      objSystemStafflogCol.Add(objSystemStafflog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemStafflogCol;
         }

         public static List<SystemStafflogModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<SystemStafflogModel> objSystemStafflogCol = null;

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
                                  objSystemStafflogCol = new List<SystemStafflogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemStafflogModel objSystemStafflog = CreateSystemStafflogFromDataRowShared(dr);
                                      objSystemStafflogCol.Add(objSystemStafflog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemStafflogCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(SystemStafflogModel objSystemStafflog)
         {
             string storedProcName = "[dbo].[SystemStafflog_Insert]";
             return InsertUpdate(objSystemStafflog, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(SystemStafflogModel objSystemStafflog)
         {
             string storedProcName = "[dbo].[SystemStafflog_Update]";
             InsertUpdate(objSystemStafflog, true, storedProcName);
         }

         private static int InsertUpdate(SystemStafflogModel objSystemStafflog, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objSystemStafflog.Id;

              object staffId = objSystemStafflog.StaffId;
              object action = objSystemStafflog.Action;
              object modifiedDate = objSystemStafflog.ModifiedDate;
              object modifiedUserId = objSystemStafflog.ModifiedUserId;

              if (objSystemStafflog.StaffId == null)
                  staffId = System.DBNull.Value;

              if (objSystemStafflog.Action == null)
                  action = System.DBNull.Value;

              if (objSystemStafflog.ModifiedDate == null)
                  modifiedDate = System.DBNull.Value;

              if (objSystemStafflog.ModifiedUserId == null)
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
                          command.Parameters.AddWithValue("@id", objSystemStafflog.Id);
                      }

                      command.Parameters.AddWithValue("@staffId", staffId);
                      command.Parameters.AddWithValue("@action", action);
                      command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                      command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                      command.Parameters.AddWithValue("@isDeleted", objSystemStafflog.IsDeleted);

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
              string storedProcName = "[dbo].[SystemStafflog_Delete]";

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, int? staffId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(staffId != null)
                  command.Parameters.AddWithValue("@staffId", staffId);
              else
                  command.Parameters.AddWithValue("@staffId", System.DBNull.Value);

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
         /// Creates a SystemStafflog object from the passed data row
         /// </summary>
         private static SystemStafflogModel CreateSystemStafflogFromDataRowShared(DataRow dr)
         {
             SystemStafflogModel objSystemStafflog = new SystemStafflogModel();

             objSystemStafflog.Id = (int)dr["Id"];

             if (dr["StaffId"] != System.DBNull.Value)
                 objSystemStafflog.StaffId = (int)dr["StaffId"];
             else
                 objSystemStafflog.StaffId = null;

             if (dr["Action"] != System.DBNull.Value)
                 objSystemStafflog.Action = (int)dr["Action"];
             else
                 objSystemStafflog.Action = null;

             if (dr["ModifiedDate"] != System.DBNull.Value)
                 objSystemStafflog.ModifiedDate = (DateTime)dr["ModifiedDate"];
             else
                 objSystemStafflog.ModifiedDate = null;

             if (dr["ModifiedUserId"] != System.DBNull.Value)
                 objSystemStafflog.ModifiedUserId = (int)dr["ModifiedUserId"];
             else
                 objSystemStafflog.ModifiedUserId = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objSystemStafflog.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objSystemStafflog.IsDeleted = false;

             return objSystemStafflog;
         }
     }
}
