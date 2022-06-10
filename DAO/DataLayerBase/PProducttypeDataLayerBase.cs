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
     /// Base class for PProducttypeDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the PProducttypeDataLayer class
     /// </summary>
     public class PProducttypeDataLayerBase
     {
         // constructor
         public PProducttypeDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PProducttypeModel SelectByPrimaryKey(int id)
         {
              PProducttypeModel objPProducttype = null;
              string storedProcName = "[dbo].[PProducttype_SelectByPrimaryKey]";

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
                                objPProducttype = CreatePProducttypeFromDataRowShared(dt.Rows[0]);
                            }
                        }
                    }
                }
            }

              return objPProducttype;
         }

         /// <summary>
         /// Gets the total number of records in the PProducttype table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[PProducttype_GetRecordCount]", null, null, true, null);
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
         /// Gets the total number of records in the PProducttype table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[PProducttype_GetRecordCountWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted);

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
         /// Selects PProducttype records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<PProducttypeModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[PProducttype_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects PProducttype records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<PProducttypeModel> SelectSkipAndTakeDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, string sortByExpression, int startRowIndex, int rows)
         {
            List<PProducttypeModel> objPProducttypeCol = null;
              string storedProcName = "[dbo].[PProducttype_SelectSkipAndTakeWhereDynamic]";

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
                      AddSearchCommandParamsShared(command, id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPProducttypeCol = new List<PProducttypeModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PProducttypeModel objPProducttype = CreatePProducttypeFromDataRowShared(dr);
                                      objPProducttypeCol.Add(objPProducttype);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPProducttypeCol;
         }

         /// <summary>
         /// Selects all PProducttype
         /// </summary>
         public static List<PProducttypeModel> SelectAll()
         {
             return SelectShared("[dbo].[PProducttype_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PProducttype.
         /// </summary>
         public static List<PProducttypeModel> SelectAllDynamicWhere(int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted)
         {
            List<PProducttypeModel> objPProducttypeCol = null;
              string storedProcName = "[dbo].[PProducttype_SelectAllWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, name, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPProducttypeCol = new List<PProducttypeModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PProducttypeModel objPProducttype = CreatePProducttypeFromDataRowShared(dr);
                                      objPProducttypeCol.Add(objPProducttype);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPProducttypeCol;
         }

         /// <summary>
         /// Selects Id and Name columns for use with a DropDownList web control
         /// </summary>
         public static List<PProducttypeModel> SelectPProducttypeDropDownListData()
         {
            List<PProducttypeModel> objPProducttypeCol = null;
              string storedProcName = "[dbo].[PProducttype_SelectDropDownListData]";

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
                                  objPProducttypeCol = new List<PProducttypeModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PProducttypeModel objPProducttype = new PProducttypeModel();
                                      objPProducttype.Id = (int)dr["Id"];

                                      if (dr["Name"] != System.DBNull.Value)
                                          objPProducttype.Name = (string)(dr["Name"]);
                                      else
                                          objPProducttype.Name = null;

                                      objPProducttypeCol.Add(objPProducttype);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPProducttypeCol;
         }

         public static List<PProducttypeModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<PProducttypeModel> objPProducttypeCol = null;

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
                                  objPProducttypeCol = new List<PProducttypeModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PProducttypeModel objPProducttype = CreatePProducttypeFromDataRowShared(dr);
                                      objPProducttypeCol.Add(objPProducttype);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPProducttypeCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(PProducttypeModel objPProducttype)
         {
             string storedProcName = "[dbo].[PProducttype_Insert]";
             return InsertUpdate(objPProducttype, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(PProducttypeModel objPProducttype)
         {
             string storedProcName = "[dbo].[PProducttype_Update]";
             InsertUpdate(objPProducttype, true, storedProcName);
         }

         private static int InsertUpdate(PProducttypeModel objPProducttype, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objPProducttype.Id;

              object name = objPProducttype.Name;
              object createdDate = objPProducttype.CreatedDate;
              object modifiedDate = objPProducttype.ModifiedDate;
              object createdUserId = objPProducttype.CreatedUserId;
              object modifiedUserId = objPProducttype.ModifiedUserId;

              if (String.IsNullOrEmpty(objPProducttype.Name))
                  name = System.DBNull.Value;

              if (objPProducttype.CreatedDate == null)
                  createdDate = System.DBNull.Value;

              if (objPProducttype.ModifiedDate == null)
                  modifiedDate = System.DBNull.Value;

              if (objPProducttype.CreatedUserId == null)
                  createdUserId = System.DBNull.Value;

              if (objPProducttype.ModifiedUserId == null)
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
                          command.Parameters.AddWithValue("@id", objPProducttype.Id);
                      }

                      command.Parameters.AddWithValue("@name", name);
                      command.Parameters.AddWithValue("@createdDate", createdDate);
                      command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                      command.Parameters.AddWithValue("@createdUserId", createdUserId);
                      command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                      command.Parameters.AddWithValue("@isDeleted", objPProducttype.IsDeleted);

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
              string storedProcName = "[dbo].[PProducttype_Delete]";

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, string name, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted)
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

         }

         /// <summary>
         /// Creates a PProducttype object from the passed data row
         /// </summary>
         private static PProducttypeModel CreatePProducttypeFromDataRowShared(DataRow dr)
         {
             PProducttypeModel objPProducttype = new PProducttypeModel();

             objPProducttype.Id = (int)dr["Id"];

             if (dr["Name"] != System.DBNull.Value)
                 objPProducttype.Name = dr["Name"].ToString();
             else
                 objPProducttype.Name = null;

             if (dr["CreatedDate"] != System.DBNull.Value)
                 objPProducttype.CreatedDate = (DateTime)dr["CreatedDate"];
             else
                 objPProducttype.CreatedDate = null;

             if (dr["ModifiedDate"] != System.DBNull.Value)
                 objPProducttype.ModifiedDate = (DateTime)dr["ModifiedDate"];
             else
                 objPProducttype.ModifiedDate = null;

             if (dr["CreatedUserId"] != System.DBNull.Value)
                 objPProducttype.CreatedUserId = (int)dr["CreatedUserId"];
             else
                 objPProducttype.CreatedUserId = null;

             if (dr["ModifiedUserId"] != System.DBNull.Value)
                 objPProducttype.ModifiedUserId = (int)dr["ModifiedUserId"];
             else
                 objPProducttype.ModifiedUserId = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objPProducttype.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objPProducttype.IsDeleted = false;

             return objPProducttype;
         }
     }
}
