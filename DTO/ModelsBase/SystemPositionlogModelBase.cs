using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.ModelsBase
{
     /// <summary>
     /// Base class for SystemPositionlogModel.  Do not make changes to this class,
     /// instead, put additional code in the SystemPositionlogModel class 
     /// </summary>
     public class SystemPositionlogModelBase
     {
         /// <summary> 
         /// Gets or Sets Id 
         /// </summary> 
         public int Id { get; set; } 

         /// <summary> 
         /// Gets or Sets PositionId 
         /// </summary> 
         public int? PositionId { get; set; } 

         /// <summary> 
         /// Gets or Sets Action 
         /// </summary> 
         public int? Action { get; set; } 

         /// <summary> 
         /// Gets or Sets ModifiedDate 
         /// </summary> 
         public DateTime? ModifiedDate { get; set; } 

         /// <summary> 
         /// Gets or Sets ModifiedUserId 
         /// </summary> 
         public int? ModifiedUserId { get; set; } 

         /// <summary> 
         /// Gets or Sets IsDeleted 
         /// </summary> 
         public bool IsDeleted { get; set; } 

     }
}
