using DTO.ModelsBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{ 
     /// <summary>
     /// This file will not be overwritten.  You can put
     /// additional PBill Model code in this class.
     /// </summary>
     public class PBillModel : PBillModelBase
     {
        public string StaffName { get; set; }
        public string CustomerName { get; set; }
        public string TableCode { get; set; }
        public string Code { get; set; }
        public int DiscountVip { get; set; }

        public List<PBilldetailModel> listBillDetail { get; set; }
    } 
} 
