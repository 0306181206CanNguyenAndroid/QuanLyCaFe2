using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ModelsBase
{
     /// <summary>
     /// Base class for PImportgoodsModel.  Do not make changes to this class,
     /// instead, put additional code in the PImportgoodsModel class 
     /// </summary>
     public class PImportgoodsModelBase
     {
         /// <summary> 
         /// Gets or Sets Id 
         /// </summary> 
         public int Id { get; set; } 

         /// <summary> 
         /// Gets or Sets GoodsNumber 
         /// </summary> 
         public string GoodsNumber { get; set; } 

         /// <summary> 
         /// Gets or Sets GoodsCode 
         /// </summary> 
         public string GoodsCode { get; set; } 

         /// <summary> 
         /// Gets or Sets Note 
         /// </summary> 
         public string Note { get; set; } 

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
