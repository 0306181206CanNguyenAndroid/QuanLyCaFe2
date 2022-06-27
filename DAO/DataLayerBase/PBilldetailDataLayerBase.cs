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
     /// Base class for PBilldetailDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the PBilldetailDataLayer class
     /// </summary>
     public class PBilldetailDataLayerBase
     {
         // constructor
         public PBilldetailDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PBilldetailModel SelectByPrimaryKey(int id)
         {
            PBilldetailModel objPBilldetail = null;
              string storedProcName = ProcString.procNameBill_SelectByPrimaryKey;

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
                                  objPBilldetail = CreatePBilldetailFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objPBilldetail;
         }

         /// <summary>
         /// Gets the total number of records in the PBilldetail table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared(ProcString.procNameBill_GetRecordCount, null, null, true, null);
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
                                  recordCount = (int)dt.Rows[0]["count"];
                              }
                          }
                      }
                  }
              }

              return recordCount;
         }

         /// <summary>
         /// Gets the total number of records in the PBilldetail table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, int? billId, int? productId, int? quantity, decimal? unitPrice, DateTime? createdDate, DateTime? modifiedDate, int? modifiedUserId, int? createdUserId, bool? isDeleted, int? status, int? discount)
        {
              int recordCount = 0;
              string storedProcName = ProcString.procNameBill_GetRecordCountDynamicWhere;

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, billId, productId, quantity, unitPrice, createdDate, modifiedDate, modifiedUserId, createdUserId, isDeleted, status, discount);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  recordCount = (int)dt.Rows[0]["count"];
                              }
                          }
                      }
                  }
              }

              return recordCount;
         }

         /// <summary>
         /// Selects PBilldetail records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<PBilldetailModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared(ProcString.procNameBill_SelectSkipAndTake, null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects PBilldetail records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<PBilldetailModel> SelectSkipAndTakeDynamicWhere(int? id, int? billId, int? productId, int? quantity, decimal? unitPrice, DateTime? createdDate, DateTime? modifiedDate, int? modifiedUserId, int? createdUserId, bool? isDeleted, int? status, int? discount, string sortByExpression, int startRowIndex, int rows)
         {
            List<PBilldetailModel> objPBilldetailCol = null;
              string storedProcName = ProcString.procNameBill_SelectSkipAndTakeDynamicWhere;

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // select, skip, take, sort parameters
                      command.Parameters.AddWithValue("@start", startRowIndex);
                      command.Parameters.AddWithValue("@numberOfRows", rows);
                      command.Parameters.AddWithValue("@sort", sortByExpression);

                    // search parameters
                    AddSearchCommandParamsShared(command, id, billId, productId, quantity, unitPrice, createdDate, modifiedDate, modifiedUserId, createdUserId, isDeleted, status, discount);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPBilldetailCol = new List<PBilldetailModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PBilldetailModel objPBilldetail = CreatePBilldetailFromDataRowShared(dr);
                                      objPBilldetailCol.Add(objPBilldetail);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPBilldetailCol;
         }

         /// <summary>
         /// Gets the grand total or sum of fields with a money of decimal data type
         /// </summary>
         public static PBilldetailModel SelectTotals()
         {
              PBilldetailModel objPBilldetail = null;
              string storedProcName = ProcString.procNameBill_SelectTotal;

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
                                  if(dt.Rows[0]["UnitPriceTotal"] != DBNull.Value)
                                       objPBilldetail.UnitPriceTotal = (decimal)dt.Rows[0]["UnitPriceTotal"];
                              }
                          }
                      }
                  }
              }

              return objPBilldetail;
         }

         /// <summary>
         /// Selects all PBilldetail
         /// </summary>
         public static List<PBilldetailModel> SelectAll()
         {
             return SelectShared(ProcString.procNameBillDetail_SelectAll, String.Empty, null);
         }

        /// <summary>
        /// Selects records based on the passed filters as a collection (List) of PBilldetail.
        /// </summary>
        public static List<PBilldetailModel> SelectAllDynamicWhere(int? id, int? billId, int? productId, int? quantity, decimal? unitPrice, DateTime? createdDate, DateTime? modifiedDate, int? modifiedUserId, int? createdUserId, bool? isDeleted, int? status, int? discount)
         {
            List<PBilldetailModel> objPBilldetailCol = null;
            string storedProcName = ProcString.procNameBillDetail_SelectAllWhereDynamic;


            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, billId, productId, quantity, unitPrice, createdDate, modifiedDate, modifiedUserId, createdUserId, isDeleted, status,discount);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPBilldetailCol = new List<PBilldetailModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PBilldetailModel objPBilldetail = CreatePBilldetailFromDataRowShared(dr);
                                      objPBilldetailCol.Add(objPBilldetail);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPBilldetailCol;
         }

         /// <summary>
         /// Selects Id and BillId columns for use with a DropDownList web control
         /// </summary>
         public static List<PBilldetailModel> SelectPBilldetailDropDownListData()
         {
            List<PBilldetailModel> objPBilldetailCol = null;
              string storedProcName = ProcString.procNameBillDetail_SelectDropDownListData;

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
                                  objPBilldetailCol = new List<PBilldetailModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PBilldetailModel objPBilldetail = new PBilldetailModel();
                                      objPBilldetail.Id = (int)dr["Id"];

                                      if (dr["BillId"] != System.DBNull.Value)
                                          objPBilldetail.BillId = (int)(dr["BillId"]);
                                      else
                                          objPBilldetail.BillId = null;

                                      objPBilldetailCol.Add(objPBilldetail);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPBilldetailCol;
         }

         public static List<PBilldetailModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<PBilldetailModel> objPBilldetailCol = null;

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
                          command.Parameters.AddWithValue("@sort", sortByExpression);
                      }

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPBilldetailCol = new List<PBilldetailModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PBilldetailModel objPBilldetail = CreatePBilldetailFromDataRowShared(dr);
                                      objPBilldetailCol.Add(objPBilldetail);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPBilldetailCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(PBilldetailModel objPBilldetail)
         {
             string storedProcName = ProcString.procNameBillDetail_Insert;
             return InsertUpdate(objPBilldetail, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(PBilldetailModel objPBilldetail)
         {
             string storedProcName = ProcString.procNameBillDetail_Update;
             InsertUpdate(objPBilldetail, true, storedProcName);
         }

         private static int InsertUpdate(PBilldetailModel objPBilldetail, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objPBilldetail.Id;

              object billId = objPBilldetail.BillId;
              object productId = objPBilldetail.ProductId;
              object quantity = objPBilldetail.Quantity;
              object unitPrice = objPBilldetail.UnitPrice;
              object createdDate = objPBilldetail.CreatedDate;
              object createdUserId = objPBilldetail.CreatedUserId;
              object modifiedDate = objPBilldetail.ModifiedDate;
              object modifiedUserId = objPBilldetail.ModifiedUserId;
              object status = objPBilldetail.Status;
              object discount = objPBilldetail.Discount;

              if (objPBilldetail.BillId == null)
                  billId = System.DBNull.Value;

              if (objPBilldetail.ProductId == null)
                  productId = System.DBNull.Value;

              if (objPBilldetail.Quantity == null)
                  quantity = System.DBNull.Value;

              if (objPBilldetail.UnitPrice == null)
                  unitPrice = System.DBNull.Value;

              if (objPBilldetail.CreatedDate == null)
                  createdDate = System.DBNull.Value;

              if (objPBilldetail.ModifiedDate == null)
                  modifiedDate = System.DBNull.Value;

              if (objPBilldetail.ModifiedUserId == null)
                  modifiedUserId = System.DBNull.Value;

            if (objPBilldetail.CreatedUserId == null)
                createdUserId = System.DBNull.Value;

            if (objPBilldetail.Status == null)
                  status = System.DBNull.Value;

            if (objPBilldetail.Discount == null)
                discount = System.DBNull.Value;

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
                          command.Parameters.AddWithValue("@id", objPBilldetail.Id);
                      }

                      command.Parameters.AddWithValue("@billId", billId);
                      command.Parameters.AddWithValue("@productId", productId);
                      command.Parameters.AddWithValue("@quantity", quantity);
                      command.Parameters.AddWithValue("@unitPrice", unitPrice);
                      command.Parameters.AddWithValue("@createdDate", createdDate);
                      command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                      command.Parameters.AddWithValue("@createdUserId", createdUserId);
                      command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                      command.Parameters.AddWithValue("@isDeleted", objPBilldetail.IsDeleted);
                      command.Parameters.AddWithValue("@status", status);
                      command.Parameters.AddWithValue("@discount", discount);

                    if (isUpdate)
                        command.ExecuteNonQuery();
                    else
                    { command.ExecuteScalar();
                        return 1;
                    }
                  }
              }

              return newlyCreatedId;
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
              string storedProcName = ProcString.procNameBillDetail_Delete;

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, int? billId, int? productId, int? quantity, decimal? unitPrice, DateTime? createdDate, DateTime? modifiedDate, int? modifiedUserId, int? createdUserId, bool? isDeleted, int? status, int? discount)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(billId != null)
                  command.Parameters.AddWithValue("@billId", billId);
              else
                  command.Parameters.AddWithValue("@billId", System.DBNull.Value);

              if(productId != null)
                  command.Parameters.AddWithValue("@productId", productId);
              else
                  command.Parameters.AddWithValue("@productId", System.DBNull.Value);

              if(quantity != null)
                  command.Parameters.AddWithValue("@quantity", quantity);
              else
                  command.Parameters.AddWithValue("@quantity", System.DBNull.Value);

              if(unitPrice != null)
                  command.Parameters.AddWithValue("@unitPrice", unitPrice);
              else
                  command.Parameters.AddWithValue("@unitPrice", System.DBNull.Value);

              if(createdDate != null)
                  command.Parameters.AddWithValue("@createdDate", createdDate);
              else
                  command.Parameters.AddWithValue("@createdDate", System.DBNull.Value);

              if(modifiedDate != null)
                  command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
              else
                  command.Parameters.AddWithValue("@modifiedDate", System.DBNull.Value);

              if(modifiedUserId != null)
                  command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
              else
                  command.Parameters.AddWithValue("@modifiedUserId", System.DBNull.Value);

            if (modifiedUserId != null)
                command.Parameters.AddWithValue("@createdUserId", createdUserId);
            else
                command.Parameters.AddWithValue("@createdUserId", System.DBNull.Value);

            if (isDeleted != null)
                  command.Parameters.AddWithValue("@isDeleted", isDeleted);
              else
                  command.Parameters.AddWithValue("@isDeleted", System.DBNull.Value);

              if(status != null)
                  command.Parameters.AddWithValue("@status", status);
              else
                  command.Parameters.AddWithValue("@status", System.DBNull.Value);

            if (status != null)
                command.Parameters.AddWithValue("@discount", discount);
            else
                command.Parameters.AddWithValue("@discount", System.DBNull.Value);

        }

         /// <summary>
         /// Creates a PBilldetail object from the passed data row
         /// </summary>
         private static PBilldetailModel CreatePBilldetailFromDataRowShared(DataRow dr)
         {
             PBilldetailModel objPBilldetail = new PBilldetailModel();

             objPBilldetail.Id = (int)dr["Id"];

             if (dr["BillId"] != System.DBNull.Value)
                 objPBilldetail.BillId = (int)dr["BillId"];
             else
                 objPBilldetail.BillId = null;

             if (dr["ProductId"] != System.DBNull.Value)
                 objPBilldetail.ProductId = (int)dr["ProductId"];
             else
                 objPBilldetail.ProductId = null;

             if (dr["Quantity"] != System.DBNull.Value)
                 objPBilldetail.Quantity = (int)dr["Quantity"];
             else
                 objPBilldetail.Quantity = null;

             if (dr["UnitPrice"] != System.DBNull.Value)
                 objPBilldetail.UnitPrice = (decimal)dr["UnitPrice"];
             else
                 objPBilldetail.UnitPrice = null;

             if (dr["CreatedDate"] != System.DBNull.Value)
                 objPBilldetail.CreatedDate = (DateTime)dr["CreatedDate"];
             else
                 objPBilldetail.CreatedDate = null;

             if (dr["ModifiedDate"] != System.DBNull.Value)
                 objPBilldetail.ModifiedDate = (DateTime)dr["ModifiedDate"];
             else
                 objPBilldetail.ModifiedDate = null;

            if (dr["CreatedUserId"] != System.DBNull.Value)
                objPBilldetail.CreatedUserId = (int)dr["CreatedUserId"];
            else
                objPBilldetail.ModifiedUserId = null;

            if (dr["ModifiedUserId"] != System.DBNull.Value)
                 objPBilldetail.ModifiedUserId = (int)dr["ModifiedUserId"];
             else
                 objPBilldetail.ModifiedUserId = null;

             if (dr["IsDeleted"] != System.DBNull.Value)
                 objPBilldetail.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objPBilldetail.IsDeleted = false;

             if (dr["Status"] != System.DBNull.Value)
                 objPBilldetail.Status = (int)dr["Status"];
             else
                 objPBilldetail.Status = null;

            if (dr["Discount"] != System.DBNull.Value)
                objPBilldetail.Discount = (int)dr["Discount"];
            else
                objPBilldetail.Status = null;

            return objPBilldetail;
         }
     }
}
