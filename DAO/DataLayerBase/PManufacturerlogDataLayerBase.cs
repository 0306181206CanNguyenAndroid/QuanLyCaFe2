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
     /// Base class for PManufacturerlogDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the PManufacturerlogDataLayer class
     /// </summary>
     public class PManufacturerlogDataLayerBase
     {
         // constructor
         public PManufacturerlogDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PManufacturerlogModel SelectByPrimaryKey(int id)
         {
              PManufacturerlogModel objPManufacturerlog = null;
              string storedProcName = "[dbo].[PManufacturerlog_SelectByPrimaryKey]";

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
                                  objPManufacturerlog = CreatePManufacturerlogFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objPManufacturerlog;
         }

         /// <summary>
         /// Gets the total number of records in the PManufacturerlog table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[PManufacturerlog_GetRecordCount]", null, null, true, null);
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
         /// Gets the total number of records in the PManufacturerlog table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string note, int? manuId, int? action, DateTime? createdDate, int? createdUserId, bool? isDeleted)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[PManufacturerlog_GetRecordCountWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, note, manuId, action, createdDate, createdUserId, isDeleted);

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
         /// Selects PManufacturerlog records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<PManufacturerlogModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[PManufacturerlog_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects PManufacturerlog records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<PManufacturerlogModel> SelectSkipAndTakeDynamicWhere(int? id, string note, int? manuId, int? action, DateTime? createdDate, int? createdUserId, bool? isDeleted, string sortByExpression, int startRowIndex, int rows)
         {
            List<PManufacturerlogModel> objPManufacturerlogCol = null;
              string storedProcName = "[dbo].[PManufacturerlog_SelectSkipAndTakeWhereDynamic]";

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
                      AddSearchCommandParamsShared(command, id, note, manuId, action, createdDate, createdUserId, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPManufacturerlogCol = new List<PManufacturerlogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PManufacturerlogModel objPManufacturerlog = CreatePManufacturerlogFromDataRowShared(dr);
                                      objPManufacturerlogCol.Add(objPManufacturerlog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPManufacturerlogCol;
         }

         /// <summary>
         /// Selects all PManufacturerlog
         /// </summary>
         public static List<PManufacturerlogModel> SelectAll()
         {
             return SelectShared("[dbo].[PManufacturerlog_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PManufacturerlog.
         /// </summary>
         public static List<PManufacturerlogModel> SelectAllDynamicWhere(int? id, string note, int? manuId, int? action, DateTime? createdDate, int? createdUserId, bool? isDeleted)
         {
            List<PManufacturerlogModel> objPManufacturerlogCol = null;
              string storedProcName = "[dbo].[PManufacturerlog_SelectAllWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, note, manuId, action, createdDate, createdUserId, isDeleted);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPManufacturerlogCol = new List<PManufacturerlogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PManufacturerlogModel objPManufacturerlog = CreatePManufacturerlogFromDataRowShared(dr);
                                      objPManufacturerlogCol.Add(objPManufacturerlog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPManufacturerlogCol;
         }

         /// <summary>
         /// Selects Id and Note columns for use with a DropDownList web control
         /// </summary>
         public static List<PManufacturerlogModel> SelectPManufacturerlogDropDownListData()
         {
            List<PManufacturerlogModel> objPManufacturerlogCol = null;
              string storedProcName = "[dbo].[PManufacturerlog_SelectDropDownListData]";

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
                                  objPManufacturerlogCol = new List<PManufacturerlogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PManufacturerlogModel objPManufacturerlog = new PManufacturerlogModel();
                                      objPManufacturerlog.Id = (int)dr["Id"];

                                      if (dr["Note"] != System.DBNull.Value)
                                          objPManufacturerlog.Note = (string)(dr["Note"]);
                                      else
                                          objPManufacturerlog.Note = null;

                                      objPManufacturerlogCol.Add(objPManufacturerlog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPManufacturerlogCol;
         }

         public static List<PManufacturerlogModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<PManufacturerlogModel> objPManufacturerlogCol = null;

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
                                  objPManufacturerlogCol = new List<PManufacturerlogModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PManufacturerlogModel objPManufacturerlog = CreatePManufacturerlogFromDataRowShared(dr);
                                      objPManufacturerlogCol.Add(objPManufacturerlog);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPManufacturerlogCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(PManufacturerlogModel objPManufacturerlog)
         {
             string storedProcName = "[dbo].[PManufacturerlog_Insert]";
             return InsertUpdate(objPManufacturerlog, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(PManufacturerlogModel objPManufacturerlog)
         {
             string storedProcName = "[dbo].[PManufacturerlog_Update]";
             InsertUpdate(objPManufacturerlog, true, storedProcName);
         }

         private static int InsertUpdate(PManufacturerlogModel objPManufacturerlog, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objPManufacturerlog.Id;

              object note = objPManufacturerlog.Note;
              object manuId = objPManufacturerlog.ManuId;
              object action = objPManufacturerlog.Action;
              object createdDate = objPManufacturerlog.CreatedDate;
              object createdUserId = objPManufacturerlog.CreatedUserId;

              if (String.IsNullOrEmpty(objPManufacturerlog.Note))
                  note = System.DBNull.Value;

              if (objPManufacturerlog.ManuId == null)
                  manuId = System.DBNull.Value;

              if (objPManufacturerlog.Action == null)
                  action = System.DBNull.Value;

              if (objPManufacturerlog.CreatedDate == null)
                  createdDate = System.DBNull.Value;

              if (objPManufacturerlog.CreatedUserId == null)
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
                          command.Parameters.AddWithValue("@id", objPManufacturerlog.Id);
                      }

                      command.Parameters.AddWithValue("@note", note);
                      command.Parameters.AddWithValue("@manuId", manuId);
                      command.Parameters.AddWithValue("@action", action);
                      command.Parameters.AddWithValue("@createdDate", createdDate);
                      command.Parameters.AddWithValue("@createdUserId", createdUserId);
                      command.Parameters.AddWithValue("@isDeleted", objPManufacturerlog.IsDeleted);

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
              string storedProcName = "[dbo].[PManufacturerlog_Delete]";

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, string note, int? manuId, int? action, DateTime? createdDate, int? createdUserId, bool? isDeleted)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(!String.IsNullOrEmpty(note))
                  command.Parameters.AddWithValue("@note", note);
              else
                  command.Parameters.AddWithValue("@note", System.DBNull.Value);

              if(manuId != null)
                  command.Parameters.AddWithValue("@manuId", manuId);
              else
                  command.Parameters.AddWithValue("@manuId", System.DBNull.Value);

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
         /// Creates a PManufacturerlog object from the passed data row
         /// </summary>
         private static PManufacturerlogModel CreatePManufacturerlogFromDataRowShared(DataRow dr)
         {
             PManufacturerlogModel objPManufacturerlog = new PManufacturerlogModel();

             objPManufacturerlog.Id = (int)dr["Id"];

             if (dr["Note"] != System.DBNull.Value)
                 objPManufacturerlog.Note = dr["Note"].ToString();
             else
                 objPManufacturerlog.Note = null;

             if (dr["ManuId"] != System.DBNull.Value)
                 objPManufacturerlog.ManuId = (int)dr["ManuId"];
             else
                 objPManufacturerlog.ManuId = null;

             if (dr["Action"] != System.DBNull.Value)
                 objPManufacturerlog.Action = (int)dr["Action"];
             else
                 objPManufacturerlog.Action = null;

             if (dr["CreatedDate"] != System.DBNull.Value)
                 objPManufacturerlog.CreatedDate = (DateTime)dr["CreatedDate"];
             else
                 objPManufacturerlog.CreatedDate = null;

             if (dr["CreatedUserId"] != System.DBNull.Value)
                 objPManufacturerlog.CreatedUserId = (int)dr["CreatedUserId"];
             else
                 objPManufacturerlog.CreatedUserId = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objPManufacturerlog.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objPManufacturerlog.IsDeleted = false;

             return objPManufacturerlog;
         }
     }
}
