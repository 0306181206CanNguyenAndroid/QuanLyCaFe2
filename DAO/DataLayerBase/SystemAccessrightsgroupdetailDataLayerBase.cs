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
     /// Base class for SystemAccessrightsgroupdetailDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the SystemAccessrightsgroupdetailDataLayer class
     /// </summary>
     public class SystemAccessrightsgroupdetailDataLayerBase
     {
         // constructor
         public SystemAccessrightsgroupdetailDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static SystemAccessrightsgroupdetailModel SelectByPrimaryKey(int id)
         {
              SystemAccessrightsgroupdetailModel objSystemAccessrightsgroupdetail = null;
              string storedProcName = "[dbo].[SystemAccessrightsgroupdetail_SelectByPrimaryKey]";

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
                                  objSystemAccessrightsgroupdetail = CreateSystemAccessrightsgroupdetailFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objSystemAccessrightsgroupdetail;
         }

         /// <summary>
         /// Gets the total number of records in the SystemAccessrightsgroupdetail table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[SystemAccessrightsgroupdetail_GetRecordCount]", null, null, true, null);
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
         /// Gets the total number of records in the SystemAccessrightsgroupdetail table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, int? groupId, int? accessRightsApplyId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[SystemAccessrightsgroupdetail_GetRecordCountWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, groupId, accessRightsApplyId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

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
         /// Selects SystemAccessrightsgroupdetail records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<SystemAccessrightsgroupdetailModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[SystemAccessrightsgroupdetail_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects SystemAccessrightsgroupdetail records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<SystemAccessrightsgroupdetailModel> SelectSkipAndTakeDynamicWhere(int? id, int? groupId, int? accessRightsApplyId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string sortByExpression, int startRowIndex, int rows)
         {
            List<SystemAccessrightsgroupdetailModel> objSystemAccessrightsgroupdetailCol = null;
              string storedProcName = "[dbo].[SystemAccessrightsgroupdetail_SelectSkipAndTakeWhereDynamic]";

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
                      AddSearchCommandParamsShared(command, id, groupId, accessRightsApplyId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemAccessrightsgroupdetailCol = new List<SystemAccessrightsgroupdetailModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemAccessrightsgroupdetailModel objSystemAccessrightsgroupdetail = CreateSystemAccessrightsgroupdetailFromDataRowShared(dr);
                                      objSystemAccessrightsgroupdetailCol.Add(objSystemAccessrightsgroupdetail);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemAccessrightsgroupdetailCol;
         }

         /// <summary>
         /// Selects all SystemAccessrightsgroupdetail
         /// </summary>
         public static List<SystemAccessrightsgroupdetailModel> SelectAll()
         {
             return SelectShared("[dbo].[SystemAccessrightsgroupdetail_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemAccessrightsgroupdetail.
         /// </summary>
         public static List<SystemAccessrightsgroupdetailModel> SelectAllDynamicWhere(int? id, int? groupId, int? accessRightsApplyId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
            List<SystemAccessrightsgroupdetailModel> objSystemAccessrightsgroupdetailCol = null;
              string storedProcName = "[dbo].[SystemAccessrightsgroupdetail_SelectAllWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, groupId, accessRightsApplyId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemAccessrightsgroupdetailCol = new List<SystemAccessrightsgroupdetailModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemAccessrightsgroupdetailModel objSystemAccessrightsgroupdetail = CreateSystemAccessrightsgroupdetailFromDataRowShared(dr);
                                      objSystemAccessrightsgroupdetailCol.Add(objSystemAccessrightsgroupdetail);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemAccessrightsgroupdetailCol;
         }

         /// <summary>
         /// Selects Id and GroupId columns for use with a DropDownList web control
         /// </summary>
         public static List<SystemAccessrightsgroupdetailModel> SelectSystemAccessrightsgroupdetailDropDownListData()
         {
            List<SystemAccessrightsgroupdetailModel> objSystemAccessrightsgroupdetailCol = null;
              string storedProcName = "[dbo].[SystemAccessrightsgroupdetail_SelectDropDownListData]";

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
                                  objSystemAccessrightsgroupdetailCol = new List<SystemAccessrightsgroupdetailModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemAccessrightsgroupdetailModel objSystemAccessrightsgroupdetail = new SystemAccessrightsgroupdetailModel();
                                      objSystemAccessrightsgroupdetail.Id = (int)dr["Id"];

                                      if (dr["GroupId"] != System.DBNull.Value)
                                          objSystemAccessrightsgroupdetail.GroupId = (int)(dr["GroupId"]);
                                      else
                                          objSystemAccessrightsgroupdetail.GroupId = null;

                                      objSystemAccessrightsgroupdetailCol.Add(objSystemAccessrightsgroupdetail);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemAccessrightsgroupdetailCol;
         }

         public static List<SystemAccessrightsgroupdetailModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<SystemAccessrightsgroupdetailModel> objSystemAccessrightsgroupdetailCol = null;

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
                                  objSystemAccessrightsgroupdetailCol = new List<SystemAccessrightsgroupdetailModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemAccessrightsgroupdetailModel objSystemAccessrightsgroupdetail = CreateSystemAccessrightsgroupdetailFromDataRowShared(dr);
                                      objSystemAccessrightsgroupdetailCol.Add(objSystemAccessrightsgroupdetail);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemAccessrightsgroupdetailCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(SystemAccessrightsgroupdetailModel objSystemAccessrightsgroupdetail)
         {
             string storedProcName = "[dbo].[SystemAccessrightsgroupdetail_Insert]";
             return InsertUpdate(objSystemAccessrightsgroupdetail, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(SystemAccessrightsgroupdetailModel objSystemAccessrightsgroupdetail)
         {
             string storedProcName = "[dbo].[SystemAccessrightsgroupdetail_Update]";
             InsertUpdate(objSystemAccessrightsgroupdetail, true, storedProcName);
         }

         private static int InsertUpdate(SystemAccessrightsgroupdetailModel objSystemAccessrightsgroupdetail, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objSystemAccessrightsgroupdetail.Id;

              object groupId = objSystemAccessrightsgroupdetail.GroupId;
              object accessRightsApplyId = objSystemAccessrightsgroupdetail.AccessRightsApplyId;
              object createdDate = objSystemAccessrightsgroupdetail.CreatedDate;
              object modifiedDate = objSystemAccessrightsgroupdetail.ModifiedDate;
              object createdUserId = objSystemAccessrightsgroupdetail.CreatedUserId;
              object modifiedUserId = objSystemAccessrightsgroupdetail.ModifiedUserId;
              object status = objSystemAccessrightsgroupdetail.Status;

              if (objSystemAccessrightsgroupdetail.GroupId == null)
                  groupId = System.DBNull.Value;

              if (objSystemAccessrightsgroupdetail.AccessRightsApplyId == null)
                  accessRightsApplyId = System.DBNull.Value;

              if (objSystemAccessrightsgroupdetail.CreatedDate == null)
                  createdDate = System.DBNull.Value;

              if (objSystemAccessrightsgroupdetail.ModifiedDate == null)
                  modifiedDate = System.DBNull.Value;

              if (objSystemAccessrightsgroupdetail.CreatedUserId == null)
                  createdUserId = System.DBNull.Value;

              if (objSystemAccessrightsgroupdetail.ModifiedUserId == null)
                  modifiedUserId = System.DBNull.Value;

              if (objSystemAccessrightsgroupdetail.Status == null)
                  status = System.DBNull.Value;

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
                          command.Parameters.AddWithValue("@id", objSystemAccessrightsgroupdetail.Id);
                      }

                      command.Parameters.AddWithValue("@groupId", groupId);
                      command.Parameters.AddWithValue("@accessRightsApplyId", accessRightsApplyId);
                      command.Parameters.AddWithValue("@createdDate", createdDate);
                      command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                      command.Parameters.AddWithValue("@createdUserId", createdUserId);
                      command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                      command.Parameters.AddWithValue("@isDeleted", objSystemAccessrightsgroupdetail.IsDeleted);
                      command.Parameters.AddWithValue("@status", status);

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
              string storedProcName = "[dbo].[SystemAccessrightsgroupdetail_Delete]";

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, int? groupId, int? accessRightsApplyId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(groupId != null)
                  command.Parameters.AddWithValue("@groupId", groupId);
              else
                  command.Parameters.AddWithValue("@groupId", System.DBNull.Value);

              if(accessRightsApplyId != null)
                  command.Parameters.AddWithValue("@accessRightsApplyId", accessRightsApplyId);
              else
                  command.Parameters.AddWithValue("@accessRightsApplyId", System.DBNull.Value);

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

              if(status != null)
                  command.Parameters.AddWithValue("@status", status);
              else
                  command.Parameters.AddWithValue("@status", System.DBNull.Value);

         }

         /// <summary>
         /// Creates a SystemAccessrightsgroupdetail object from the passed data row
         /// </summary>
         private static SystemAccessrightsgroupdetailModel CreateSystemAccessrightsgroupdetailFromDataRowShared(DataRow dr)
         {
             SystemAccessrightsgroupdetailModel objSystemAccessrightsgroupdetail = new SystemAccessrightsgroupdetailModel();

             objSystemAccessrightsgroupdetail.Id = (int)dr["Id"];

             if (dr["GroupId"] != System.DBNull.Value)
                 objSystemAccessrightsgroupdetail.GroupId = (int)dr["GroupId"];
             else
                 objSystemAccessrightsgroupdetail.GroupId = null;

             if (dr["AccessRightsApplyId"] != System.DBNull.Value)
                 objSystemAccessrightsgroupdetail.AccessRightsApplyId = (int)dr["AccessRightsApplyId"];
             else
                 objSystemAccessrightsgroupdetail.AccessRightsApplyId = null;

             if (dr["CreatedDate"] != System.DBNull.Value)
                 objSystemAccessrightsgroupdetail.CreatedDate = (DateTime)dr["CreatedDate"];
             else
                 objSystemAccessrightsgroupdetail.CreatedDate = null;

             if (dr["ModifiedDate"] != System.DBNull.Value)
                 objSystemAccessrightsgroupdetail.ModifiedDate = (DateTime)dr["ModifiedDate"];
             else
                 objSystemAccessrightsgroupdetail.ModifiedDate = null;

             if (dr["CreatedUserId"] != System.DBNull.Value)
                 objSystemAccessrightsgroupdetail.CreatedUserId = (int)dr["CreatedUserId"];
             else
                 objSystemAccessrightsgroupdetail.CreatedUserId = null;

             if (dr["ModifiedUserId"] != System.DBNull.Value)
                 objSystemAccessrightsgroupdetail.ModifiedUserId = (int)dr["ModifiedUserId"];
             else
                 objSystemAccessrightsgroupdetail.ModifiedUserId = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objSystemAccessrightsgroupdetail.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objSystemAccessrightsgroupdetail.IsDeleted = false;

             if (dr["Status"] != System.DBNull.Value)
                 objSystemAccessrightsgroupdetail.Status = (int)dr["Status"];
             else
                 objSystemAccessrightsgroupdetail.Status = null;

             return objSystemAccessrightsgroupdetail;
         }
     }
}
