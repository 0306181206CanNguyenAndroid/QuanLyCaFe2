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
     /// Base class for SystemUserDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the SystemUserDataLayer class
     /// </summary>
     public class SystemUserDataLayerBase
     {
         // constructor
         public SystemUserDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static UserModel SelectByPrimaryKey(int id)
         {
              UserModel objSystemUser = null;
              string storedProcName = "[dbo].[SystemUser_SelectByPrimaryKey]";

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
                                  objSystemUser = CreateSystemUserFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objSystemUser;
         }

         /// <summary>
         /// Gets the total number of records in the SystemUser table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[SystemUser_GetRecordCount]", null, null, true, null);
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
         /// Gets the total number of records in the SystemUser table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string userName, string pass, string name, string image, int? accessRightsGroup, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[SystemUser_GetRecordCountWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, userName, pass, name, image, accessRightsGroup, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

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
         /// Selects SystemUser records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<UserModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[SystemUser_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects SystemUser records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<UserModel> SelectSkipAndTakeDynamicWhere(int? id, string userName, string pass, string name, string image, int? accessRightsGroup, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string sortByExpression, int startRowIndex, int rows)
         {
            List<UserModel> objSystemUserCol = null;
              string storedProcName = "[dbo].[SystemUser_SelectSkipAndTakeWhereDynamic]";

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
                      AddSearchCommandParamsShared(command, id, userName, pass, name, image, accessRightsGroup, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemUserCol = new List<UserModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      UserModel objSystemUser = CreateSystemUserFromDataRowShared(dr);
                                      objSystemUserCol.Add(objSystemUser);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemUserCol;
         }

         /// <summary>
         /// Selects all SystemUser
         /// </summary>
         public static List<UserModel> SelectAll()
         {
             return SelectShared("[dbo].[SystemUser_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemUser.
         /// </summary>
         public static List<UserModel> SelectAllDynamicWhere(int? id, string userName, string pass, string name, string image, int? accessRightsGroup, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
            List<UserModel> objSystemUserCol = null;
              string storedProcName = "[dbo].[SystemUser_SelectAllWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, userName, pass, name, image, accessRightsGroup, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemUserCol = new List<UserModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      UserModel objSystemUser = CreateSystemUserFromDataRowShared(dr);
                                      objSystemUserCol.Add(objSystemUser);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemUserCol;
         }

         /// <summary>
         /// Selects Id and UserName columns for use with a DropDownList web control
         /// </summary>
         public static List<UserModel> SelectSystemUserDropDownListData()
         {
            List<UserModel> objSystemUserCol = null;
              string storedProcName = "[dbo].[SystemUser_SelectDropDownListData]";

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
                                  objSystemUserCol = new List<UserModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      UserModel objSystemUser = new UserModel();
                                      objSystemUser.Id = (int)dr["Id"];

                                      if (dr["UserName"] != System.DBNull.Value)
                                          objSystemUser.UserName = (string)(dr["UserName"]);
                                      else
                                          objSystemUser.UserName = null;

                                      objSystemUserCol.Add(objSystemUser);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemUserCol;
         }

         public static List<UserModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<UserModel> objSystemUserCol = null;

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
                                  objSystemUserCol = new List<UserModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      UserModel objSystemUser = CreateSystemUserFromDataRowShared(dr);
                                      objSystemUserCol.Add(objSystemUser);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemUserCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(UserModel objSystemUser)
         {
             string storedProcName = "[dbo].[SystemUser_Insert]";
             return InsertUpdate(objSystemUser, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(UserModel objSystemUser)
         {
             string storedProcName = "[dbo].[SystemUser_Update]";
             InsertUpdate(objSystemUser, true, storedProcName);
         }

         private static int InsertUpdate(UserModel objSystemUser, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objSystemUser.Id;

              object userName = objSystemUser.UserName;
              object pass = objSystemUser.Pass;
              object name = objSystemUser.Name;
              object image = objSystemUser.Image;
              object accessRightsGroup = objSystemUser.AccessRightsGroup;
              object createdDate = objSystemUser.CreatedDate;
              object modifiedDate = objSystemUser.ModifiedDate;
              object createdUserId = objSystemUser.CreatedUserId;
              object modifiedUserId = objSystemUser.ModifiedUserId;
              object status = objSystemUser.Status;

              if (String.IsNullOrEmpty(objSystemUser.UserName))
                  userName = System.DBNull.Value;

              if (String.IsNullOrEmpty(objSystemUser.Pass))
                  pass = System.DBNull.Value;

              if (String.IsNullOrEmpty(objSystemUser.Name))
                  name = System.DBNull.Value;

              if (String.IsNullOrEmpty(objSystemUser.Image))
                  image = System.DBNull.Value;

              if (objSystemUser.AccessRightsGroup == null)
                  accessRightsGroup = System.DBNull.Value;

              if (objSystemUser.CreatedDate == null)
                  createdDate = System.DBNull.Value;

              if (objSystemUser.ModifiedDate == null)
                  modifiedDate = System.DBNull.Value;

              if (objSystemUser.CreatedUserId == null)
                  createdUserId = System.DBNull.Value;

              if (objSystemUser.ModifiedUserId == null)
                  modifiedUserId = System.DBNull.Value;

              if (objSystemUser.Status == null)
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
                          command.Parameters.AddWithValue("@id", objSystemUser.Id);
                      }

                      command.Parameters.AddWithValue("@userName", userName);
                      command.Parameters.AddWithValue("@pass", pass);
                      command.Parameters.AddWithValue("@name", name);
                      command.Parameters.AddWithValue("@image", image);
                      command.Parameters.AddWithValue("@accessRightsGroup", accessRightsGroup);
                      command.Parameters.AddWithValue("@createdDate", createdDate);
                      command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                      command.Parameters.AddWithValue("@createdUserId", createdUserId);
                      command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                      command.Parameters.AddWithValue("@isDeleted", objSystemUser.IsDeleted);
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
              string storedProcName = "[dbo].[SystemUser_Delete]";

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, string userName, string pass, string name, string image, int? accessRightsGroup, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(!String.IsNullOrEmpty(userName))
                  command.Parameters.AddWithValue("@userName", userName);
              else
                  command.Parameters.AddWithValue("@userName", System.DBNull.Value);

              if(!String.IsNullOrEmpty(pass))
                  command.Parameters.AddWithValue("@pass", pass);
              else
                  command.Parameters.AddWithValue("@pass", System.DBNull.Value);

              if(!String.IsNullOrEmpty(name))
                  command.Parameters.AddWithValue("@name", name);
              else
                  command.Parameters.AddWithValue("@name", System.DBNull.Value);

              if(!String.IsNullOrEmpty(image))
                  command.Parameters.AddWithValue("@image", image);
              else
                  command.Parameters.AddWithValue("@image", System.DBNull.Value);

              if(accessRightsGroup != null)
                  command.Parameters.AddWithValue("@accessRightsGroup", accessRightsGroup);
              else
                  command.Parameters.AddWithValue("@accessRightsGroup", System.DBNull.Value);

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
         /// Creates a SystemUser object from the passed data row
         /// </summary>
         private static UserModel CreateSystemUserFromDataRowShared(DataRow dr)
         {
             UserModel objSystemUser = new UserModel();

             objSystemUser.Id = (int)dr["Id"];

             if (dr["UserName"] != System.DBNull.Value)
                 objSystemUser.UserName = dr["UserName"].ToString();
             else
                 objSystemUser.UserName = null;

             if (dr["Pass"] != System.DBNull.Value)
                 objSystemUser.Pass = dr["Pass"].ToString();
             else
                 objSystemUser.Pass = null;

             if (dr["Name"] != System.DBNull.Value)
                 objSystemUser.Name = dr["Name"].ToString();
             else
                 objSystemUser.Name = null;

             if (dr["Image"] != System.DBNull.Value)
                 objSystemUser.Image = dr["Image"].ToString();
             else
                 objSystemUser.Image = null;

             if (dr["AccessRightsGroup"] != System.DBNull.Value)
                 objSystemUser.AccessRightsGroup = (int)dr["AccessRightsGroup"];
             else
                 objSystemUser.AccessRightsGroup = null;

             if (dr["CreatedDate"] != System.DBNull.Value)
                 objSystemUser.CreatedDate = (DateTime)dr["CreatedDate"];
             else
                 objSystemUser.CreatedDate = null;

             if (dr["ModifiedDate"] != System.DBNull.Value)
                 objSystemUser.ModifiedDate = (DateTime)dr["ModifiedDate"];
             else
                 objSystemUser.ModifiedDate = null;

             if (dr["CreatedUserId"] != System.DBNull.Value)
                 objSystemUser.CreatedUserId = (int)dr["CreatedUserId"];
             else
                 objSystemUser.CreatedUserId = null;

             if (dr["ModifiedUserId"] != System.DBNull.Value)
                 objSystemUser.ModifiedUserId = (int)dr["ModifiedUserId"];
             else
                 objSystemUser.ModifiedUserId = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objSystemUser.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objSystemUser.IsDeleted = false;

             if (dr["Status"] != System.DBNull.Value)
                 objSystemUser.Status = (int)dr["Status"];
             else
                 objSystemUser.Status = null;

             return objSystemUser;
         }
     }
}
