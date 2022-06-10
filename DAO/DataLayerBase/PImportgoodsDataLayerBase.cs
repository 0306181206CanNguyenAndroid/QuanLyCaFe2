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
     /// Base class for PImportgoodsDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the PImportgoodsDataLayer class
     /// </summary>
     public class PImportgoodsDataLayerBase
     {
         // constructor
         public PImportgoodsDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PImportgoodsModel SelectByPrimaryKey(int id)
         {
              PImportgoodsModel objPImportgoods = null;
              string storedProcName = "[dbo].[PImportgoods_SelectByPrimaryKey]";

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
                                  objPImportgoods = CreatePImportgoodsFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objPImportgoods;
         }

         /// <summary>
         /// Gets the total number of records in the PImportgoods table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[PImportgoods_GetRecordCount]", null, null, true, null);
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
         /// Gets the total number of records in the PImportgoods table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string goodsNumber, string goodsCode, string note, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, int? importQuantity, bool? isDeleted, int? status)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[PImportgoods_GetRecordCountWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, goodsNumber, goodsCode, note, createdDate, modifiedDate, createdUserId, modifiedUserId, importQuantity, isDeleted, status);

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
         /// Selects PImportgoods records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<PImportgoodsModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[PImportgoods_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects PImportgoods records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<PImportgoodsModel> SelectSkipAndTakeDynamicWhere(int? id, string goodsNumber, string goodsCode, string note, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, int? importQuantity, bool? isDeleted, int? status, string sortByExpression, int startRowIndex, int rows)
         {
            List<PImportgoodsModel> objPImportgoodsCol = null;
              string storedProcName = "[dbo].[PImportgoods_SelectSkipAndTakeWhereDynamic]";

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
                      AddSearchCommandParamsShared(command, id, goodsNumber, goodsCode, note, createdDate, modifiedDate, createdUserId, modifiedUserId, importQuantity, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPImportgoodsCol = new List<PImportgoodsModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PImportgoodsModel objPImportgoods = CreatePImportgoodsFromDataRowShared(dr);
                                      objPImportgoodsCol.Add(objPImportgoods);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPImportgoodsCol;
         }

         /// <summary>
         /// Selects all PImportgoods
         /// </summary>
         public static List<PImportgoodsModel> SelectAll()
         {
             return SelectShared("[dbo].[PImportgoods_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PImportgoods.
         /// </summary>
         public static List<PImportgoodsModel> SelectAllDynamicWhere(int? id, string goodsNumber, string goodsCode, string note, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, int? importQuantity, bool? isDeleted, int? status)
         {
            List<PImportgoodsModel> objPImportgoodsCol = null;
              string storedProcName = "[dbo].[PImportgoods_SelectAllWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, goodsNumber, goodsCode, note, createdDate, modifiedDate, createdUserId, modifiedUserId, importQuantity, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPImportgoodsCol = new List<PImportgoodsModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PImportgoodsModel objPImportgoods = CreatePImportgoodsFromDataRowShared(dr);
                                      objPImportgoodsCol.Add(objPImportgoods);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPImportgoodsCol;
         }

         /// <summary>
         /// Selects Id and GoodsNumber columns for use with a DropDownList web control
         /// </summary>
         public static List<PImportgoodsModel> SelectPImportgoodsDropDownListData()
         {
            List<PImportgoodsModel> objPImportgoodsCol = null;
              string storedProcName = "[dbo].[PImportgoods_SelectDropDownListData]";

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
                                  objPImportgoodsCol = new List<PImportgoodsModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PImportgoodsModel objPImportgoods = new PImportgoodsModel();
                                      objPImportgoods.Id = (int)dr["Id"];

                                      if (dr["GoodsNumber"] != System.DBNull.Value)
                                          objPImportgoods.GoodsNumber = (string)(dr["GoodsNumber"]);
                                      else
                                          objPImportgoods.GoodsNumber = null;

                                      objPImportgoodsCol.Add(objPImportgoods);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPImportgoodsCol;
         }

         public static List<PImportgoodsModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<PImportgoodsModel> objPImportgoodsCol = null;

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
                                  objPImportgoodsCol = new List<PImportgoodsModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PImportgoodsModel objPImportgoods = CreatePImportgoodsFromDataRowShared(dr);
                                      objPImportgoodsCol.Add(objPImportgoods);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPImportgoodsCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(PImportgoodsModel objPImportgoods)
         {
             string storedProcName = "[dbo].[PImportgoods_Insert]";
             return InsertUpdate(objPImportgoods, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(PImportgoodsModel objPImportgoods)
         {
             string storedProcName = "[dbo].[PImportgoods_Update]";
             InsertUpdate(objPImportgoods, true, storedProcName);
         }

         private static int InsertUpdate(PImportgoodsModel objPImportgoods, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objPImportgoods.Id;

              object goodsNumber = objPImportgoods.GoodsNumber;
              object goodsCode = objPImportgoods.GoodsCode;
              object note = objPImportgoods.Note;
              object createdDate = objPImportgoods.CreatedDate;
              object modifiedDate = objPImportgoods.ModifiedDate;
              object createdUserId = objPImportgoods.CreatedUserId;
              object modifiedUserId = objPImportgoods.ModifiedUserId;
              object importQuantity = objPImportgoods.ImportQuantity;
              object status = objPImportgoods.Status;

              if (String.IsNullOrEmpty(objPImportgoods.GoodsNumber))
                  goodsNumber = System.DBNull.Value;

              if (String.IsNullOrEmpty(objPImportgoods.GoodsCode))
                  goodsCode = System.DBNull.Value;

              if (String.IsNullOrEmpty(objPImportgoods.Note))
                  note = System.DBNull.Value;

              if (objPImportgoods.CreatedDate == null)
                  createdDate = System.DBNull.Value;

              if (objPImportgoods.ModifiedDate == null)
                  modifiedDate = System.DBNull.Value;

              if (objPImportgoods.CreatedUserId == null)
                  createdUserId = System.DBNull.Value;

              if (objPImportgoods.ModifiedUserId == null)
                  modifiedUserId = System.DBNull.Value;

              if (objPImportgoods.ImportQuantity == null)
                  importQuantity = System.DBNull.Value;

              if (objPImportgoods.Status == null)
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
                          command.Parameters.AddWithValue("@id", objPImportgoods.Id);
                      }

                      command.Parameters.AddWithValue("@goodsNumber", goodsNumber);
                      command.Parameters.AddWithValue("@goodsCode", goodsCode);
                      command.Parameters.AddWithValue("@note", note);
                      command.Parameters.AddWithValue("@createdDate", createdDate);
                      command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                      command.Parameters.AddWithValue("@createdUserId", createdUserId);
                      command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                      command.Parameters.AddWithValue("@importQuantity", importQuantity);
                      command.Parameters.AddWithValue("@isDeleted", objPImportgoods.IsDeleted);
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
              string storedProcName = "[dbo].[PImportgoods_Delete]";

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, string goodsNumber, string goodsCode, string note, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, int? importQuantity, bool? isDeleted, int? status)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(!String.IsNullOrEmpty(goodsNumber))
                  command.Parameters.AddWithValue("@goodsNumber", goodsNumber);
              else
                  command.Parameters.AddWithValue("@goodsNumber", System.DBNull.Value);

              if(!String.IsNullOrEmpty(goodsCode))
                  command.Parameters.AddWithValue("@goodsCode", goodsCode);
              else
                  command.Parameters.AddWithValue("@goodsCode", System.DBNull.Value);

              if(!String.IsNullOrEmpty(note))
                  command.Parameters.AddWithValue("@note", note);
              else
                  command.Parameters.AddWithValue("@note", System.DBNull.Value);

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
         /// Creates a PImportgoods object from the passed data row
         /// </summary>
         private static PImportgoodsModel CreatePImportgoodsFromDataRowShared(DataRow dr)
         {
             PImportgoodsModel objPImportgoods = new PImportgoodsModel();

             objPImportgoods.Id = (int)dr["Id"];

             if (dr["GoodsNumber"] != System.DBNull.Value)
                 objPImportgoods.GoodsNumber = dr["GoodsNumber"].ToString();
             else
                 objPImportgoods.GoodsNumber = null;

             if (dr["GoodsCode"] != System.DBNull.Value)
                 objPImportgoods.GoodsCode = dr["GoodsCode"].ToString();
             else
                 objPImportgoods.GoodsCode = null;

             if (dr["Note"] != System.DBNull.Value)
                 objPImportgoods.Note = dr["Note"].ToString();
             else
                 objPImportgoods.Note = null;

             if (dr["CreatedDate"] != System.DBNull.Value)
                 objPImportgoods.CreatedDate = (DateTime)dr["CreatedDate"];
             else
                 objPImportgoods.CreatedDate = null;

             if (dr["ModifiedDate"] != System.DBNull.Value)
                 objPImportgoods.ModifiedDate = (DateTime)dr["ModifiedDate"];
             else
                 objPImportgoods.ModifiedDate = null;

             if (dr["CreatedUserId"] != System.DBNull.Value)
                 objPImportgoods.CreatedUserId = (int)dr["CreatedUserId"];
             else
                 objPImportgoods.CreatedUserId = null;

             if (dr["ModifiedUserId"] != System.DBNull.Value)
                 objPImportgoods.ModifiedUserId = (int)dr["ModifiedUserId"];
             else
                 objPImportgoods.ModifiedUserId = null;

             if (dr["ImportQuantity"] != System.DBNull.Value)
                 objPImportgoods.ImportQuantity = (int)dr["ImportQuantity"];
             else
                 objPImportgoods.ImportQuantity = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objPImportgoods.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objPImportgoods.IsDeleted = false;

             if (dr["Status"] != System.DBNull.Value)
                 objPImportgoods.Status = (int)dr["Status"];
             else
                 objPImportgoods.Status = null;

             return objPImportgoods;
         }
     }
}
