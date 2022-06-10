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
     /// Base class for PCustomerDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the PCustomerDataLayer class
     /// </summary>
     public class PCustomerDataLayerBase
     {
         // constructor
         public PCustomerDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PCustomerModel SelectByPrimaryKey(int id)
         {
              PCustomerModel objPCustomer = null;
              string storedProcName = "[dbo].[PCustomer_SelectByPrimaryKey]";

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
                                  objPCustomer = CreatePCustomerFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objPCustomer;
         }

         /// <summary>
         /// Gets the total number of records in the PCustomer table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[PCustomer_GetRecordCount]", null, null, true, null);
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
         /// Gets the total number of records in the PCustomer table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string name, string code, DateTime? birth, string address, string phone, string email, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[PCustomer_GetRecordCountWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, name, code, birth, address, phone, email, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

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
         /// Selects PCustomer records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<PCustomerModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[PCustomer_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects PCustomer records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<PCustomerModel> SelectSkipAndTakeDynamicWhere(int? id, string name, string code, DateTime? birth, string address, string phone, string email, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string sortByExpression, int startRowIndex, int rows)
         {
            List<PCustomerModel> objPCustomerCol = null;
              string storedProcName = "[dbo].[PCustomer_SelectSkipAndTakeWhereDynamic]";

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
                      AddSearchCommandParamsShared(command, id, name, code, birth, address, phone, email, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPCustomerCol = new List<PCustomerModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PCustomerModel objPCustomer = CreatePCustomerFromDataRowShared(dr);
                                      objPCustomerCol.Add(objPCustomer);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPCustomerCol;
         }

         /// <summary>
         /// Selects all PCustomer
         /// </summary>
         public static List<PCustomerModel> SelectAll()
         {
             return SelectShared("[dbo].[PCustomer_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PCustomer.
         /// </summary>
         public static List<PCustomerModel> SelectAllDynamicWhere(int? id, string name, string code, DateTime? birth, string address, string phone, string email, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
            List<PCustomerModel> objPCustomerCol = null;
              string storedProcName = "[dbo].[PCustomer_SelectAllWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, name, code, birth, address, phone, email, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objPCustomerCol = new List<PCustomerModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PCustomerModel objPCustomer = CreatePCustomerFromDataRowShared(dr);
                                      objPCustomerCol.Add(objPCustomer);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPCustomerCol;
         }

         /// <summary>
         /// Selects Id and Name columns for use with a DropDownList web control
         /// </summary>
         public static List<PCustomerModel> SelectPCustomerDropDownListData()
         {
            List<PCustomerModel> objPCustomerCol = null;
              string storedProcName = "[dbo].[PCustomer_SelectDropDownListData]";

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
                                  objPCustomerCol = new List<PCustomerModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PCustomerModel objPCustomer = new PCustomerModel();
                                      objPCustomer.Id = (int)dr["Id"];

                                      if (dr["Name"] != System.DBNull.Value)
                                          objPCustomer.Name = (string)(dr["Name"]);
                                      else
                                          objPCustomer.Name = null;

                                      objPCustomerCol.Add(objPCustomer);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPCustomerCol;
         }

         public static List<PCustomerModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
            List<PCustomerModel> objPCustomerCol = null;

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
                                  objPCustomerCol = new List<PCustomerModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      PCustomerModel objPCustomer = CreatePCustomerFromDataRowShared(dr);
                                      objPCustomerCol.Add(objPCustomer);
                                  }
                              }
                          }
                      }
                  }
              }

              return objPCustomerCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(PCustomerModel objPCustomer)
         {
             string storedProcName = "[dbo].[PCustomer_Insert]";
             return InsertUpdate(objPCustomer, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(PCustomerModel objPCustomer)
         {
             string storedProcName = "[dbo].[PCustomer_Update]";
             InsertUpdate(objPCustomer, true, storedProcName);
         }

         private static int InsertUpdate(PCustomerModel objPCustomer, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objPCustomer.Id;

              object name = objPCustomer.Name;
              object code = objPCustomer.Code;
              object birth = objPCustomer.Birth;
              object address = objPCustomer.Address;
              object phone = objPCustomer.Phone;
              object email = objPCustomer.Email;
              object createdDate = objPCustomer.CreatedDate;
              object modifiedDate = objPCustomer.ModifiedDate;
              object createdUserId = objPCustomer.CreatedUserId;
              object modifiedUserId = objPCustomer.ModifiedUserId;
              object status = objPCustomer.Status;

              if (String.IsNullOrEmpty(objPCustomer.Name))
                  name = System.DBNull.Value;

              if (String.IsNullOrEmpty(objPCustomer.Code))
                  code = System.DBNull.Value;

              if (objPCustomer.Birth == null)
                  birth = System.DBNull.Value;

              if (String.IsNullOrEmpty(objPCustomer.Address))
                  address = System.DBNull.Value;

              if (String.IsNullOrEmpty(objPCustomer.Phone))
                  phone = System.DBNull.Value;

              if (String.IsNullOrEmpty(objPCustomer.Email))
                  email = System.DBNull.Value;

              if (objPCustomer.CreatedDate == null)
                  createdDate = System.DBNull.Value;

              if (objPCustomer.ModifiedDate == null)
                  modifiedDate = System.DBNull.Value;

              if (objPCustomer.CreatedUserId == null)
                  createdUserId = System.DBNull.Value;

              if (objPCustomer.ModifiedUserId == null)
                  modifiedUserId = System.DBNull.Value;

              if (objPCustomer.Status == null)
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
                          command.Parameters.AddWithValue("@id", objPCustomer.Id);
                      }

                      command.Parameters.AddWithValue("@name", name);
                      command.Parameters.AddWithValue("@code", code);
                      command.Parameters.AddWithValue("@birth", birth);
                      command.Parameters.AddWithValue("@address", address);
                      command.Parameters.AddWithValue("@phone", phone);
                      command.Parameters.AddWithValue("@email", email);
                      command.Parameters.AddWithValue("@createdDate", createdDate);
                      command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                      command.Parameters.AddWithValue("@createdUserId", createdUserId);
                      command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                      command.Parameters.AddWithValue("@isDeleted", objPCustomer.IsDeleted);
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
              string storedProcName = "[dbo].[PCustomer_Delete]";

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, string name, string code, DateTime? birth, string address, string phone, string email, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(!String.IsNullOrEmpty(name))
                  command.Parameters.AddWithValue("@name", name);
              else
                  command.Parameters.AddWithValue("@name", System.DBNull.Value);

              if(!String.IsNullOrEmpty(code))
                  command.Parameters.AddWithValue("@code", code);
              else
                  command.Parameters.AddWithValue("@code", System.DBNull.Value);

              if(birth != null)
                  command.Parameters.AddWithValue("@birth", birth);
              else
                  command.Parameters.AddWithValue("@birth", System.DBNull.Value);

              if(!String.IsNullOrEmpty(address))
                  command.Parameters.AddWithValue("@address", address);
              else
                  command.Parameters.AddWithValue("@address", System.DBNull.Value);

              if(!String.IsNullOrEmpty(phone))
                  command.Parameters.AddWithValue("@phone", phone);
              else
                  command.Parameters.AddWithValue("@phone", System.DBNull.Value);

              if(!String.IsNullOrEmpty(email))
                  command.Parameters.AddWithValue("@email", email);
              else
                  command.Parameters.AddWithValue("@email", System.DBNull.Value);

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
         /// Creates a PCustomer object from the passed data row
         /// </summary>
         private static PCustomerModel CreatePCustomerFromDataRowShared(DataRow dr)
         {
             PCustomerModel objPCustomer = new PCustomerModel();

             objPCustomer.Id = (int)dr["Id"];

             if (dr["Name"] != System.DBNull.Value)
                 objPCustomer.Name = dr["Name"].ToString();
             else
                 objPCustomer.Name = null;

             if (dr["Code"] != System.DBNull.Value)
                 objPCustomer.Code = dr["Code"].ToString();
             else
                 objPCustomer.Code = null;

             if (dr["Birth"] != System.DBNull.Value)
                 objPCustomer.Birth = (DateTime)dr["Birth"];
             else
                 objPCustomer.Birth = null;

             if (dr["Address"] != System.DBNull.Value)
                 objPCustomer.Address = dr["Address"].ToString();
             else
                 objPCustomer.Address = null;

             if (dr["Phone"] != System.DBNull.Value)
                 objPCustomer.Phone = dr["Phone"].ToString();
             else
                 objPCustomer.Phone = null;

             if (dr["Email"] != System.DBNull.Value)
                 objPCustomer.Email = dr["Email"].ToString();
             else
                 objPCustomer.Email = null;

             if (dr["CreatedDate"] != System.DBNull.Value)
                 objPCustomer.CreatedDate = (DateTime)dr["CreatedDate"];
             else
                 objPCustomer.CreatedDate = null;

             if (dr["ModifiedDate"] != System.DBNull.Value)
                 objPCustomer.ModifiedDate = (DateTime)dr["ModifiedDate"];
             else
                 objPCustomer.ModifiedDate = null;

             if (dr["CreatedUserId"] != System.DBNull.Value)
                 objPCustomer.CreatedUserId = (int)dr["CreatedUserId"];
             else
                 objPCustomer.CreatedUserId = null;

             if (dr["ModifiedUserId"] != System.DBNull.Value)
                 objPCustomer.ModifiedUserId = (int)dr["ModifiedUserId"];
             else
                 objPCustomer.ModifiedUserId = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objPCustomer.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objPCustomer.IsDeleted = false;

             if (dr["Status"] != System.DBNull.Value)
                 objPCustomer.Status = (int)dr["Status"];
             else
                 objPCustomer.Status = null;

             return objPCustomer;
         }
     }
}
