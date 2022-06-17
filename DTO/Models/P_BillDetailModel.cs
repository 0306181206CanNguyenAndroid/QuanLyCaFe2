using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models
{
    public class P_BillDetailModel
    {
            /// <summary> 
            /// Gets or Sets Id 
            /// </summary> 
            public int Id { get; set; }

            /// <summary> 
            /// Gets or Sets TotalPrice 
            /// </summary> 
            public decimal? TotalPrice { get; set; }

            /// <summary> 
            /// Gets or Sets TotalPriceTotal
            /// </summary> 
            public decimal TotalPriceTotal { get; set; }

            /// <summary> 
            /// Gets or Sets CreatedDate 
            /// </summary> 
            public DateTime? CreatedDate { get; set; }

            /// <summary> 
            /// Gets or Sets ModifiedDate 
            /// </summary> 
            public DateTime? ModifiedDate { get; set; }

            /// <summary> 
            /// Gets or Sets CreatedUserId 
            /// </summary> 
            public int? CreatedUserId { get; set; }

            /// <summary> 
            /// Gets or Sets ModifiedUserId 
            /// </summary> 
            public int? ModifiedUserId { get; set; }

            /// <summary> 
            /// Gets or Sets IsDeleted 
            /// </summary> 
            public bool IsDeleted { get; set; }

            /// <summary> 
            /// Gets or Sets BillDetailId 
            /// </summary> 
            public int? BillDetailId { get; set; }

            /// <summary> 
            /// Gets or Sets Status 
            /// </summary> 
            public int? Status { get; set; }

    }
}
