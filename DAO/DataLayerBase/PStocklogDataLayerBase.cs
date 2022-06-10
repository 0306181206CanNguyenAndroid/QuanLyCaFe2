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
     /// Base class for PStocklogDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the PStocklogDataLayer class
     /// </summary>
     public class PStocklogDataLayerBase
     {
         // constructor
         public PStocklogDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PStocklogModel SelectByPrimaryKey(int id)
         {
              PStocklogModel objPStocklog = null;
              string storedProcName = "[dbo].[PStocklog_SelectByPrimaryKey]";

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
                                  objPStocklog = CreatePStocklogFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objPStocklog;
         }

         /// <summary>
         /// Gets the total number of records in the PStocklog table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[PStocklog_GetRecordCount]", null, null, true, null);
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
         /// Gets the total number of records in the PStocklog table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string note, int? stockId, int? action, int? quantityOld, int? quantityAdd, DateTime? createdDate, int? createdUserId, bool? isDeleted)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[PStocklog_GetRecordCountWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, note, stockId, action, quantityOld, quantityAdd, createdDate, createdUserId, isDeleted);

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
         /// Selects PStocklog records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<PStocklogModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[PStocklog_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects PStocklog records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<PStocklogModel> SelectSkipAndTakeDynamicWhere(int? id, string note, int? stockId, int? action, int? quantityOld, int? quantityAdd, DateTime? createdDate, int? createdUserId, bool? isDeleted, string sortByExpression, int startRowIndex, int rows)
         {
            List<PStocklogModel> objPStocklogCol = null;
              string storedProcName = "[dbo].[PStocklog_SelectSkipAndTakeWhereDynamic]";

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
                      AddSearchCommandParamsShared(command, id, note, stockId, action, quantityOld, quantityAdd, createdDate, createdUserId, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPStocklogCol = new List<PStocklogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PStocklogModel objPStocklog = CreatePStocklogFromDataRowShared(dr);
                                      objPStocklogCol.Add(objPStocklog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPStocklogCol;
         }

         /// <summary>
         /// Selects all PStocklog
         /// </summary>
         public static List<PStocklogModel> SelectAll()
         {
             return SelectShared("[dbo].[PStocklog_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PStocklog.
         /// </summary>
         public static List<PStocklogModel> SelectAllDynamicWhere(int? id, string note, int? stockId, int? action, int? quantityOld, int? quantityAdd, DateTime? createdDate, int? createdUserId, bool? isDeleted)
         {
            List<PStocklogModel> objPStocklogCol = null;
              string storedProcName = "[dbo].[PStocklog_SelectAllWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, note, stockId, action, quantityOld, quantityAdd, createdDate, createdUserId, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPStocklogCol = new List<PStocklogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PStocklogModel objPStocklog = CreatePStocklogFromDataRowShared(dr);
                                      objPStocklogCol.Add(objPStocklog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPStocklogCol;
         }

         /// <summary>
         /// Selects Id and Note columns for use with a DropDownList web control
         /// </summary>
         public static List<PStocklogModel> SelectPStocklogDropDownListData()
         {
            List<PStocklogModel> objPStocklogCol = null;
              string storedProcName = "[dbo].[PStocklog_SelectDropDownListData]";

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
                                  objPStocklogCol = new List<PStocklogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PStocklogModel objPStocklog = new PStocklogModel();
                                      objPStocklog.Id = (int)dr["Id"];

                                      if (dr["Note"] != System.DBNull.Value)
                                          objPStocklog.Note = (string)(dr["Note"]);
                                      else
                                          objPStocklog.Note = null;

                                      objPStocklogCol.Add(objPStocklog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPStocklogCol;
         }

         public static List<PStocklogModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<PStocklogModel> objPStocklogCol = null;

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
                                  objPStocklogCol = new List<PStocklogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PStocklogModel objPStocklog = CreatePStocklogFromDataRowShared(dr);
                                      objPStocklogCol.Add(objPStocklog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPStocklogCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(PStocklogModel objPStocklog)
         {
             string storedProcName = "[dbo].[PStocklog_Insert]";
             return InsertUpdate(objPStocklog, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(PStocklogModel objPStocklog)
         {
             string storedProcName = "[dbo].[PStocklog_Update]";
             InsertUpdate(objPStocklog, true, storedProcName);
         }

         private static int InsertUpdate(PStocklogModel objPStocklog, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objPStocklog.Id;

              object note = objPStocklog.Note;
              object stockId = objPStocklog.StockId;
              object action = objPStocklog.Action;
              object quantityOld = objPStocklog.QuantityOld;
              object quantityAdd = objPStocklog.QuantityAdd;
              object createdDate = objPStocklog.CreatedDate;
              object createdUserId = objPStocklog.CreatedUserId;

              if (String.IsNullOrEmpty(objPStocklog.Note))
                  note = System.DBNull.Value;

              if (objPStocklog.StockId == null)
                  stockId = System.DBNull.Value;

              if (objPStocklog.Action == null)
                  action = System.DBNull.Value;

              if (objPStocklog.QuantityOld == null)
                  quantityOld = System.DBNull.Value;

              if (objPStocklog.QuantityAdd == null)
                  quantityAdd = System.DBNull.Value;

              if (objPStocklog.CreatedDate == null)
                  createdDate = System.DBNull.Value;

              if (objPStocklog.CreatedUserId == null)
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
                          command.Parameters.AddWithValue("@id", objPStocklog.Id);
                      }

                      command.Parameters.AddWithValue("@note", note);
                      command.Parameters.AddWithValue("@stockId", stockId);
                      command.Parameters.AddWithValue("@action", action);
                      command.Parameters.AddWithValue("@quantityOld", quantityOld);
                      command.Parameters.AddWithValue("@quantityAdd", quantityAdd);
                      command.Parameters.AddWithValue("@createdDate", createdDate);
                      command.Parameters.AddWithValue("@createdUserId", createdUserId);
                      command.Parameters.AddWithValue("@isDeleted", objPStocklog.IsDeleted);

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
              string storedProcName = "[dbo].[PStocklog_Delete]";

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, string note, int? stockId, int? action, int? quantityOld, int? quantityAdd, DateTime? createdDate, int? createdUserId, bool? isDeleted)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(!String.IsNullOrEmpty(note))
                  command.Parameters.AddWithValue("@note", note);
              else
                  command.Parameters.AddWithValue("@note", System.DBNull.Value);

              if(stockId != null)
                  command.Parameters.AddWithValue("@stockId", stockId);
              else
                  command.Parameters.AddWithValue("@stockId", System.DBNull.Value);

              if(action != null)
                  command.Parameters.AddWithValue("@action", action);
              else
                  command.Parameters.AddWithValue("@action", System.DBNull.Value);

              if(quantityOld != null)
                  command.Parameters.AddWithValue("@quantityOld", quantityOld);
              else
                  command.Parameters.AddWithValue("@quantityOld", System.DBNull.Value);

              if(quantityAdd != null)
                  command.Parameters.AddWithValue("@quantityAdd", quantityAdd);
              else
                  command.Parameters.AddWithValue("@quantityAdd", System.DBNull.Value);

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
         /// Creates a PStocklog object from the passed data row
         /// </summary>
         private static PStocklogModel CreatePStocklogFromDataRowShared(DataRow dr)
         {
             PStocklogModel objPStocklog = new PStocklogModel();

             objPStocklog.Id = (int)dr["Id"];

             if (dr["Note"] != System.DBNull.Value)
                 objPStocklog.Note = dr["Note"].ToString();
             else
                 objPStocklog.Note = null;

             if (dr["StockId"] != System.DBNull.Value)
                 objPStocklog.StockId = (int)dr["StockId"];
             else
                 objPStocklog.StockId = null;

             if (dr["Action"] != System.DBNull.Value)
                 objPStocklog.Action = (int)dr["Action"];
             else
                 objPStocklog.Action = null;

             if (dr["QuantityOld"] != System.DBNull.Value)
                 objPStocklog.QuantityOld = (int)dr["QuantityOld"];
             else
                 objPStocklog.QuantityOld = null;

             if (dr["QuantityAdd"] != System.DBNull.Value)
                 objPStocklog.QuantityAdd = (int)dr["QuantityAdd"];
             else
                 objPStocklog.QuantityAdd = null;

             if (dr["CreatedDate"] != System.DBNull.Value)
                 objPStocklog.CreatedDate = (DateTime)dr["CreatedDate"];
             else
                 objPStocklog.CreatedDate = null;

             if (dr["CreatedUserId"] != System.DBNull.Value)
                 objPStocklog.CreatedUserId = (int)dr["CreatedUserId"];
             else
                 objPStocklog.CreatedUserId = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objPStocklog.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objPStocklog.IsDeleted = false;

             return objPStocklog;
         }
     }
}
