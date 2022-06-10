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
     /// Base class for PImportgoodsdetailDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the PImportgoodsdetailDataLayer class
     /// </summary>
     public class PImportgoodsdetailDataLayerBase
     {
         // constructor
         public PImportgoodsdetailDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PImportgoodsdetailModel SelectByPrimaryKey(int id)
         {
              PImportgoodsdetailModel objPImportgoodsdetail = null;
              string storedProcName = "[dbo].[PImportgoodsdetail_SelectByPrimaryKey]";

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
                                  objPImportgoodsdetail = CreatePImportgoodsdetailFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objPImportgoodsdetail;
         }

         /// <summary>
         /// Gets the total number of records in the PImportgoodsdetail table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[PImportgoodsdetail_GetRecordCount]", null, null, true, null);
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
         /// Gets the total number of records in the PImportgoodsdetail table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, int? importGoodsId, int? productInfo, DateTime? manuDate, DateTime? expiryDate, string productNumber, string productCode, int? productTypeId, int? importQuantity, bool? isDeleted, int? status)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[PImportgoodsdetail_GetRecordCountWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, importGoodsId, productInfo, manuDate, expiryDate, productNumber, productCode, productTypeId, importQuantity, isDeleted, status);

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
         /// Selects PImportgoodsdetail records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<PImportgoodsdetailModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[PImportgoodsdetail_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects PImportgoodsdetail records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<PImportgoodsdetailModel> SelectSkipAndTakeDynamicWhere(int? id, int? importGoodsId, int? productInfo, DateTime? manuDate, DateTime? expiryDate, string productNumber, string productCode, int? productTypeId, int? importQuantity, bool? isDeleted, int? status, string sortByExpression, int startRowIndex, int rows)
         {
            List<PImportgoodsdetailModel> objPImportgoodsdetailCol = null;
              string storedProcName = "[dbo].[PImportgoodsdetail_SelectSkipAndTakeWhereDynamic]";

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
                      AddSearchCommandParamsShared(command, id, importGoodsId, productInfo, manuDate, expiryDate, productNumber, productCode, productTypeId, importQuantity, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPImportgoodsdetailCol = new List<PImportgoodsdetailModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PImportgoodsdetailModel objPImportgoodsdetail = CreatePImportgoodsdetailFromDataRowShared(dr);
                                      objPImportgoodsdetailCol.Add(objPImportgoodsdetail);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPImportgoodsdetailCol;
         }

         /// <summary>
         /// Selects all PImportgoodsdetail
         /// </summary>
         public static List<PImportgoodsdetailModel> SelectAll()
         {
             return SelectShared("[dbo].[PImportgoodsdetail_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PImportgoodsdetail.
         /// </summary>
         public static List<PImportgoodsdetailModel> SelectAllDynamicWhere(int? id, int? importGoodsId, int? productInfo, DateTime? manuDate, DateTime? expiryDate, string productNumber, string productCode, int? productTypeId, int? importQuantity, bool? isDeleted, int? status)
         {
            List<PImportgoodsdetailModel> objPImportgoodsdetailCol = null;
              string storedProcName = "[dbo].[PImportgoodsdetail_SelectAllWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, importGoodsId, productInfo, manuDate, expiryDate, productNumber, productCode, productTypeId, importQuantity, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPImportgoodsdetailCol = new List<PImportgoodsdetailModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PImportgoodsdetailModel objPImportgoodsdetail = CreatePImportgoodsdetailFromDataRowShared(dr);
                                      objPImportgoodsdetailCol.Add(objPImportgoodsdetail);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPImportgoodsdetailCol;
         }

         /// <summary>
         /// Selects Id and ProductNumber columns for use with a DropDownList web control
         /// </summary>
         public static List<PImportgoodsdetailModel> SelectPImportgoodsdetailDropDownListData()
         {
            List<PImportgoodsdetailModel> objPImportgoodsdetailCol = null;
              string storedProcName = "[dbo].[PImportgoodsdetail_SelectDropDownListData]";

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
                                  objPImportgoodsdetailCol = new List<PImportgoodsdetailModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PImportgoodsdetailModel objPImportgoodsdetail = new PImportgoodsdetailModel();
                                      objPImportgoodsdetail.Id = (int)dr["Id"];

                                      if (dr["ProductNumber"] != System.DBNull.Value)
                                          objPImportgoodsdetail.ProductNumber = (string)(dr["ProductNumber"]);
                                      else
                                          objPImportgoodsdetail.ProductNumber = null;

                                      objPImportgoodsdetailCol.Add(objPImportgoodsdetail);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPImportgoodsdetailCol;
         }

         public static List<PImportgoodsdetailModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<PImportgoodsdetailModel> objPImportgoodsdetailCol = null;

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
                                  objPImportgoodsdetailCol = new List<PImportgoodsdetailModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PImportgoodsdetailModel objPImportgoodsdetail = CreatePImportgoodsdetailFromDataRowShared(dr);
                                      objPImportgoodsdetailCol.Add(objPImportgoodsdetail);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPImportgoodsdetailCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(PImportgoodsdetailModel objPImportgoodsdetail)
         {
             string storedProcName = "[dbo].[PImportgoodsdetail_Insert]";
             return InsertUpdate(objPImportgoodsdetail, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(PImportgoodsdetailModel objPImportgoodsdetail)
         {
             string storedProcName = "[dbo].[PImportgoodsdetail_Update]";
             InsertUpdate(objPImportgoodsdetail, true, storedProcName);
         }

         private static int InsertUpdate(PImportgoodsdetailModel objPImportgoodsdetail, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objPImportgoodsdetail.Id;

              object importGoodsId = objPImportgoodsdetail.ImportGoodsId;
              object productInfo = objPImportgoodsdetail.ProductInfo;
              object manuDate = objPImportgoodsdetail.ManuDate;
              object expiryDate = objPImportgoodsdetail.ExpiryDate;
              object productNumber = objPImportgoodsdetail.ProductNumber;
              object productCode = objPImportgoodsdetail.ProductCode;
              object productTypeId = objPImportgoodsdetail.ProductTypeId;
              object importQuantity = objPImportgoodsdetail.ImportQuantity;
              object status = objPImportgoodsdetail.Status;

              if (objPImportgoodsdetail.ImportGoodsId == null)
                  importGoodsId = System.DBNull.Value;

              if (objPImportgoodsdetail.ProductInfo == null)
                  productInfo = System.DBNull.Value;

              if (objPImportgoodsdetail.ManuDate == null)
                  manuDate = System.DBNull.Value;

              if (objPImportgoodsdetail.ExpiryDate == null)
                  expiryDate = System.DBNull.Value;

              if (String.IsNullOrEmpty(objPImportgoodsdetail.ProductNumber))
                  productNumber = System.DBNull.Value;

              if (String.IsNullOrEmpty(objPImportgoodsdetail.ProductCode))
                  productCode = System.DBNull.Value;

              if (objPImportgoodsdetail.ProductTypeId == null)
                  productTypeId = System.DBNull.Value;

              if (objPImportgoodsdetail.ImportQuantity == null)
                  importQuantity = System.DBNull.Value;

              if (objPImportgoodsdetail.Status == null)
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
                          command.Parameters.AddWithValue("@id", objPImportgoodsdetail.Id);
                      }

                      command.Parameters.AddWithValue("@importGoodsId", importGoodsId);
                      command.Parameters.AddWithValue("@productInfo", productInfo);
                      command.Parameters.AddWithValue("@manuDate", manuDate);
                      command.Parameters.AddWithValue("@expiryDate", expiryDate);
                      command.Parameters.AddWithValue("@productNumber", productNumber);
                      command.Parameters.AddWithValue("@productCode", productCode);
                      command.Parameters.AddWithValue("@productTypeId", productTypeId);
                      command.Parameters.AddWithValue("@importQuantity", importQuantity);
                      command.Parameters.AddWithValue("@isDeleted", objPImportgoodsdetail.IsDeleted);
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
              string storedProcName = "[dbo].[PImportgoodsdetail_Delete]";

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, int? importGoodsId, int? productInfo, DateTime? manuDate, DateTime? expiryDate, string productNumber, string productCode, int? productTypeId, int? importQuantity, bool? isDeleted, int? status)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(importGoodsId != null)
                  command.Parameters.AddWithValue("@importGoodsId", importGoodsId);
              else
                  command.Parameters.AddWithValue("@importGoodsId", System.DBNull.Value);

              if(productInfo != null)
                  command.Parameters.AddWithValue("@productInfo", productInfo);
              else
                  command.Parameters.AddWithValue("@productInfo", System.DBNull.Value);

              if(manuDate != null)
                  command.Parameters.AddWithValue("@manuDate", manuDate);
              else
                  command.Parameters.AddWithValue("@manuDate", System.DBNull.Value);

              if(expiryDate != null)
                  command.Parameters.AddWithValue("@expiryDate", expiryDate);
              else
                  command.Parameters.AddWithValue("@expiryDate", System.DBNull.Value);

              if(!String.IsNullOrEmpty(productNumber))
                  command.Parameters.AddWithValue("@productNumber", productNumber);
              else
                  command.Parameters.AddWithValue("@productNumber", System.DBNull.Value);

              if(!String.IsNullOrEmpty(productCode))
                  command.Parameters.AddWithValue("@productCode", productCode);
              else
                  command.Parameters.AddWithValue("@productCode", System.DBNull.Value);

              if(productTypeId != null)
                  command.Parameters.AddWithValue("@productTypeId", productTypeId);
              else
                  command.Parameters.AddWithValue("@productTypeId", System.DBNull.Value);

              if(importQuantity != null)
                  command.Parameters.AddWithValue("@importQuantity", importQuantity);
              else
                  command.Parameters.AddWithValue("@importQuantity", System.DBNull.Value);

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
         /// Creates a PImportgoodsdetail object from the passed data row
         /// </summary>
         private static PImportgoodsdetailModel CreatePImportgoodsdetailFromDataRowShared(DataRow dr)
         {
             PImportgoodsdetailModel objPImportgoodsdetail = new PImportgoodsdetailModel();

             objPImportgoodsdetail.Id = (int)dr["Id"];

             if (dr["ImportGoodsId"] != System.DBNull.Value)
                 objPImportgoodsdetail.ImportGoodsId = (int)dr["ImportGoodsId"];
             else
                 objPImportgoodsdetail.ImportGoodsId = null;

             if (dr["ProductInfo"] != System.DBNull.Value)
                 objPImportgoodsdetail.ProductInfo = (int)dr["ProductInfo"];
             else
                 objPImportgoodsdetail.ProductInfo = null;

             if (dr["ManuDate"] != System.DBNull.Value)
                 objPImportgoodsdetail.ManuDate = (DateTime)dr["ManuDate"];
             else
                 objPImportgoodsdetail.ManuDate = null;

             if (dr["ExpiryDate"] != System.DBNull.Value)
                 objPImportgoodsdetail.ExpiryDate = (DateTime)dr["ExpiryDate"];
             else
                 objPImportgoodsdetail.ExpiryDate = null;

             if (dr["ProductNumber"] != System.DBNull.Value)
                 objPImportgoodsdetail.ProductNumber = dr["ProductNumber"].ToString();
             else
                 objPImportgoodsdetail.ProductNumber = null;

             if (dr["ProductCode"] != System.DBNull.Value)
                 objPImportgoodsdetail.ProductCode = dr["ProductCode"].ToString();
             else
                 objPImportgoodsdetail.ProductCode = null;

             if (dr["ProductTypeId"] != System.DBNull.Value)
                 objPImportgoodsdetail.ProductTypeId = (int)dr["ProductTypeId"];
             else
                 objPImportgoodsdetail.ProductTypeId = null;

             if (dr["ImportQuantity"] != System.DBNull.Value)
                 objPImportgoodsdetail.ImportQuantity = (int)dr["ImportQuantity"];
             else
                 objPImportgoodsdetail.ImportQuantity = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objPImportgoodsdetail.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objPImportgoodsdetail.IsDeleted = false;

             if (dr["Status"] != System.DBNull.Value)
                 objPImportgoodsdetail.Status = (int)dr["Status"];
             else
                 objPImportgoodsdetail.Status = null;

             return objPImportgoodsdetail;
         }
     }
}
