using DAO.DataLayer;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusinessObjectBase
{
    public class UserBusBase
    {
        public UserBusBase() { }

        public static List<UserModel> SelectAll()
        {
            return UserDataLayer.SelectAll();
        }

        public static UserModel SelectByPrimaryKey(int Id)
        {
            return UserDataLayer.SelectByPrimaryKey(Id);
        }

        public static List<UserModel> SelectAllDynamicWhere(int? Id, string username, string name, string image, bool? isdeleted, int? status, int? accessrightsgroup, DateTime? createddate, DateTime? modifieddate, int? createduserid, int? modifieduserid, string sort)
        {
            return UserDataLayer.SelectAllDynamicWhere(Id, username, name, image, isdeleted, status, accessrightsgroup, createddate, modifieddate, createduserid, modifieduserid, sort);
        }

        public static UserModel SelectWithUserAndPass(string UserName, string pass)
        {
            return UserDataLayer.SelectWithUserAndPass(UserName, pass);
        }
    }
}
