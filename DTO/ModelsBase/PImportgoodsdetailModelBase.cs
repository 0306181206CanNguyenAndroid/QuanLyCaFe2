using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ModelsBase
{
     /// <summary>
     /// Base class for PImportgoodsdetailModel.  Do not make changes to this class,
     /// instead, put additional code in the PImportgoodsdetailModel class 
     /// </summary>
     public class PImportgoodsdetailModelBase
     {
         /// <summary> 
         /// Gets or Sets Id 
         /// </summary> 
         public int Id { get; set; } 

         /// <summary> 
         /// Gets or Sets ImportGoodsId 
         /// </summary> 
         public int? ImportGoodsId { get; set; } 

         /// <summary> 
         /// Gets or Sets ProductInfo 
         /// </summary> 
         public int? ProductInfo { get; set; } 

         /// <summary> 
         /// Gets or Sets ManuDate 
         /// </summary> 
         public DateTime? ManuDate { get; set; } 

         /// <summary> 
         /// Gets or Sets ExpiryDate 
         /// </summary> 
         public DateTime? ExpiryDate { get; set; } 

         /// <summary> 
         /// Gets or Sets ProductNumber 
         /// </summary> 
         public string ProductNumber { get; set; } 

         /// <summary> 
         /// Gets or Sets ProductCode 
         /// </summary> 
         public string ProductCode { get; set; } 

         /// <summary> 
         /// Gets or Sets ProductTypeId 
         /// </summary> 
         public int? ProductTypeId { get; set; } 

         /// <summary> 
         /// Gets or Sets ImportQuantity 
         /// </summary> 
         public int? ImportQuantity { get; set; } 

         /// <summary> 
         /// Gets or Sets IsDeleted 
         /// </summary> 
         public bool IsDeleted { get; set; } 

         /// <summary> 
         /// Gets or Sets Status 
         /// </summary> 
         public int? Status { get; set; } 

     }
}
