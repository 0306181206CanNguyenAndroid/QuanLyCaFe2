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
     /// Base class for SystemAccessrightsgroupDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the SystemAccessrightsgroupDataLayer class
     /// </summary>
     public class SystemAccessrightsgroupDataLayerBase
     {
         // constructor
         public SystemAccessrightsgroupDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static SystemAccessrightsgroupModel SelectByPrimaryKey(int id)
         {
              SystemAccessrightsgroupModel objSystemAccessrightsgroup = null;
              string storedProcName = "[dbo].[SystemAccessrightsgroup_SelectByPrimaryKey]";

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
                                  objSystemAccessrightsgroup = CreateSystemAccessrightsgroupFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objSystemAccessrightsgroup;
         }

         /// <summary>
         /// Gets the total number of records in the SystemAccessrightsgroup table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[SystemAccessrightsgroup_GetRecordCount]", null, null, true, null);
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
         /// Gets the total number of records in the SystemAccessrightsgroup table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[SystemAccessrightsgroup_GetRecordCountWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

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
         /// Selects SystemAccessrightsgroup records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<SystemAccessrightsgroupModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[SystemAccessrightsgroup_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects SystemAccessrightsgroup records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<SystemAccessrightsgroupModel> SelectSkipAndTakeDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string sortByExpression, int startRowIndex, int rows)
         {
            List<SystemAccessrightsgroupModel> objSystemAccessrightsgroupCol = null;
              string storedProcName = "[dbo].[SystemAccessrightsgroup_SelectSkipAndTakeWhereDynamic]";

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
                      AddSearchCommandParamsShared(command, id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemAccessrightsgroupCol = new List<SystemAccessrightsgroupModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemAccessrightsgroupModel objSystemAccessrightsgroup = CreateSystemAccessrightsgroupFromDataRowShared(dr);
                                      objSystemAccessrightsgroupCol.Add(objSystemAccessrightsgroup);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemAccessrightsgroupCol;
         }

         /// <summary>
         /// Selects all SystemAccessrightsgroup
         /// </summary>
         public static List<SystemAccessrightsgroupModel> SelectAll()
         {
             return SelectShared("[dbo].[SystemAccessrightsgroup_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemAccessrightsgroup.
         /// </summary>
         public static List<SystemAccessrightsgroupModel> SelectAllDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
            List<SystemAccessrightsgroupModel> objSystemAccessrightsgroupCol = null;
              string storedProcName = "[dbo].[SystemAccessrightsgroup_SelectAllWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemAccessrightsgroupCol = new List<SystemAccessrightsgroupModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemAccessrightsgroupModel objSystemAccessrightsgroup = CreateSystemAccessrightsgroupFromDataRowShared(dr);
                                      objSystemAccessrightsgroupCol.Add(objSystemAccessrightsgroup);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemAccessrightsgroupCol;
         }

         /// <summary>
         /// Selects Id and Name columns for use with a DropDownList web control
         /// </summary>
         public static List<SystemAccessrightsgroupModel> SelectSystemAccessrightsgroupDropDownListData()
         {
            List<SystemAccessrightsgroupModel> objSystemAccessrightsgroupCol = null;
              string storedProcName = "[dbo].[SystemAccessrightsgroup_SelectDropDownListData]";

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
                                  objSystemAccessrightsgroupCol = new List<SystemAccessrightsgroupModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemAccessrightsgroupModel  objSystemAccessrightsgroup = new SystemAccessrightsgroupModel();
                                      objSystemAccessrightsgroup.Id = (int)dr["Id"];

                                      if (dr["Name"] != System.DBNull.Value)
                                          objSystemAccessrightsgroup.Name = (string)(dr["Name"]);
                                      else
                                          objSystemAccessrightsgroup.Name = null;

                                      objSystemAccessrightsgroupCol.Add(objSystemAccessrightsgroup);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemAccessrightsgroupCol;
         }

         public static List<SystemAccessrightsgroupModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<SystemAccessrightsgroupModel> objSystemAccessrightsgroupCol = null;

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
                                  objSystemAccessrightsgroupCol = new List<SystemAccessrightsgroupModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemAccessrightsgroupModel objSystemAccessrightsgroup = CreateSystemAccessrightsgroupFromDataRowShared(dr);
                                      objSystemAccessrightsgroupCol.Add(objSystemAccessrightsgroup);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemAccessrightsgroupCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(SystemAccessrightsgroupModel objSystemAccessrightsgroup)
         {
             string storedProcName = "[dbo].[SystemAccessrightsgroup_Insert]";
             return InsertUpdate(objSystemAccessrightsgroup, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(SystemAccessrightsgroupModel objSystemAccessrightsgroup)
         {
             string storedProcName = "[dbo].[SystemAccessrightsgroup_Update]";
             InsertUpdate(objSystemAccessrightsgroup, true, storedProcName);
         }

         private static int InsertUpdate(SystemAccessrightsgroupModel objSystemAccessrightsgroup, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objSystemAccessrightsgroup.Id;

              object name = objSystemAccessrightsgroup.Name;
              object createdDate = objSystemAccessrightsgroup.CreatedDate;
              object modifiedDate = objSystemAccessrightsgroup.ModifiedDate;
              object createdUserId = objSystemAccessrightsgroup.CreatedUserId;
              object modifiedUserId = objSystemAccessrightsgroup.ModifiedUserId;
              object status = objSystemAccessrightsgroup.Status;

              if (String.IsNullOrEmpty(objSystemAccessrightsgroup.Name))
                  name = System.DBNull.Value;

              if (objSystemAccessrightsgroup.CreatedDate == null)
                  createdDate = System.DBNull.Value;

              if (objSystemAccessrightsgroup.ModifiedDate == null)
                  modifiedDate = System.DBNull.Value;

              if (objSystemAccessrightsgroup.CreatedUserId == null)
                  createdUserId = System.DBNull.Value;

              if (objSystemAccessrightsgroup.ModifiedUserId == null)
                  modifiedUserId = System.DBNull.Value;

              if (objSystemAccessrightsgroup.Status == null)
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
                          command.Parameters.AddWithValue("@id", objSystemAccessrightsgroup.Id);
                      }

                      command.Parameters.AddWithValue("@name", name);
                      command.Parameters.AddWithValue("@createdDate", createdDate);
                      command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                      command.Parameters.AddWithValue("@createdUserId", createdUserId);
                      command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                      command.Parameters.AddWithValue("@isDeleted", objSystemAccessrightsgroup.IsDeleted);
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
              string storedProcName = "[dbo].[SystemAccessrightsgroup_Delete]";

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
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
         /// Creates a SystemAccessrightsgroup object from the passed data row
         /// </summary>
         private static SystemAccessrightsgroupModel CreateSystemAccessrightsgroupFromDataRowShared(DataRow dr)
         {
             SystemAccessrightsgroupModel objSystemAccessrightsgroup = new SystemAccessrightsgroupModel();

             objSystemAccessrightsgroup.Id = (int)dr["Id"];

             if (dr["Name"] != System.DBNull.Value)
                 objSystemAccessrightsgroup.Name = dr["Name"].ToString();
             else
                 objSystemAccessrightsgroup.Name = null;

             if (dr["CreatedDate"] != System.DBNull.Value)
                 objSystemAccessrightsgroup.CreatedDate = (DateTime)dr["CreatedDate"];
             else
                 objSystemAccessrightsgroup.CreatedDate = null;

             if (dr["ModifiedDate"] != System.DBNull.Value)
                 objSystemAccessrightsgroup.ModifiedDate = (DateTime)dr["ModifiedDate"];
             else
                 objSystemAccessrightsgroup.ModifiedDate = null;

             if (dr["CreatedUserId"] != System.DBNull.Value)
                 objSystemAccessrightsgroup.CreatedUserId = (int)dr["CreatedUserId"];
             else
                 objSystemAccessrightsgroup.CreatedUserId = null;

             if (dr["ModifiedUserId"] != System.DBNull.Value)
                 objSystemAccessrightsgroup.ModifiedUserId = (int)dr["ModifiedUserId"];
             else
                 objSystemAccessrightsgroup.ModifiedUserId = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objSystemAccessrightsgroup.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objSystemAccessrightsgroup.IsDeleted = false;

             if (dr["Status"] != System.DBNull.Value)
                 objSystemAccessrightsgroup.Status = (int)dr["Status"];
             else
                 objSystemAccessrightsgroup.Status = null;

             return objSystemAccessrightsgroup;
         }
     }
}
