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
     /// Base class for PBillDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the PBillDataLayer class
     /// </summary>
     public class PBillDataLayerBase
     {
         // constructor
         public PBillDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PBillModel SelectByPrimaryKey(int id)
         {
            PBillModel objPBill = null;
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
                                  objPBill = CreatePBillFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objPBill;
         }

        public static PBillModel SelectByCode(string code)
        {
            PBillModel objPBill = null;
            string storedProcName = "[dbo].[PBill_SelectByCode]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // parameters
                    command.Parameters.AddWithValue("@code", code);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objPBill = CreatePBillFromDataRowShared(dt.Rows[0]);
                            }
                        }
                    }
                }
            }

            return objPBill;
        }

        /// <summary>
        /// Gets the total number of records in the PBill table
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
         /// Gets the total number of records in the PBill table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, decimal? totalPrice, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, int? customerId, string deliveryAddress)
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
                      AddSearchCommandParamsShared(command, id, totalPrice, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, customerId, deliveryAddress);

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

        public static int CustomerInBill(int customerId)
        {
            int recordCount = 0;
            string storedProcName = ProcString.procNameBill_InBill;

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;


                    // search parameters
                    command.Parameters.AddWithValue("@id", customerId);

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
                        else
                            return 0;
                    }
                }
            }

            return recordCount;
        }

        /// <summary>
        /// Selects PBill records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
        /// </summary>
        public static List<PBillModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared(ProcString.procNameBill_SelectSkipAndTake, null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects PBill records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<PBillModel> SelectSkipAndTakeDynamicWhere(int? id, decimal? totalPrice, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, int? customerId, string deliveryAddress, string sortByExpression, int startRowIndex, int rows)
         {
            List<PBillModel> objPBillCol = null;
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
                      AddSearchCommandParamsShared(command, id, totalPrice, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, customerId, deliveryAddress);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPBillCol = new List<PBillModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PBillModel objPBill = CreatePBillFromDataRowShared(dr);
                                      objPBillCol.Add(objPBill);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPBillCol;
         }

         /// <summary>
         /// Gets the grand total or sum of fields with a money of decimal data type
         /// </summary>
         public static PBillModel SelectTotals()
         {
              PBillModel objPBill = null;
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
                                  if(dt.Rows[0]["TotalPrice"] != DBNull.Value)
                                       objPBill.TotalPrice = (decimal)dt.Rows[0]["TotalPrice"];
                              }
                          }
                      }
                  }
              }

              return objPBill;
         }

         /// <summary>
         /// Selects all PBill
         /// </summary>
         public static List<PBillModel> SelectAll()
         {
             return SelectShared(ProcString.procNameBillDetail_SelectAll, String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PBill.
         /// </summary>
         public static List<PBillModel> SelectAllDynamicWhere(int? id, decimal? totalPrice, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, int? customerId, string deliveryAddress)
         {
            List<PBillModel> objPBillCol = null;
              string storedProcName = ProcString.procNameBillDetail_SelectAllWhereDynamic;

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, totalPrice, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, customerId, deliveryAddress);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPBillCol = new List<PBillModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PBillModel objPBill = CreatePBillFromDataRowShared(dr);
                                      objPBillCol.Add(objPBill);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPBillCol;
         }

         /// <summary>
         /// Selects Id and TotalPrice columns for use with a DropDownList web control
         /// </summary>
         public static List<PBillModel> SelectPBillDropDownListData()
         {
            List<PBillModel> objPBillCol = null;
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
                                  objPBillCol = new List<PBillModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PBillModel objPBill = new PBillModel();
                                      objPBill.Id = (int)dr["Id"];

                                      if (dr["TotalPrice"] != System.DBNull.Value)
                                          objPBill.TotalPrice = (decimal)(dr["TotalPrice"]);
                                      else
                                          objPBill.TotalPrice = null;

                                      objPBillCol.Add(objPBill);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPBillCol;
         }

         public static List<PBillModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<PBillModel> objPBillCol = null;

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
                                  objPBillCol = new List<PBillModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PBillModel objPBill = CreatePBillFromDataRowShared(dr);
                                      objPBillCol.Add(objPBill);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPBillCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(PBillModel objPBill)
         {
             string storedProcName = ProcString.procNameBill_Insert;
             return InsertUpdate(objPBill, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(PBillModel objPBill)
         {
             string storedProcName = ProcString.procNameBill_Update;
             InsertUpdate(objPBill, true, storedProcName);
         }

         private static int InsertUpdate(PBillModel objPBill, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objPBill.Id;

              object totalPrice = objPBill.TotalPrice;
              object createdDate = objPBill.CreatedDate;
              object modifiedDate = objPBill.ModifiedDate;
              object createdUserId = objPBill.CreatedUserId;
              object modifiedUserId = objPBill.ModifiedUserId;
              object deliveryAddress = objPBill.DeliveryAddress;
              object customerId = objPBill.CustomerId;
              object status = objPBill.Status;

              if (objPBill.TotalPrice == null)
                  totalPrice = System.DBNull.Value;

              if (objPBill.CreatedDate == null)
                  createdDate = System.DBNull.Value;

              if (objPBill.ModifiedDate == null)
                  modifiedDate = System.DBNull.Value;

              if (objPBill.CreatedUserId == null)
                  createdUserId = System.DBNull.Value;

              if (objPBill.ModifiedUserId == null)
                  modifiedUserId = System.DBNull.Value;

              if (objPBill.DeliveryAddress == null)
                deliveryAddress = System.DBNull.Value;

            if (objPBill.CustomerId == null)
                customerId = System.DBNull.Value;

            if (objPBill.Status == null)
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
                          command.Parameters.AddWithValue("@id", objPBill.Id);
                      }
                    else
                    {
                        command.Parameters.AddWithValue("@code", objPBill.Code);
                    }

                    command.Parameters.AddWithValue("@totalPrice", totalPrice);
                      command.Parameters.AddWithValue("@createdDate", createdDate);
                      command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                      command.Parameters.AddWithValue("@createdUserId", createdUserId);
                      command.Parameters.AddWithValue("@customerId", customerId);
                      command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                      command.Parameters.AddWithValue("@isDeleted", objPBill.IsDeleted);
                      command.Parameters.AddWithValue("@deliveryAddress", deliveryAddress);
                      command.Parameters.AddWithValue("@status", status);

                      if (isUpdate)
                          command.ExecuteNonQuery();
                    else
                    {
                        command.ExecuteScalar();
                        newlyCreatedId = 1;
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
              string storedProcName = ProcString.procNameBill_Delete;

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, decimal? totalPrice, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, int? customerId, string deliveryAddress)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(totalPrice != null)
                  command.Parameters.AddWithValue("@totalPrice", totalPrice);
              else
                  command.Parameters.AddWithValue("@totalPrice", System.DBNull.Value);

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

            if (createdUserId != null)
                command.Parameters.AddWithValue("@customerId", customerId);
            else
                command.Parameters.AddWithValue("@customerId", System.DBNull.Value);

            if (modifiedUserId != null)
                  command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
              else
                  command.Parameters.AddWithValue("@modifiedUserId", System.DBNull.Value);

              if(isDeleted != null)
                  command.Parameters.AddWithValue("@isDeleted", isDeleted);
              else
                  command.Parameters.AddWithValue("@isDeleted", System.DBNull.Value);

              if(deliveryAddress != null)
                  command.Parameters.AddWithValue("@deliveryAddress", deliveryAddress);
              else
                  command.Parameters.AddWithValue("@deliveryAddress", System.DBNull.Value);

              if(status != null)
                  command.Parameters.AddWithValue("@status", status);
              else
                  command.Parameters.AddWithValue("@status", System.DBNull.Value);

         }

         /// <summary>
         /// Creates a PBill object from the passed data row
         /// </summary>
         private static PBillModel CreatePBillFromDataRowShared(DataRow dr)
         {
             PBillModel objPBill = new PBillModel();

             objPBill.Id = (int)dr["Id"];

             objPBill.Code = dr["Code"].ToString();

             if (dr["TotalPrice"] != System.DBNull.Value)
                 objPBill.TotalPrice = (decimal)dr["TotalPrice"];
             else
                 objPBill.TotalPrice = null;

             if (dr["CreatedDate"] != System.DBNull.Value)
                 objPBill.CreatedDate = (DateTime)dr["CreatedDate"];
             else
                 objPBill.CreatedDate = null;

             if (dr["ModifiedDate"] != System.DBNull.Value)
                 objPBill.ModifiedDate = (DateTime)dr["ModifiedDate"];
             else
                 objPBill.ModifiedDate = null;

             if (dr["CreatedUserId"] != System.DBNull.Value)
                 objPBill.CreatedUserId = (int)dr["CreatedUserId"];
             else
                 objPBill.CreatedUserId = null;

            if (dr["CustomerId"] != System.DBNull.Value)
                objPBill.CustomerId = (int)dr["CustomerId"];
            else
                objPBill.CustomerId = null;

            if (dr["ModifiedUserId"] != System.DBNull.Value)
                 objPBill.ModifiedUserId = (int)dr["ModifiedUserId"];
             else
                 objPBill.ModifiedUserId = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objPBill.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objPBill.IsDeleted = false;

             if (dr["DeliveryAddress"] != System.DBNull.Value)
                 objPBill.DeliveryAddress = dr["DeliveryAddress"].ToString();
             else
                 objPBill.DeliveryAddress = null;

             if (dr["Status"] != System.DBNull.Value)
                 objPBill.Status = (int)dr["Status"];
             else
                 objPBill.Status = null;

             return objPBill;
         }
     }
}
