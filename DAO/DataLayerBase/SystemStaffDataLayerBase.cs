using DTO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.ModelsBase;

namespace DAO.DataLayerBase
{
     /// <summary>
     /// Base class for SystemStaffDataLayer.  Do not make changes to this class,
     /// instead, put additional code in the SystemStaffDataLayer class
     /// </summary>
     public class SystemStaffDataLayerBase
     {
         // constructor
         public SystemStaffDataLayerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static SystemStaffModel SelectByPrimaryKey(int id)
         {
              SystemStaffModel objSystemStaff = null;
              //string storedProcName = "[dbo].[SystemStaff_SelectByPrimaryKey]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(ProcString.procNameStaff_SelectByPrimaryKey, connection))
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
                                  objSystemStaff = CreateSystemStaffFromDataRowShared(dt.Rows[0]);
                              }
                          }
                      }
                  }
              }

              return objSystemStaff;
         }

         /// <summary>
         /// Gets the total number of records in the SystemStaff table
         /// </summary>
         public static int GetRecordCount()
         {
             return GetRecordCountShared("[dbo].[SystemStaff_GetRecordCount]", null, null, true, null);
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
         /// Gets the total number of records in the SystemStaff table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string firstName, string lastName, string fullName, DateTime? birth, string address, string image, string phone, string email, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, int? positionId, bool? isDeleted, int? status)
         {
              int recordCount = 0;
              string storedProcName = "[dbo].[SystemStaff_GetRecordCountWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, firstName, lastName, fullName, birth, address, image, phone, email, createdDate, modifiedDate, createdUserId, modifiedUserId, positionId, isDeleted, status);

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
         /// Selects SystemStaff records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
         /// </summary>
         public static List<SystemStaffModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
         {
             return SelectShared("[dbo].[SystemStaff_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects SystemStaff records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
         /// </summary>
         public static List<SystemStaffModel> SelectSkipAndTakeDynamicWhere(int? id, string firstName, string lastName, string fullName, DateTime? birth, string address, string image, string phone, string email, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, int? positionId, bool? isDeleted, int? status, string sortByExpression, int startRowIndex, int rows)
         {
            List<SystemStaffModel> objSystemStaffCol = null;
              string storedProcName = "[dbo].[SystemStaff_SelectSkipAndTakeWhereDynamic]";

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
                      AddSearchCommandParamsShared(command, id, firstName, lastName, fullName, birth, address, image, phone, email, createdDate, modifiedDate, createdUserId, modifiedUserId, positionId, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemStaffCol = new List<SystemStaffModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemStaffModel objSystemStaff = CreateSystemStaffFromDataRowShared(dr);
                                      objSystemStaffCol.Add(objSystemStaff);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemStaffCol;
         }

         /// <summary>
         /// Selects all SystemStaff
         /// </summary>
         public static List<SystemStaffModel> SelectAll()
         {
             return SelectShared("[dbo].[SystemStaff_SelectAll]", String.Empty, null);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemStaff.
         /// </summary>
         public static List<SystemStaffModel> SelectAllDynamicWhere(int? id, string firstName, string lastName, string fullName, DateTime? birth, string address, string image, string phone, string email, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, int? positionId, bool? isDeleted, int? status)
         {
            List<SystemStaffModel> objSystemStaffCol = null;
              string storedProcName = "[dbo].[SystemStaff_SelectAllWhereDynamic]";

              using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
              {
                  connection.Open();

                  using (SqlCommand command = new SqlCommand(storedProcName, connection))
                  {
                      command.CommandType = CommandType.StoredProcedure;

                      // search parameters
                      AddSearchCommandParamsShared(command, id, firstName, lastName, fullName, birth, address, image, phone, email, createdDate, modifiedDate, createdUserId, modifiedUserId, positionId, isDeleted, status);

                      using (SqlDataAdapter da = new SqlDataAdapter(command))
                      {
                          DataTable dt = new DataTable();
                          da.Fill(dt);

                          if (dt != null)
                          {
                              if (dt.Rows.Count > 0)
                              {
                                  objSystemStaffCol = new List<SystemStaffModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                    SystemStaffModel objSystemStaff = CreateSystemStaffFromDataRowShared(dr);
                                      objSystemStaffCol.Add(objSystemStaff);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemStaffCol;
         }

         /// <summary>
         /// Selects Id and FirstName columns for use with a DropDownList web control
         /// </summary>
         public static List<SystemStaffModel> SelectSystemStaffDropDownListData()
         {
            List<SystemStaffModel> objSystemStaffCol = null;
              string storedProcName = "[dbo].[SystemStaff_SelectDropDownListData]";

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
                                  objSystemStaffCol = new List<SystemStaffModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemStaffModel objSystemStaff = new SystemStaffModel();
                                      objSystemStaff.Id = (int)dr["Id"];

                                      if (dr["FirstName"] != System.DBNull.Value)
                                          objSystemStaff.FirstName = (string)(dr["FirstName"]);
                                      else
                                          objSystemStaff.FirstName = null;

                                      objSystemStaffCol.Add(objSystemStaff);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemStaffCol;
         }

         public static List<SystemStaffModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
         {
              List<SystemStaffModel> objSystemStaffCol = null;

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
                                  objSystemStaffCol = new List<SystemStaffModel>();

                                  foreach (DataRow dr in dt.Rows)
                                  {
                                      SystemStaffModel objSystemStaff = CreateSystemStaffFromDataRowShared(dr);
                                      objSystemStaffCol.Add(objSystemStaff);
                                  }
                              }
                          }
                      }
                  }
              }

              return objSystemStaffCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(SystemStaffModel objSystemStaff)
         {
             string storedProcName = "[dbo].[SystemStaff_Insert]";
             return InsertUpdate(objSystemStaff, false, storedProcName);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public static void Update(SystemStaffModel objSystemStaff)
         {
             string storedProcName = "[dbo].[SystemStaff_Update]";
             InsertUpdate(objSystemStaff, true, storedProcName);
         }

         private static int InsertUpdate(SystemStaffModel objSystemStaff, bool isUpdate, string storedProcName)
         {
              int newlyCreatedId = objSystemStaff.Id;

              object firstName = objSystemStaff.FirstName;
              object lastName = objSystemStaff.LastName;
              object fullName = objSystemStaff.FullName;
              object birth = objSystemStaff.Birth;
              object address = objSystemStaff.Address;
              object image = objSystemStaff.Image;
              object phone = objSystemStaff.Phone;
              object email = objSystemStaff.Email;
              object createdDate = objSystemStaff.CreatedDate;
              object modifiedDate = objSystemStaff.ModifiedDate;
              object createdUserId = objSystemStaff.CreatedUserId;
              object modifiedUserId = objSystemStaff.ModifiedUserId;
              object positionId = objSystemStaff.PositionId;
              object status = objSystemStaff.Status;

              if (String.IsNullOrEmpty(objSystemStaff.FirstName))
                  firstName = System.DBNull.Value;

              if (String.IsNullOrEmpty(objSystemStaff.LastName))
                  lastName = System.DBNull.Value;

              if (String.IsNullOrEmpty(objSystemStaff.FullName))
                  fullName = System.DBNull.Value;

              if (objSystemStaff.Birth == null)
                  birth = System.DBNull.Value;

              if (String.IsNullOrEmpty(objSystemStaff.Address))
                  address = System.DBNull.Value;

              if (String.IsNullOrEmpty(objSystemStaff.Image))
                  image = System.DBNull.Value;

              if (String.IsNullOrEmpty(objSystemStaff.Phone))
                  phone = System.DBNull.Value;

              if (String.IsNullOrEmpty(objSystemStaff.Email))
                  email = System.DBNull.Value;

              if (objSystemStaff.CreatedDate == null)
                  createdDate = System.DBNull.Value;

              if (objSystemStaff.ModifiedDate == null)
                  modifiedDate = System.DBNull.Value;

              if (objSystemStaff.CreatedUserId == null)
                  createdUserId = System.DBNull.Value;

              if (objSystemStaff.ModifiedUserId == null)
                  modifiedUserId = System.DBNull.Value;

              if (objSystemStaff.PositionId == null)
                  positionId = System.DBNull.Value;

              if (objSystemStaff.Status == null)
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
                          command.Parameters.AddWithValue("@id", objSystemStaff.Id);
                      }

                      command.Parameters.AddWithValue("@firstName", firstName);
                      command.Parameters.AddWithValue("@lastName", lastName);
                      command.Parameters.AddWithValue("@fullName", fullName);
                      command.Parameters.AddWithValue("@birth", birth);
                      command.Parameters.AddWithValue("@address", address);
                      command.Parameters.AddWithValue("@image", image);
                      command.Parameters.AddWithValue("@phone", phone);
                      command.Parameters.AddWithValue("@email", email);
                      command.Parameters.AddWithValue("@createdDate", createdDate);
                      command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                      command.Parameters.AddWithValue("@createdUserId", createdUserId);
                      command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                      command.Parameters.AddWithValue("@positionId", positionId);
                      command.Parameters.AddWithValue("@isDeleted", objSystemStaff.IsDeleted);
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
              string storedProcName = "[dbo].[SystemStaff_Delete]";

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
         private static void AddSearchCommandParamsShared(SqlCommand command, int? id, string firstName, string lastName, string fullName, DateTime? birth, string address, string image, string phone, string email, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, int? positionId, bool? isDeleted, int? status)
         {
              if(id != null)
                  command.Parameters.AddWithValue("@id", id);
              else
                  command.Parameters.AddWithValue("@id", System.DBNull.Value);

              if(!String.IsNullOrEmpty(firstName))
                  command.Parameters.AddWithValue("@firstName", firstName);
              else
                  command.Parameters.AddWithValue("@firstName", System.DBNull.Value);

              if(!String.IsNullOrEmpty(lastName))
                  command.Parameters.AddWithValue("@lastName", lastName);
              else
                  command.Parameters.AddWithValue("@lastName", System.DBNull.Value);

              if(!String.IsNullOrEmpty(fullName))
                  command.Parameters.AddWithValue("@fullName", fullName);
              else
                  command.Parameters.AddWithValue("@fullName", System.DBNull.Value);

              if(birth != null)
                  command.Parameters.AddWithValue("@birth", birth);
              else
                  command.Parameters.AddWithValue("@birth", System.DBNull.Value);

              if(!String.IsNullOrEmpty(address))
                  command.Parameters.AddWithValue("@address", address);
              else
                  command.Parameters.AddWithValue("@address", System.DBNull.Value);

              if(!String.IsNullOrEmpty(image))
                  command.Parameters.AddWithValue("@image", image);
              else
                  command.Parameters.AddWithValue("@image", System.DBNull.Value);

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

              if(positionId != null)
                  command.Parameters.AddWithValue("@positionId", positionId);
              else
                  command.Parameters.AddWithValue("@positionId", System.DBNull.Value);

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
         /// Creates a SystemStaff object from the passed data row
         /// </summary>
         private static SystemStaffModel CreateSystemStaffFromDataRowShared(DataRow dr)
         {
             SystemStaffModel objSystemStaff = new SystemStaffModel();

             objSystemStaff.Id = (int)dr["Id"];

             if (dr["FirstName"] != System.DBNull.Value)
                 objSystemStaff.FirstName = dr["FirstName"].ToString();
             else
                 objSystemStaff.FirstName = null;

             if (dr["LastName"] != System.DBNull.Value)
                 objSystemStaff.LastName = dr["LastName"].ToString();
             else
                 objSystemStaff.LastName = null;

             if (dr["FullName"] != System.DBNull.Value)
                 objSystemStaff.FullName = dr["FullName"].ToString();
             else
                 objSystemStaff.FullName = null;

             if (dr["Birth"] != System.DBNull.Value)
                 objSystemStaff.Birth = (DateTime)dr["Birth"];
             else
                 objSystemStaff.Birth = null;

             if (dr["Address"] != System.DBNull.Value)
                 objSystemStaff.Address = dr["Address"].ToString();
             else
                 objSystemStaff.Address = null;

             if (dr["Image"] != System.DBNull.Value)
                 objSystemStaff.Image = dr["Image"].ToString();
             else
                 objSystemStaff.Image = null;

             if (dr["Phone"] != System.DBNull.Value)
                 objSystemStaff.Phone = dr["Phone"].ToString();
             else
                 objSystemStaff.Phone = null;

             if (dr["Email"] != System.DBNull.Value)
                 objSystemStaff.Email = dr["Email"].ToString();
             else
                 objSystemStaff.Email = null;

             if (dr["CreatedDate"] != System.DBNull.Value)
                 objSystemStaff.CreatedDate = (DateTime)dr["CreatedDate"];
             else
                 objSystemStaff.CreatedDate = null;

             if (dr["ModifiedDate"] != System.DBNull.Value)
                 objSystemStaff.ModifiedDate = (DateTime)dr["ModifiedDate"];
             else
                 objSystemStaff.ModifiedDate = null;

             if (dr["CreatedUserId"] != System.DBNull.Value)
                 objSystemStaff.CreatedUserId = (int)dr["CreatedUserId"];
             else
                 objSystemStaff.CreatedUserId = null;

             if (dr["ModifiedUserId"] != System.DBNull.Value)
                 objSystemStaff.ModifiedUserId = (int)dr["ModifiedUserId"];
             else
                 objSystemStaff.ModifiedUserId = null;

             if (dr["PositionId"] != System.DBNull.Value)
                 objSystemStaff.PositionId = (int)dr["PositionId"];
             else
                 objSystemStaff.PositionId = null;
             if (dr["IsDeleted"] != System.DBNull.Value)
                 objSystemStaff.IsDeleted = (bool)dr["IsDeleted"];
             else
                 objSystemStaff.IsDeleted = false;

             if (dr["Status"] != System.DBNull.Value)
                 objSystemStaff.Status = (int)dr["Status"];
             else
                 objSystemStaff.Status = null;

             return objSystemStaff;
         }

        public DataTable LayDSNV()
        {
            string sql = @"select NV.Id,NV.FirstName as N'Ho',NV.FullName as N'Tên',NV.Birth as N'Ngay Sinh',NV.Address as N'Dia chi',NV.Phone as N'SÐT',CV.Name as N'Chuc vu'
                           from dbo.[System_Staff] as NV ,dbo.[System_Position] as CV
                           where NV.PositionId=CV.Id";
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

       public  static void ThemNV(SystemStaffModel nhanvien)
        {
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            SqlCommand cmd = new SqlCommand("S_Them_Nhanvien", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = nhanvien.Id;
            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = nhanvien.FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = nhanvien.LastName;
            cmd.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = nhanvien.FullName;
            cmd.Parameters.Add("@Birth", SqlDbType.DateTime).Value = nhanvien.Birth;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = nhanvien.Address;
            cmd.Parameters.Add("@Image", SqlDbType.NVarChar).Value = nhanvien.Image;
            cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = nhanvien.Address;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = nhanvien.Email;
            cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = nhanvien.CreatedDate;
            cmd.Parameters.Add("@ModifiedDate", SqlDbType.DateTime).Value = nhanvien.ModifiedDate;
            cmd.Parameters.Add("@CreatedUserId", SqlDbType.Int).Value = nhanvien.CreatedUserId;
            cmd.Parameters.Add("@ModifiedUserId", SqlDbType.Int).Value = nhanvien.ModifiedUserId;
            cmd.Parameters.Add("@PositionId", SqlDbType.Int).Value = nhanvien.PositionId;
            cmd.Parameters.Add("@IsDeleted", SqlDbType.Bit).Value = nhanvien.IsDeleted;
            cmd.Parameters.Add("@Status", SqlDbType.Int).Value = nhanvien.Status;
        }

    }
}
