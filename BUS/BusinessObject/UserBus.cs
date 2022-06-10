using BUS.BusinessObjectBase;
using DAO.DataLayer;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusinessObject
{
    public class UserBus : UserBusBase
    {

        public static int check_Account(string usn,string Pass)
        {
            int kq = 1;

            try
            {
                UserModel user = SelectWithUserAndPass(usn, Pass);
                if (user == null)
                    kq = 2;
            }
            catch (Exception e)
            {
                kq = 0;
            }

            return kq;
        }
    }
}
