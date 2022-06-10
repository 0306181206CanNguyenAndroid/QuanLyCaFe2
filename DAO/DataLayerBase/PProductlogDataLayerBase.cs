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
     /// Base class for PProductlogDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the PProductlogDataLayer class
     /// </summary>
     public class PProductlogDataLayerBase
     {
         // constructor
         public PProductlogDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PProductlogModel SelectByPrimaryKey(int id)
         {
              PProductlogModel objPProductlog = null;
              string storedProcName = "[dbo].[PProductlog_SelectByPrimaryKey]";

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
                                  objPProductlog = CreatePProductlogFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objPProductlog;
         }

         /// <summary>
         /// Gets the total number of records in the PProductlog table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[PProductlog_GetRecordCount]", null, null, true, null);
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
         /// Gets the total number of records in the PProductlog table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string note, int? productId, int? action, DateTime? createdDate, int? createdUserId, bool? isDeleted)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[PProductlog_GetRecordCountWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, note, productId, action, createdDate, createdUserId, isDeleted);

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
         /// Selects PProductlog records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<PProductlogModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[PProductlog_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects PProductlog records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<PProductlogModel> SelectSkipAndTakeDynamicWhere(int? id, string note, int? productId, int? action, DateTime? createdDate, int? createdUserId, bool? isDeleted, string sortByExpression, int startRowIndex, int rows)
         {
            List<PProductlogModel> objPProductlogCol = null;
              string storedProcName = "[dbo].[PProductlog_SelectSkipAndTakeWhereDynamic]";

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
                      AddSearchCommandParamsShared(command, id, note, productId, action, createdDate, createdUserId, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPProductlogCol = new List<PProductlogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PProductlogModel objPProductlog = CreatePProductlogFromDataRowShared(dr);
                                      objPProductlogCol.Add(objPProductlog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPProductlogCol;
         }

         /// <summary>
         /// Selects all PProductlog
         /// </summary>
         public static List<PProductlogModel> SelectAll()
         {
             return SelectShared("[dbo].[PProductlog_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PProductlog.
         /// </summary>
         public static List<PProductlogModel> SelectAllDynamicWhere(int? id, string note, int? productId, int? action, DateTime? createdDate, int? createdUserId, bool? isDeleted)
         {
            List<PProductlogModel> objPProductlogCol = null;
              string storedProcName = "[dbo].[PProductlog_SelectAllWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, note, productId, action, createdDate, createdUserId, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPProductlogCol = new List<PProductlogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PProductlogModel objPProductlog = CreatePProductlogFromDataRowShared(dr);
                                      objPProductlogCol.Add(objPProductlog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPProductlogCol;
         }

         /// <summary>
         /// Selects Id and Note columns for use with a DropDownList web control
         /// </summary>
         public static List<PProductlogModel> SelectPProductlogDropDownListData()
         {
            List<PProductlogModel> objPProductlogCol = null;
              string storedProcName = "[dbo].[PProductlog_SelectDropDownListData]";

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
                                  objPProductlogCol = new List<PProductlogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PProductlogModel objPProductlog = new PProductlogModel();
                                      objPProductlog.Id = (int)dr["Id"];

                                      if (dr["Note"] != System.DBNull.Value)
                                          objPProductlog.Note = (string)(dr["Note"]);
                                      else
                                          objPProductlog.Note = null;

                                      objPProductlogCol.Add(objPProductlog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPProductlogCol;
         }

         public static List<PProductlogModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<PProductlogModel> objPProductlogCol = null;

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
                                  objPProductlogCol = new List<PProductlogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PProductlogModel objPProductlog = CreatePProductlogFromDataRowShared(dr);
                                      objPProductlogCol.Add(objPProductlog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPProductlogCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(PProductlogModel objPProductlog)
         {
             string storedProcName = "[dbo].[PProductlog_Insert]";
             return InsertUpdate(objPProductlog, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(PProductlogModel objPProductlog)
         {
             string storedProcName = "[dbo].[PProductlog_Update]";
             InsertUpdate(objPProductlog, true, storedProcName);
         }

         private static int InsertUpdate(PProductlogModel objPProductlog, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objPProductlog.Id;

              object note = objPProductlog.Note;
              object productId = objPProductlog.ProductId;
              object action = objPProductlog.Action;
              object createdDate = objPProductlog.CreatedDate;
              object createdUserId = objPProductlog.CreatedUserId;

              if (String.IsNullOrEmpty(objPProductlog.Note))
                  note = System.DBNull.Value;

              if (objPProductlog.ProductId == null)
                  productId = System.DBNull.Value;

              if (objPProductlog.Action == null)
                  action = System.DBNull.Value;

              if (objPProductlog.CreatedDate == null)
                  createdDate = System.DBNull.Value;

              if (objPProductlog.CreatedUserId == null)
                  createdUserId = System.DBNull.Value;

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
                          command.Parameters.AddWithValue("@id", objPProductlog.Id);
                      }

                      command.Parameters.AddWithValue("@note", note);
                      command.Parameters.AddWithValue("@productId", productId);
                      command.Parameters.AddWithValue("@action", action);
                      command.Parameters.AddWithValue("@createdDate", createdDate);
                      command.Parameters.AddWithValue("@createdUserId", createdUserId);
                      command.Parameters.AddWithValue("@isDeleted", objPProductlog.IsDeleted);

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
              string storedProcName = "[dbo].[PProductlog_Delete]";

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, string note, int? productId, int? action, DateTime? createdDate, int? createdUserId, bool? isDeleted)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(!String.IsNullOrEmpty(note))
                  command.Parameters.AddWithValue("@note", note);
              else
                  command.Parameters.AddWithValue("@note", System.DBNull.Value);

              if(productId != null)
                  command.Parameters.AddWithValue("@productId", productId);
              else
                  command.Parameters.AddWithValue("@productId", System.DBNull.Value);

              if(action != null)
                  command.Parameters.AddWithValue("@action", action);
              else
                  command.Parameters.AddWithValue("@action", System.DBNull.Value);

              if(createdDate != null)
                  command.Parameters.AddWithValue("@createdDate", createdDate);
              else
                  command.Parameters.AddWithValue("@createdDate", System.DBNull.Value);

              if(createdUserId != null)
                  command.Parameters.AddWithValue("@createdUserId", createdUserId);
              else
                  command.Parameters.AddWithValue("@createdUserId", System.DBNull.Value);

              if(isDeleted != null)
                  command.Parameters.AddWithValue("@isDeleted", isDeleted);
              else
                  command.Parameters.AddWithValue("@isDeleted", System.DBNull.Value);

         }

         /// <summary>
         /// Creates a PProductlog object from the passed data row
         /// </summary>
         private static PProductlogModel CreatePProductlogFromDataRowShared(DataRow dr)
         {
             PProductlogModel objPProductlog = new PProductlogModel();

             objPProductlog.Id = (int)dr["Id"];

             if (dr["Note"] != System.DBNull.Value)
                 objPProductlog.Note = dr["Note"].ToString();
             else
                 objPProductlog.Note = null;

             if (dr["ProductId"] != System.DBNull.Value)
                 objPProductlog.ProductId = (int)dr["ProductId"];
             else
                 objPProductlog.ProductId = null;

             if (dr["Action"] != System.DBNull.Value)
                 objPProductlog.Action = (int)dr["Action"];
             else
                 objPProductlog.Action = null;

             if (dr["CreatedDate"] != System.DBNull.Value)
                 objPProductlog.CreatedDate = (DateTime)dr["CreatedDate"];
             else
                 objPProductlog.CreatedDate = null;

             if (dr["CreatedUserId"] != System.DBNull.Value)
                 objPProductlog.CreatedUserId = (int)dr["CreatedUserId"];
             else
                 objPProductlog.CreatedUserId = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objPProductlog.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objPProductlog.IsDeleted = false;

             return objPProductlog;
         }
     }
}
