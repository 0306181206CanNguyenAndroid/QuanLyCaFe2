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
     /// Base class for PProductDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the PProductDataLayer class
     /// </summary>
     public class PProductDataLayerBase
     {
         // constructor
         public PProductDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PProductModel SelectByPrimaryKey(int id)
         {
              PProductModel objPProduct = null;
              string storedProcName = "[dbo].[PProduct_SelectByPrimaryKey]";

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
                                  objPProduct = CreatePProductFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objPProduct;
         }

         /// <summary>
         /// Gets the total number of records in the PProduct table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[PProduct_GetRecordCount]", null, null, true, null);
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
         /// Gets the total number of records in the PProduct table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string name, string description, int? manuId, int? productTypeId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[PProduct_GetRecordCountWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, name, description, manuId, productTypeId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

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
         /// Selects PProduct records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<PProductModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[PProduct_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects PProduct records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<PProductModel> SelectSkipAndTakeDynamicWhere(int? id, string name, string description, int? manuId, int? productTypeId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string sortByExpression, int startRowIndex, int rows)
         {
            List<PProductModel> objPProductCol = null;
              string storedProcName = "[dbo].[PProduct_SelectSkipAndTakeWhereDynamic]";

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
                      AddSearchCommandParamsShared(command, id, name, description, manuId, productTypeId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPProductCol = new List<PProductModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PProductModel objPProduct = CreatePProductFromDataRowShared(dr);
                                      objPProductCol.Add(objPProduct);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPProductCol;
         }

         /// <summary>
         /// Selects all PProduct
         /// </summary>
         public static List<PProductModel> SelectAll()
         {
             return SelectShared("[dbo].[PProduct_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PProduct.
         /// </summary>
         public static List<PProductModel> SelectAllDynamicWhere(int? id, string name, string description, int? manuId, int? productTypeId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
            List<PProductModel> objPProductCol = null;
              string storedProcName = "[dbo].[PProduct_SelectAllWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, name, description, manuId, productTypeId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPProductCol = new List<PProductModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PProductModel objPProduct = CreatePProductFromDataRowShared(dr);
                                      objPProductCol.Add(objPProduct);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPProductCol;
         }

         /// <summary>
         /// Selects Id and Name columns for use with a DropDownList web control
         /// </summary>
         public static List<PProductModel> SelectPProductDropDownListData()
         {
            List<PProductModel> objPProductCol = null;
              string storedProcName = "[dbo].[PProduct_SelectDropDownListData]";

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
                                  objPProductCol = new List<PProductModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PProductModel objPProduct = new PProductModel();
                                      objPProduct.Id = (int)dr["Id"];

                                      if (dr["Name"] != System.DBNull.Value)
                                          objPProduct.Name = (string)(dr["Name"]);
                                      else
                                          objPProduct.Name = null;

                                      objPProductCol.Add(objPProduct);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPProductCol;
         }

         public static List<PProductModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<PProductModel> objPProductCol = null;

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
                                  objPProductCol = new List<PProductModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PProductModel objPProduct = CreatePProductFromDataRowShared(dr);
                                      objPProductCol.Add(objPProduct);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPProductCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(PProductModel objPProduct)
         {
             string storedProcName = "[dbo].[PProduct_Insert]";
             return InsertUpdate(objPProduct, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(PProductModel objPProduct)
         {
             string storedProcName = "[dbo].[PProduct_Update]";
             InsertUpdate(objPProduct, true, storedProcName);
         }

         private static int InsertUpdate(PProductModel objPProduct, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objPProduct.Id;

              object name = objPProduct.Name;
              object description = objPProduct.Description;
              object manuId = objPProduct.ManuId;
              object productTypeId = objPProduct.ProductTypeId;
              object createdDate = objPProduct.CreatedDate;
              object modifiedDate = objPProduct.ModifiedDate;
              object createdUserId = objPProduct.CreatedUserId;
              object modifiedUserId = objPProduct.ModifiedUserId;
              object status = objPProduct.Status;

              if (String.IsNullOrEmpty(objPProduct.Name))
                  name = System.DBNull.Value;

              if (String.IsNullOrEmpty(objPProduct.Description))
                  description = System.DBNull.Value;

              if (objPProduct.ManuId == null)
                  manuId = System.DBNull.Value;

              if (objPProduct.ProductTypeId == null)
                  productTypeId = System.DBNull.Value;

              if (objPProduct.CreatedDate == null)
                  createdDate = System.DBNull.Value;

              if (objPProduct.ModifiedDate == null)
                  modifiedDate = System.DBNull.Value;

              if (objPProduct.CreatedUserId == null)
                  createdUserId = System.DBNull.Value;

              if (objPProduct.ModifiedUserId == null)
                  modifiedUserId = System.DBNull.Value;

              if (objPProduct.Status == null)
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
                          command.Parameters.AddWithValue("@id", objPProduct.Id);
                      }

                      command.Parameters.AddWithValue("@name", name);
                      command.Parameters.AddWithValue("@description", description);
                      command.Parameters.AddWithValue("@manuId", manuId);
                      command.Parameters.AddWithValue("@productTypeId", productTypeId);
                      command.Parameters.AddWithValue("@createdDate", createdDate);
                      command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                      command.Parameters.AddWithValue("@createdUserId", createdUserId);
                      command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                      command.Parameters.AddWithValue("@isDeleted", objPProduct.IsDeleted);
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
              string storedProcName = "[dbo].[PProduct_Delete]";

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, string name, string description, int? manuId, int? productTypeId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(!String.IsNullOrEmpty(name))
                  command.Parameters.AddWithValue("@name", name);
              else
                  command.Parameters.AddWithValue("@name", System.DBNull.Value);

              if(!String.IsNullOrEmpty(description))
                  command.Parameters.AddWithValue("@description", description);
              else
                  command.Parameters.AddWithValue("@description", System.DBNull.Value);

              if(manuId != null)
                  command.Parameters.AddWithValue("@manuId", manuId);
              else
                  command.Parameters.AddWithValue("@manuId", System.DBNull.Value);

              if(productTypeId != null)
                  command.Parameters.AddWithValue("@productTypeId", productTypeId);
              else
                  command.Parameters.AddWithValue("@productTypeId", System.DBNull.Value);

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
         /// Creates a PProduct object from the passed data row
         /// </summary>
         private static PProductModel CreatePProductFromDataRowShared(DataRow dr)
         {
             PProductModel objPProduct = new PProductModel();

             objPProduct.Id = (int)dr["Id"];

             if (dr["Name"] != System.DBNull.Value)
                 objPProduct.Name = dr["Name"].ToString();
             else
                 objPProduct.Name = null;

             if (dr["Description"] != System.DBNull.Value)
                 objPProduct.Description = dr["Description"].ToString();
             else
                 objPProduct.Description = null;

             if (dr["ManuId"] != System.DBNull.Value)
                 objPProduct.ManuId = (int)dr["ManuId"];
             else
                 objPProduct.ManuId = null;

             if (dr["ProductTypeId"] != System.DBNull.Value)
                 objPProduct.ProductTypeId = (int)dr["ProductTypeId"];
             else
                 objPProduct.ProductTypeId = null;

             if (dr["CreatedDate"] != System.DBNull.Value)
                 objPProduct.CreatedDate = (DateTime)dr["CreatedDate"];
             else
                 objPProduct.CreatedDate = null;

             if (dr["ModifiedDate"] != System.DBNull.Value)
                 objPProduct.ModifiedDate = (DateTime)dr["ModifiedDate"];
             else
                 objPProduct.ModifiedDate = null;

             if (dr["CreatedUserId"] != System.DBNull.Value)
                 objPProduct.CreatedUserId = (int)dr["CreatedUserId"];
             else
                 objPProduct.CreatedUserId = null;

             if (dr["ModifiedUserId"] != System.DBNull.Value)
                 objPProduct.ModifiedUserId = (int)dr["ModifiedUserId"];
             else
                 objPProduct.ModifiedUserId = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objPProduct.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objPProduct.IsDeleted = false;

             if (dr["Status"] != System.DBNull.Value)
                 objPProduct.Status = (int)dr["Status"];
             else
                 objPProduct.Status = null;

             return objPProduct;
         }
     }
}
