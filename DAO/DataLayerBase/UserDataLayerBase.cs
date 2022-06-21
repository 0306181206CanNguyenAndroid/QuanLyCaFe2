using DTO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO.ModelsBase;
namespace DAO.DataLayerBase
{
    public class UserDataLayerBase
    {
        private static string GetMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");//Nếu là "X2" thì kết quả sẽ tự chuyển sang ký tự in Hoa
            }

            return str_md5;
        }
        public static List<UserModel> SelectAll()
        {
            List<UserModel> listUser = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("[dbo].[User_SelectAll]", connection))
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
                                    listUser = new List<UserModel>();

                                    foreach (DataRow dr in dt.Rows)
                                    {
                                        UserModel user = CreateUserModelFromDataRowShared(dr);
                                        listUser.Add(user);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return listUser;
        }

        public static List<UserModel> SelectAllDynamicWhere(int? Id, string username, string name, string image, bool? isdeleted, int? status, int? accessrightsgroup, DateTime? createddate, DateTime? modifieddate, int? createduserid, int? modifieduserid, string sort)
        {
            List<UserModel> listUser = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("[dbo].[User_SelectAllDynamicWhere]", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        AddParametersCommand(command, Id, username, name, image, isdeleted, status, accessrightsgroup, createddate, modifieddate, createduserid, modifieduserid, sort);

                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt != null)
                            {
                                if (dt.Rows.Count > 0)
                                {
                                    listUser = new List<UserModel>();

                                    foreach (DataRow dr in dt.Rows)
                                    {
                                        UserModel user = CreateUserModelFromDataRowShared(dr);
                                        listUser.Add(user);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return listUser;
        }

        protected static void AddParametersCommand(SqlCommand command, int? Id, string username, string name, string image, bool? isdeleted, int? status, int? accessrightsgroup, DateTime? createddate, DateTime? modifieddate, int? createduserid, int? modifieduserid, string sort)
        {
            if (Id != null)
                command.Parameters.AddWithValue("@Id", Id);
            else
                command.Parameters.AddWithValue("@Id", System.DBNull.Value);

            if (username != null)
                command.Parameters.AddWithValue("@username", username);
            else
                command.Parameters.AddWithValue("@username", System.DBNull.Value);

            if (name != null)
                command.Parameters.AddWithValue("@name", name);
            else
                command.Parameters.AddWithValue("@name", System.DBNull.Value);

            if (image != null)
                command.Parameters.AddWithValue("@image", image);
            else
                command.Parameters.AddWithValue("@image", System.DBNull.Value);

            if (accessrightsgroup != null)
                command.Parameters.AddWithValue("@accessrightsgroup", accessrightsgroup);
            else
                command.Parameters.AddWithValue("@accessrightsgroup", System.DBNull.Value);

            if (modifieduserid != null)
                command.Parameters.AddWithValue("@modifieduserid", modifieduserid);
            else
                command.Parameters.AddWithValue("@modifieduserid", System.DBNull.Value);

            if (createduserid != null)
                command.Parameters.AddWithValue("@createduserid", createduserid);
            else
                command.Parameters.AddWithValue("@createduserid", System.DBNull.Value);

            if (createddate != null)
                command.Parameters.AddWithValue("@createddate", createddate);
            else
                command.Parameters.AddWithValue("@createddate", System.DBNull.Value);

            if (modifieddate != null)
                command.Parameters.AddWithValue("@modifieddate", modifieddate);
            else
                command.Parameters.AddWithValue("@modifieddate", System.DBNull.Value);

            if (isdeleted != null)
                command.Parameters.AddWithValue("@isdeleted", isdeleted);
            else
                command.Parameters.AddWithValue("@isdeleted", System.DBNull.Value);

            if (status != null)
                command.Parameters.AddWithValue("@status", status);
            else
                command.Parameters.AddWithValue("@status", System.DBNull.Value);

            command.Parameters.AddWithValue("@sort", sort);
        }

        public static UserModel SelectByPrimaryKey(int Id)
        {
            UserModel user = null;
            string storeproc = "[dbo].[User_SelectByPrimaryKey]";

            try
            {
                using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storeproc, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Id", Id);

                        //if (Id != null)
                        //    command.Parameters.AddWithValue("@Id", Id);
                        //else
                        //    command.Parameters.AddWithValue("@Id", System.DBNull.Value);

                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt != null)
                            {
                                if (dt.Rows.Count > 0)
                                {
                                    user = CreateUserModelFromDataRowShared(dt.Rows[0]);
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return user;

        }

        public static UserModel SelectWithUserAndPass(string UserName, string pass)
        {
            UserModel user = null;
            string Pass = GetMD5(pass);
            string storeproc = "[dbo].[User_SelectWithUsernameAndPass]";

            try
            {
                using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(storeproc, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@userName", UserName);
                        command.Parameters.AddWithValue("@pass", Pass);


                        using (SqlDataAdapter da = new SqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt != null)
                            {
                                if (dt.Rows.Count > 0)
                                {
                                    user = CreateUserModelFromDataRowShared(dt.Rows[0]);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return new UserModel { Id = 0 };
            }

            return user;


        }

        /// <summary>
        /// Gets the total number of records in the SystemUser table
        /// </summary>
        public static int GetRecordCount()
        {
            return GetRecordCountShared("[dbo].[SystemUser_GetRecordCount]", null, null, true, null);
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
        /// Gets the total number of records in the SystemUser table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, string userName, string pass, string name, string image, int? accessRightsGroup, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
        {
            int recordCount = 0;
            string storedProcName = "[dbo].[SystemUser_GetRecordCountWhereDynamic]";

            using (SqlConnection connection = new SqlConnection(PathString.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(storedProcName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // search parameters
                    AddSearchCommandParamsShared(command, id, userName, pass, name, image, accessRightsGroup, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

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
        /// Selects SystemUser records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of rows)
        /// </summary>
        public static List<UserModel> SelectSkipAndTake(string sortByExpression, int startRowIndex, int rows)
        {
            return SelectShared("[dbo].[SystemUser_SelectSkipAndTake]", null, null, true, null, sortByExpression, startRowIndex, rows);
        }

        /// <summary>
        /// Selects SystemUser records sorted by the sortByExpression and returns records from the startRowIndex with rows (# of records) based on search parameters
        /// </summary>
        public static List<UserModel> SelectSkipAndTakeDynamicWhere(int? id, string userName, string pass, string name, string image, int? accessRightsGroup, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string sortByExpression, int startRowIndex, int rows)
        {
            List<UserModel> objSystemUserCol = null;
            string storedProcName = "[dbo].[SystemUser_SelectSkipAndTakeWhereDynamic]";

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
                    AddSearchCommandParamsShared(command, id, userName, pass, name, image, accessRightsGroup, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);

                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt != null)
                        {
                            if (dt.Rows.Count > 0)
                            {
                                objSystemUserCol = new List<UserModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    UserModel objSystemUser = CreateUserModelFromDataRowShared(dr);
                                    objSystemUserCol.Add(objSystemUser);
                                }
                            }
                        }
                    }
                }
            }

            return objSystemUserCol;
        }

        public static List<UserModel> SelectShared(string storedProcName, string param, object paramValue, bool isUseStoredProc = true, string dynamicSqlScript = null, string sortByExpression = null, int? startRowIndex = null, int? rows = null)
        {
            List<UserModel> objSystemUserCol = null;

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
                                objSystemUserCol = new List<UserModel>();

                                foreach (DataRow dr in dt.Rows)
                                {
                                    UserModel objSystemUser = CreateUserModelFromDataRowShared(dr);
                                    objSystemUserCol.Add(objSystemUser);
                                }
                            }
                        }
                    }
                }
            }

            return objSystemUserCol;
        }

        /// <summary>
        /// Inserts a record
        /// </summary>
        public static int Insert(UserModel objSystemUser)
        {
            string storedProcName = "[dbo].[SystemUser_Insert]";
            return InsertUpdate(objSystemUser, false, storedProcName);
        }

        /// <summary>
        /// Updates a record
        /// </summary>
        public static void Update(UserModel objSystemUser)
        {
            string storedProcName = "[dbo].[SystemUser_Update]";
            InsertUpdate(objSystemUser, true, storedProcName);
        }

        private static int InsertUpdate(UserModel objSystemUser, bool isUpdate, string storedProcName)
        {
            int newlyCreatedId = objSystemUser.Id;

            object userName = objSystemUser.UserName;
            object pass = objSystemUser.Pass;
            object name = objSystemUser.Name;
            object image = objSystemUser.Image;
            object accessRightsGroup = objSystemUser.AccessRightsGroup;
            object createdDate = objSystemUser.CreatedDate;
            object modifiedDate = objSystemUser.ModifiedDate;
            object createdUserId = objSystemUser.CreatedUserId;
            object modifiedUserId = objSystemUser.ModifiedUserId;
            object status = objSystemUser.Status;

            if (String.IsNullOrEmpty(objSystemUser.UserName))
                userName = System.DBNull.Value;

            if (String.IsNullOrEmpty(objSystemUser.Pass))
                pass = System.DBNull.Value;

            if (String.IsNullOrEmpty(objSystemUser.Name))
                name = System.DBNull.Value;

            if (String.IsNullOrEmpty(objSystemUser.Image))
                image = System.DBNull.Value;

            if (objSystemUser.AccessRightsGroup == null)
                accessRightsGroup = System.DBNull.Value;

            if (objSystemUser.CreatedDate == null)
                createdDate = System.DBNull.Value;

            if (objSystemUser.ModifiedDate == null)
                modifiedDate = System.DBNull.Value;

            if (objSystemUser.CreatedUserId == null)
                createdUserId = System.DBNull.Value;

            if (objSystemUser.ModifiedUserId == null)
                modifiedUserId = System.DBNull.Value;

            if (objSystemUser.Status == null)
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
                        command.Parameters.AddWithValue("@id", objSystemUser.Id);
                    }

                    command.Parameters.AddWithValue("@userName", userName);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@image", image);
                    command.Parameters.AddWithValue("@accessRightsGroup", accessRightsGroup);
                    command.Parameters.AddWithValue("@createdDate", createdDate);
                    command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
                    command.Parameters.AddWithValue("@createdUserId", createdUserId);
                    command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
                    command.Parameters.AddWithValue("@isDeleted", objSystemUser.IsDeleted);
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
            string storedProcName = "[dbo].[SystemUser_Delete]";

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
        private static void AddSearchCommandParamsShared(SqlCommand command, int? id, string userName, string pass, string name, string image, int? accessRightsGroup, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
        {
            if (id != null)
                command.Parameters.AddWithValue("@id", id);
            else
                command.Parameters.AddWithValue("@id", System.DBNull.Value);

            if (!String.IsNullOrEmpty(userName))
                command.Parameters.AddWithValue("@userName", userName);
            else
                command.Parameters.AddWithValue("@userName", System.DBNull.Value);

            if (!String.IsNullOrEmpty(pass))
                command.Parameters.AddWithValue("@pass", pass);
            else
                command.Parameters.AddWithValue("@pass", System.DBNull.Value);

            if (!String.IsNullOrEmpty(name))
                command.Parameters.AddWithValue("@name", name);
            else
                command.Parameters.AddWithValue("@name", System.DBNull.Value);

            if (!String.IsNullOrEmpty(image))
                command.Parameters.AddWithValue("@image", image);
            else
                command.Parameters.AddWithValue("@image", System.DBNull.Value);

            if (accessRightsGroup != null)
                command.Parameters.AddWithValue("@accessRightsGroup", accessRightsGroup);
            else
                command.Parameters.AddWithValue("@accessRightsGroup", System.DBNull.Value);

            if (createdDate != null)
                command.Parameters.AddWithValue("@createdDate", createdDate);
            else
                command.Parameters.AddWithValue("@createdDate", System.DBNull.Value);

            if (modifiedDate != null)
                command.Parameters.AddWithValue("@modifiedDate", modifiedDate);
            else
                command.Parameters.AddWithValue("@modifiedDate", System.DBNull.Value);

            if (createdUserId != null)
                command.Parameters.AddWithValue("@createdUserId", createdUserId);
            else
                command.Parameters.AddWithValue("@createdUserId", System.DBNull.Value);

            if (modifiedUserId != null)
                command.Parameters.AddWithValue("@modifiedUserId", modifiedUserId);
            else
                command.Parameters.AddWithValue("@modifiedUserId", System.DBNull.Value);

            if (isDeleted != null)
                command.Parameters.AddWithValue("@isDeleted", isDeleted);
            else
                command.Parameters.AddWithValue("@isDeleted", System.DBNull.Value);

            if (status != null)
                command.Parameters.AddWithValue("@status", status);
            else
                command.Parameters.AddWithValue("@status", System.DBNull.Value);

        }


        // Fill data:
        private static UserModel CreateUserModelFromDataRowShared(DataRow dr)
        {
            UserModel user = new UserModel();
            
            user.Id = (int)dr["Id"];

            if (dr["UserName"] != System.DBNull.Value)
                user.UserName = dr["UserName"].ToString();
            else
                user.UserName = "";

            if (dr["Name"] != System.DBNull.Value)
                user.Name = dr["Name"].ToString();
            else
                user.Name = "";

            if (dr["AccessRightsGroup"] != System.DBNull.Value)
                user.AccessRightsGroup = (int)dr["AccessRightsGroup"];
            else
                user.AccessRightsGroup = null;

            if (dr["Image"] != System.DBNull.Value)
                user.Image = dr["Image"].ToString();
            else
                user.Image = null;

            if (dr["Status"] != System.DBNull.Value)
                user.Status = (int)dr["Status"];
            else
                user.Status = null;

            if (dr["IsDeleted"] != System.DBNull.Value)
                user.IsDeleted = (bool)dr["IsDeleted"];
            else
                user.IsDeleted = false;

            if (dr["CreatedDate"] != System.DBNull.Value)
               user.CreatedDate = (DateTime)dr["CreatedDate"];
            else
                user.CreatedDate = null;

            if (dr["CreatedUserId"] != System.DBNull.Value)
                user.CreatedUserId = (int)dr["CreatedUserId"];
            else
                user.CreatedUserId = null;

            if (dr["ModifiedDate"] != System.DBNull.Value)
                user.ModifiedDate = (DateTime)dr["ModifiedDate"];
            else
                user.ModifiedDate = null;

            if (dr["ModifiedUserId"] != System.DBNull.Value)
                user.ModifiedUserId = (int)dr["ModifiedUserId"];
            else
                user.ModifiedUserId = null;

            return user;
        }

        public static string CheckLoginDTO(UserModel taikhoan)
        {
            string user = null;
            //connect tới dữ liệu
            SqlConnection conn = new SqlConnection(PathString.ConnectionString);
            conn.Open();
            SqlCommand command = new SqlCommand("proc_logins", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taikhoan.UserName);
            command.Parameters.AddWithValue("@pass", taikhoan.Pass);
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(1);
                    return user;
                }
                reader.Close(); 
                conn.Close();
            }
            else
            {
                return"Tài khoản hoặc mật khẩu không chính xác";
            }
            return user;
        }
    }
}
