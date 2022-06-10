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
     /// Base class for PManufacturerDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the PManufacturerDataLayer class
     /// </summary>
     public class PManufacturerDataLayerBase
     {
         // constructor
         public PManufacturerDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PManufacturerModel SelectByPrimaryKey(int id)
         {
              PManufacturerModel objPManufacturer = null;
              string storedProcName = "[dbo].[PManufacturer_SelectByPrimaryKey]";

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
                                  objPManufacturer = CreatePManufacturerFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objPManufacturer;
         }

         /// <summary>
         /// Gets the total number of records in the PManufacturer table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[PManufacturer_GetRecordCount]", null, null, true, null);
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
         /// Gets the total number of records in the PManufacturer table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string name, string address, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[PManufacturer_GetRecordCountWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, name, address, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

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
         /// Selects PManufacturer records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<PManufacturerModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[PManufacturer_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects PManufacturer records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<PManufacturerModel> SelectSkipAndTakeDynamicWhere(int? id, string name, string address, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string sortByExpression, int startRowIndex, int rows)
         {
            List<PManufacturerModel> objPManufacturerCol = null;
              string storedProcName = "[dbo].[PManufacturer_SelectSkipAndTakeWhereDynamic]";

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
                      AddSearchCommandParamsShared(command, id, name, address, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPManufacturerCol = new List<PManufacturerModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PManufacturerModel objPManufacturer = CreatePManufacturerFromDataRowShared(dr);
                                      objPManufacturerCol.Add(objPManufacturer);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPManufacturerCol;
         }

         /// <summary>
         /// Selects all PManufacturer
         /// </summary>
         public static List<PManufacturerModel> SelectAll()
         {
             return SelectShared("[dbo].[PManufacturer_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PManufacturer.
         /// </summary>
         public static List<PManufacturerModel> SelectAllDynamicWhere(int? id, string name, string address, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
            List<PManufacturerModel> objPManufacturerCol = null;
              string storedProcName = "[dbo].[PManufacturer_SelectAllWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, name, address, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPManufacturerCol = new List<PManufacturerModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PManufacturerModel objPManufacturer = CreatePManufacturerFromDataRowShared(dr);
                                      objPManufacturerCol.Add(objPManufacturer);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPManufacturerCol;
         }

         /// <summary>
         /// Selects Id and Name columns for use with a DropDownList web control
         /// </summary>
         public static List<PManufacturerModel> SelectPManufacturerDropDownListData()
         {
            List<PManufacturerModel> objPManufacturerCol = null;
              string storedProcName = "[dbo].[PManufacturer_SelectDropDownListData]";

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
                                  objPManufacturerCol = new List<PManufacturerModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PManufacturerModel objPManufacturer = new PManufacturerModel();
                                      objPManufacturer.Id = (int)dr["Id"];

                                      if (dr["Name"] != System.DBNull.Value)
                                          objPManufacturer.Name = (string)(dr["Name"]);
                                      else
                                          objPManufacturer.Name = null;

                                      objPManufacturerCol.Add(objPManufacturer);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPManufacturerCol;
         }

         public static List<PManufacturerModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<PManufacturerModel> objPManufacturerCol = null;

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
                                  objPManufacturerCol = new List<PManufacturerModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PManufacturerModel objPManufacturer = CreatePManufacturerFromDataRowShared(dr);
                                      objPManufacturerCol.Add(objPManufacturer);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPManufacturerCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(PManufacturerModel objPManufacturer)
         {
             string storedProcName = "[dbo].[PManufacturer_Insert]";
             return InsertUpdate(objPManufacturer, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(PManufacturerModel objPManufacturer)
         {
             string storedProcName = "[dbo].[PManufacturer_Update]";
             InsertUpdate(objPManufacturer, true, storedProcName);
         }

         private static int InsertUpdate(PManufacturerModel objPManufacturer, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objPManufacturer.Id;

              object name = objPManufacturer.Name;
              object address = objPManufacturer.Address;
              object createdDate = objPManufacturer.CreatedDate;
              object modifiedDate = objPManufacturer.ModifiedDate;
              object createdUserId = objPManufacturer.CreatedUserId;
              object modifiedUserId = objPManufacturer.ModifiedUserId;
              object status = objPManufacturer.Status;

              if (String.IsNullOrEmpty(objPManufacturer.Name))
                  name = System.DBNull.Value;

              if (String.IsNullOrEmpty(objPManufacturer.Address))
                  address = System.DBNull.Value;

              if (objPManufacturer.CreatedDate == null)
                  createdDate = System.DBNull.Value;

              if (objPManufacturer.ModifiedDate == null)
                  modifiedDate = System.DBNull.Value;

              if (objPManufacturer.CreatedUserId == null)
                  createdUserId = System.DBNull.Value;

              if (objPManufacturer.ModifiedUserId == null)
                  modifiedUserId = System.DBNull.Value;

              if (objPManufacturer.Status == null)
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
                          command.Parameters.AddWithValue("@id", objPManufacturer.Id);
                      }

                      command.Parameters.AddWithValue("@name", name);
                      command.Parameters.AddWithValue("@address", address);
                      command.Parameters.AddWithValue("@createdDate", createdDate);
                      command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                      command.Parameters.AddWithValue("@createdUserId", createdUserId);
                      command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                      command.Parameters.AddWithValue("@isDeleted", objPManufacturer.IsDeleted);
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
              string storedProcName = "[dbo].[PManufacturer_Delete]";

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, string name, string address, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(!String.IsNullOrEmpty(name))
                  command.Parameters.AddWithValue("@name", name);
              else
                  command.Parameters.AddWithValue("@name", System.DBNull.Value);

              if(!String.IsNullOrEmpty(address))
                  command.Parameters.AddWithValue("@address", address);
              else
                  command.Parameters.AddWithValue("@address", System.DBNull.Value);

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
         /// Creates a PManufacturer object from the passed data row
         /// </summary>
         private static PManufacturerModel CreatePManufacturerFromDataRowShared(DataRow dr)
         {
             PManufacturerModel objPManufacturer = new PManufacturerModel();

             objPManufacturer.Id = (int)dr["Id"];

             if (dr["Name"] != System.DBNull.Value)
                 objPManufacturer.Name = dr["Name"].ToString();
             else
                 objPManufacturer.Name = null;

             if (dr["Address"] != System.DBNull.Value)
                 objPManufacturer.Address = dr["Address"].ToString();
             else
                 objPManufacturer.Address = null;

             if (dr["CreatedDate"] != System.DBNull.Value)
                 objPManufacturer.CreatedDate = (DateTime)dr["CreatedDate"];
             else
                 objPManufacturer.CreatedDate = null;

             if (dr["ModifiedDate"] != System.DBNull.Value)
                 objPManufacturer.ModifiedDate = (DateTime)dr["ModifiedDate"];
             else
                 objPManufacturer.ModifiedDate = null;

             if (dr["CreatedUserId"] != System.DBNull.Value)
                 objPManufacturer.CreatedUserId = (int)dr["CreatedUserId"];
             else
                 objPManufacturer.CreatedUserId = null;

             if (dr["ModifiedUserId"] != System.DBNull.Value)
                 objPManufacturer.ModifiedUserId = (int)dr["ModifiedUserId"];
             else
                 objPManufacturer.ModifiedUserId = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objPManufacturer.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objPManufacturer.IsDeleted = false;

             if (dr["Status"] != System.DBNull.Value)
                 objPManufacturer.Status = (int)dr["Status"];
             else
                 objPManufacturer.Status = null;

             return objPManufacturer;
         }
     }
}
