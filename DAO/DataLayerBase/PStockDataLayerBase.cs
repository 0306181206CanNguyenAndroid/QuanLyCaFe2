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
     /// Base class for PStockDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the PStockDataLayer class
     /// </summary>
     public class PStockDataLayerBase
     {
         // constructor
         public PStockDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PStockModel SelectByPrimaryKey(int id)
         {
              PStockModel objPStock = null;
              string storedProcName = "[dbo].[PStock_SelectByPrimaryKey]";

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
                                  objPStock = CreatePStockFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objPStock;
         }

         /// <summary>
         /// Gets the total number of records in the PStock table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[PStock_GetRecordCount]", null, null, true, null);
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
         /// Gets the total number of records in the PStock table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, int? productInfo, int? quantity, int? batchOfGoodsId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[PStock_GetRecordCountWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, productInfo, quantity, batchOfGoodsId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

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
         /// Selects PStock records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<PStockModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[PStock_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects PStock records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<PStockModel> SelectSkipAndTakeDynamicWhere(int? id, int? productInfo, int? quantity, int? batchOfGoodsId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string sortByExpression, int startRowIndex, int rows)
         {
            List<PStockModel> objPStockCol = null;
              string storedProcName = "[dbo].[PStock_SelectSkipAndTakeWhereDynamic]";

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
                      AddSearchCommandParamsShared(command, id, productInfo, quantity, batchOfGoodsId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPStockCol = new List<PStockModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PStockModel objPStock = CreatePStockFromDataRowShared(dr);
                                      objPStockCol.Add(objPStock);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPStockCol;
         }

         /// <summary>
         /// Selects all PStock
         /// </summary>
         public static List<PStockModel> SelectAll()
         {
             return SelectShared("[dbo].[PStock_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PStock.
         /// </summary>
         public static List<PStockModel> SelectAllDynamicWhere(int? id, int? productInfo, int? quantity, int? batchOfGoodsId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
            List<PStockModel> objPStockCol = null;
              string storedProcName = "[dbo].[PStock_SelectAllWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, productInfo, quantity, batchOfGoodsId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPStockCol = new List<PStockModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PStockModel objPStock = CreatePStockFromDataRowShared(dr);
                                      objPStockCol.Add(objPStock);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPStockCol;
         }

         /// <summary>
         /// Selects Id and ProductInfo columns for use with a DropDownList web control
         /// </summary>
         public static List<PStockModel> SelectPStockDropDownListData()
         {
            List<PStockModel> objPStockCol = null;
              string storedProcName = "[dbo].[PStock_SelectDropDownListData]";

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
                                  objPStockCol = new List<PStockModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PStockModel objPStock = new PStockModel();
                                      objPStock.Id = (int)dr["Id"];

                                      if (dr["ProductInfo"] != System.DBNull.Value)
                                          objPStock.ProductInfo = (int)(dr["ProductInfo"]);
                                      else
                                          objPStock.ProductInfo = null;

                                      objPStockCol.Add(objPStock);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPStockCol;
         }

         public static List<PStockModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<PStockModel> objPStockCol = null;

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
                                  objPStockCol = new List<PStockModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PStockModel objPStock = CreatePStockFromDataRowShared(dr);
                                      objPStockCol.Add(objPStock);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPStockCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(PStockModel objPStock)
         {
             string storedProcName = "[dbo].[PStock_Insert]";
             return InsertUpdate(objPStock, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(PStockModel objPStock)
         {
             string storedProcName = "[dbo].[PStock_Update]";
             InsertUpdate(objPStock, true, storedProcName);
         }

         private static int InsertUpdate(PStockModel objPStock, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objPStock.Id;

              object productInfo = objPStock.ProductInfo;
              object quantity = objPStock.Quantity;
              object batchOfGoodsId = objPStock.BatchOfGoodsId;
              object createdDate = objPStock.CreatedDate;
              object modifiedDate = objPStock.ModifiedDate;
              object createdUserId = objPStock.CreatedUserId;
              object modifiedUserId = objPStock.ModifiedUserId;
              object status = objPStock.Status;

              if (objPStock.ProductInfo == null)
                  productInfo = System.DBNull.Value;

              if (objPStock.Quantity == null)
                  quantity = System.DBNull.Value;

              if (objPStock.BatchOfGoodsId == null)
                  batchOfGoodsId = System.DBNull.Value;

              if (objPStock.CreatedDate == null)
                  createdDate = System.DBNull.Value;

              if (objPStock.ModifiedDate == null)
                  modifiedDate = System.DBNull.Value;

              if (objPStock.CreatedUserId == null)
                  createdUserId = System.DBNull.Value;

              if (objPStock.ModifiedUserId == null)
                  modifiedUserId = System.DBNull.Value;

              if (objPStock.Status == null)
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
                          command.Parameters.AddWithValue("@id", objPStock.Id);
                      }

                      command.Parameters.AddWithValue("@productInfo", productInfo);
                      command.Parameters.AddWithValue("@quantity", quantity);
                      command.Parameters.AddWithValue("@batchOfGoodsId", batchOfGoodsId);
                      command.Parameters.AddWithValue("@createdDate", createdDate);
                      command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                      command.Parameters.AddWithValue("@createdUserId", createdUserId);
                      command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                      command.Parameters.AddWithValue("@isDeleted", objPStock.IsDeleted);
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
              string storedProcName = "[dbo].[PStock_Delete]";

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, int? productInfo, int? quantity, int? batchOfGoodsId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(productInfo != null)
                  command.Parameters.AddWithValue("@productInfo", productInfo);
              else
                  command.Parameters.AddWithValue("@productInfo", System.DBNull.Value);

              if(quantity != null)
                  command.Parameters.AddWithValue("@quantity", quantity);
              else
                  command.Parameters.AddWithValue("@quantity", System.DBNull.Value);

              if(batchOfGoodsId != null)
                  command.Parameters.AddWithValue("@batchOfGoodsId", batchOfGoodsId);
              else
                  command.Parameters.AddWithValue("@batchOfGoodsId", System.DBNull.Value);

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
         /// Creates a PStock object from the passed data row
         /// </summary>
         private static PStockModel CreatePStockFromDataRowShared(DataRow dr)
         {
             PStockModel objPStock = new PStockModel();

             objPStock.Id = (int)dr["Id"];

             if (dr["ProductInfo"] != System.DBNull.Value)
                 objPStock.ProductInfo = (int)dr["ProductInfo"];
             else
                 objPStock.ProductInfo = null;

             if (dr["Quantity"] != System.DBNull.Value)
                 objPStock.Quantity = (int)dr["Quantity"];
             else
                 objPStock.Quantity = null;

             if (dr["BatchOfGoodsId"] != System.DBNull.Value)
                 objPStock.BatchOfGoodsId = (int)dr["BatchOfGoodsId"];
             else
                 objPStock.BatchOfGoodsId = null;

             if (dr["CreatedDate"] != System.DBNull.Value)
                 objPStock.CreatedDate = (DateTime)dr["CreatedDate"];
             else
                 objPStock.CreatedDate = null;

             if (dr["ModifiedDate"] != System.DBNull.Value)
                 objPStock.ModifiedDate = (DateTime)dr["ModifiedDate"];
             else
                 objPStock.ModifiedDate = null;

             if (dr["CreatedUserId"] != System.DBNull.Value)
                 objPStock.CreatedUserId = (int)dr["CreatedUserId"];
             else
                 objPStock.CreatedUserId = null;

             if (dr["ModifiedUserId"] != System.DBNull.Value)
                 objPStock.ModifiedUserId = (int)dr["ModifiedUserId"];
             else
                 objPStock.ModifiedUserId = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objPStock.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objPStock.IsDeleted = false;

             if (dr["Status"] != System.DBNull.Value)
                 objPStock.Status = (int)dr["Status"];
             else
                 objPStock.Status = null;

             return objPStock;
         }
     }
}
