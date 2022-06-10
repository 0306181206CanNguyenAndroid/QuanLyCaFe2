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
     /// Base class for PBilllogDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the PBilllogDataLayer class
     /// </summary>
     public class PBilllogDataLayerBase
     {
         // constructor
         public PBilllogDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PBilllogModel SelectByPrimaryKey(int id)
         {
              PBilllogModel objPBilllog = null;
              string storedProcName = "[dbo].[PBilllog_SelectByPrimaryKey]";

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
                                  objPBilllog = CreatePBilllogFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objPBilllog;
         }

         /// <summary>
         /// Gets the total number of records in the PBilllog table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[PBilllog_GetRecordCount]", null, null, true, null);
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
         /// Gets the total number of records in the PBilllog table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, int? billId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[PBilllog_GetRecordCountWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, billId, action, modifiedDate, modifiedUserId, isDeleted);

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
         /// Selects PBilllog records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<PBilllogModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[PBilllog_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects PBilllog records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<PBilllogModel> SelectSkipAndTakeDynamicWhere(int? id, int? billId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted, string sortByExpression, int startRowIndex, int rows)
         {
            List<PBilllogModel> objPBilllogCol = null;
              string storedProcName = "[dbo].[PBilllog_SelectSkipAndTakeWhereDynamic]";

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
                      AddSearchCommandParamsShared(command, id, billId, action, modifiedDate, modifiedUserId, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPBilllogCol = new List<PBilllogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PBilllogModel objPBilllog = CreatePBilllogFromDataRowShared(dr);
                                      objPBilllogCol.Add(objPBilllog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPBilllogCol;
         }

         /// <summary>
         /// Selects all PBilllog
         /// </summary>
         public static List<PBilllogModel> SelectAll()
         {
             return SelectShared("[dbo].[PBilllog_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PBilllog.
         /// </summary>
         public static List<PBilllogModel> SelectAllDynamicWhere(int? id, int? billId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
            List<PBilllogModel> objPBilllogCol = null;
              string storedProcName = "[dbo].[PBilllog_SelectAllWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, billId, action, modifiedDate, modifiedUserId, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPBilllogCol = new List<PBilllogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PBilllogModel objPBilllog = CreatePBilllogFromDataRowShared(dr);
                                      objPBilllogCol.Add(objPBilllog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPBilllogCol;
         }

         /// <summary>
         /// Selects Id and BillId columns for use with a DropDownList web control
         /// </summary>
         public static List<PBilllogModel> SelectPBilllogDropDownListData()
         {
            List<PBilllogModel> objPBilllogCol = null;
              string storedProcName = "[dbo].[PBilllog_SelectDropDownListData]";

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
                                  objPBilllogCol = new List<PBilllogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PBilllogModel objPBilllog = new PBilllogModel();
                                      objPBilllog.Id = (int)dr["Id"];

                                      if (dr["BillId"] != System.DBNull.Value)
                                          objPBilllog.BillId = (int)(dr["BillId"]);
                                      else
                                          objPBilllog.BillId = null;

                                      objPBilllogCol.Add(objPBilllog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPBilllogCol;
         }

         public static List<PBilllogModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<PBilllogModel> objPBilllogCol = null;

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
                                  objPBilllogCol = new List<PBilllogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PBilllogModel objPBilllog = CreatePBilllogFromDataRowShared(dr);
                                      objPBilllogCol.Add(objPBilllog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPBilllogCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(PBilllogModel objPBilllog)
         {
             string storedProcName = "[dbo].[PBilllog_Insert]";
             return InsertUpdate(objPBilllog, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(PBilllogModel objPBilllog)
         {
             string storedProcName = "[dbo].[PBilllog_Update]";
             InsertUpdate(objPBilllog, true, storedProcName);
         }

         private static int InsertUpdate(PBilllogModel objPBilllog, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objPBilllog.Id;

              object billId = objPBilllog.BillId;
              object action = objPBilllog.Action;
              object modifiedDate = objPBilllog.ModifiedDate;
              object modifiedUserId = objPBilllog.ModifiedUserId;

              if (objPBilllog.BillId == null)
                  billId = System.DBNull.Value;

              if (objPBilllog.Action == null)
                  action = System.DBNull.Value;

              if (objPBilllog.ModifiedDate == null)
                  modifiedDate = System.DBNull.Value;

              if (objPBilllog.ModifiedUserId == null)
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
                          command.Parameters.AddWithValue("@id", objPBilllog.Id);
                      }

                      command.Parameters.AddWithValue("@billId", billId);
                      command.Parameters.AddWithValue("@action", action);
                      command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                      command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                      command.Parameters.AddWithValue("@isDeleted", objPBilllog.IsDeleted);

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
              string storedProcName = "[dbo].[PBilllog_Delete]";

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, int? billId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(billId != null)
                  command.Parameters.AddWithValue("@billId", billId);
              else
                  command.Parameters.AddWithValue("@billId", System.DBNull.Value);

              if(action != null)
                  command.Parameters.AddWithValue("@action", action);
              else
                  command.Parameters.AddWithValue("@action", System.DBNull.Value);

              if(modifiedDate != null)
                  command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
              else
                  command.Parameters.AddWithValue("@modifiedDate", System.DBNull.Value);

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
         /// Creates a PBilllog object from the passed data row
         /// </summary>
         private static PBilllogModel CreatePBilllogFromDataRowShared(DataRow dr)
         {
             PBilllogModel objPBilllog = new PBilllogModel();

             objPBilllog.Id = (int)dr["Id"];

             if (dr["BillId"] != System.DBNull.Value)
                 objPBilllog.BillId = (int)dr["BillId"];
             else
                 objPBilllog.BillId = null;

             if (dr["Action"] != System.DBNull.Value)
                 objPBilllog.Action = (int)dr["Action"];
             else
                 objPBilllog.Action = null;

             if (dr["ModifiedDate"] != System.DBNull.Value)
                 objPBilllog.ModifiedDate = (DateTime)dr["ModifiedDate"];
             else
                 objPBilllog.ModifiedDate = null;

             if (dr["ModifiedUserId"] != System.DBNull.Value)
                 objPBilllog.ModifiedUserId = (int)dr["ModifiedUserId"];
             else
                 objPBilllog.ModifiedUserId = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objPBilllog.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objPBilllog.IsDeleted = false;

             return objPBilllog;
         }
     }
}
