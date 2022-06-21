using DAO.DataLayerBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DTO.Models;
using DTO.ModelsBase;
namespace DAO.DataLayer
{
    public class UserDataLayer : UserDataLayerBase

    {
        public string CheckLogin(UserModel taikhoan)
        {
            string info = CheckLoginDTO(taikhoan);
            return info;
        }
    }
}
