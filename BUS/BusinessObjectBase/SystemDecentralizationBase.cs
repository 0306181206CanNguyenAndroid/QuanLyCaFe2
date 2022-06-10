using DAO.DataLayer;
using DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.BusinessObjectBase
{
     /// <summary>
     /// Base class for SystemDecentralization.  Do not make changes to this class,
     /// instead, put additional code in the SystemDecentralization class
     /// </summary>
     public class SystemDecentralizationBase : SystemDecentralizationModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public SystemDecentralizationBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static SystemDecentralizationModel SelectByPrimaryKey(int id)
         {
             return SystemDecentralizationDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the SystemDecentralization table
         /// </summary>
         public static int GetRecordCount()
         {
             return SystemDecentralizationDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the SystemDecentralization table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, int? userId, int? staffId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted)
         {
             return SystemDecentralizationDataLayer.GetRecordCountDynamicWhere(id, userId, staffId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemDecentralization sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<SystemDecentralizationModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return SystemDecentralizationDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemDecentralization sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<SystemDecentralizationModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemDecentralizationDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemDecentralization sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<SystemDecentralizationModel> SelectSkipAndTakeDynamicWhere(int? id, int? userId, int? staffId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, userId, staffId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted);
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemDecentralizationDataLayer.SelectSkipAndTakeDynamicWhere(id, userId, staffId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemDecentralization sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<SystemDecentralizationModel> SelectSkipAndTakeDynamicWhere(int? id, int? userId, int? staffId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemDecentralizationDataLayer.SelectSkipAndTakeDynamicWhere(id, userId, staffId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of SystemDecentralization
         /// </summary>
         public static List<SystemDecentralizationModel> SelectAll()
         {
             return SystemDecentralizationDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of SystemDecentralization sorted by the sort expression
         /// </summary>
         public static List<SystemDecentralizationModel> SelectAll(string sortExpression)
         {
            List<SystemDecentralizationModel> objSystemDecentralizationCol = SystemDecentralizationDataLayer.SelectAll();
             return SortByExpression(objSystemDecentralizationCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemDecentralization.
         /// </summary>
         public static List<SystemDecentralizationModel> SelectAllDynamicWhere(int? id, int? userId, int? staffId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted)
         {
             return SystemDecentralizationDataLayer.SelectAllDynamicWhere(id, userId, staffId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemDecentralization sorted by the sort expression.
         /// </summary>
         public static List<SystemDecentralizationModel> SelectAllDynamicWhere(int? id, int? userId, int? staffId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, string sortExpression)
         {
            List<SystemDecentralizationModel> objSystemDecentralizationCol = SystemDecentralizationDataLayer.SelectAllDynamicWhere(id, userId, staffId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted);
             return SortByExpression(objSystemDecentralizationCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and UserId columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<SystemDecentralizationModel> SelectSystemDecentralizationDropDownListData()
         {
             return SystemDecentralizationDataLayer.SelectSystemDecentralizationDropDownListData();
         }

         /// <summary>
         /// Sorts the SystemDecentralizationCollection by sort expression
         /// </summary>
         public static List<SystemDecentralizationModel> SortByExpression(List<SystemDecentralizationModel> objSystemDecentralizationCol, string sortExpression)
         {
             //bool isSortDescending = sortExpression.ToLower().Contains(" desc");

             //if (isSortDescending)
             //{
             //    sortExpression = sortExpression.Replace(" DESC", "");
             //    sortExpression = sortExpression.Replace(" desc", "");
             //}
             //else
             //{
             //    sortExpression = sortExpression.Replace(" ASC", "");
             //    sortExpression = sortExpression.Replace(" asc", "");
             //}

             //switch (sortExpression)
             //{
             //    case "Id":
             //        objSystemDecentralizationCol.Sort(Cms.BusinessObject.SystemDecentralization.ById);
             //        break;
             //    case "UserId":
             //        objSystemDecentralizationCol.Sort(Cms.BusinessObject.SystemDecentralization.ByUserId);
             //        break;
             //    case "StaffId":
             //        objSystemDecentralizationCol.Sort(Cms.BusinessObject.SystemDecentralization.ByStaffId);
             //        break;
             //    case "CreatedDate":
             //        objSystemDecentralizationCol.Sort(Cms.BusinessObject.SystemDecentralization.ByCreatedDate);
             //        break;
             //    case "ModifiedDate":
             //        objSystemDecentralizationCol.Sort(Cms.BusinessObject.SystemDecentralization.ByModifiedDate);
             //        break;
             //    case "CreatedUserId":
             //        objSystemDecentralizationCol.Sort(Cms.BusinessObject.SystemDecentralization.ByCreatedUserId);
             //        break;
             //    case "ModifiedUserId":
             //        objSystemDecentralizationCol.Sort(Cms.BusinessObject.SystemDecentralization.ByModifiedUserId);
             //        break;
             //    case "IsDeleted":
             //        objSystemDecentralizationCol.Sort(Cms.BusinessObject.SystemDecentralization.ByIsDeleted);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objSystemDecentralizationCol.Reverse();

             return objSystemDecentralizationCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            SystemDecentralizationModel objSystemDecentralization = (SystemDecentralizationModel)this;
             return SystemDecentralizationDataLayer.Insert(objSystemDecentralization);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            SystemDecentralizationModel objSystemDecentralization = (SystemDecentralizationModel)this;
             SystemDecentralizationDataLayer.Update(objSystemDecentralization);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             SystemDecentralizationDataLayer.Delete(id);
         }

         private static string GetSortExpression(string sortByExpression)
         {
             if (String.IsNullOrEmpty(sortByExpression) || sortByExpression == " asc")
                 sortByExpression = "Id";
             else if (sortByExpression.Contains(" asc"))
                 sortByExpression = sortByExpression.Replace(" asc", "");

             return sortByExpression;
         }

         ///// <summary>
         ///// Compares Id used for sorting
         ///// </summary>
         //public static Comparison<SystemDecentralization> ById = delegate(SystemDecentralization x, SystemDecentralization y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares UserId used for sorting
         ///// </summary>
         //public static Comparison<SystemDecentralization> ByUserId = delegate(SystemDecentralization x, SystemDecentralization y)
         //{
         //    return Nullable.Compare(x.UserId, y.UserId);
         //};

         ///// <summary>
         ///// Compares StaffId used for sorting
         ///// </summary>
         //public static Comparison<SystemDecentralization> ByStaffId = delegate(SystemDecentralization x, SystemDecentralization y)
         //{
         //    return Nullable.Compare(x.StaffId, y.StaffId);
         //};

         ///// <summary>
         ///// Compares CreatedDate used for sorting
         ///// </summary>
         //public static Comparison<SystemDecentralization> ByCreatedDate = delegate(SystemDecentralization x, SystemDecentralization y)
         //{
         //    return Nullable.Compare(x.CreatedDate, y.CreatedDate);
         //};

         ///// <summary>
         ///// Compares ModifiedDate used for sorting
         ///// </summary>
         //public static Comparison<SystemDecentralization> ByModifiedDate = delegate(SystemDecentralization x, SystemDecentralization y)
         //{
         //    return Nullable.Compare(x.ModifiedDate, y.ModifiedDate);
         //};

         ///// <summary>
         ///// Compares CreatedUserId used for sorting
         ///// </summary>
         //public static Comparison<SystemDecentralization> ByCreatedUserId = delegate(SystemDecentralization x, SystemDecentralization y)
         //{
         //    return Nullable.Compare(x.CreatedUserId, y.CreatedUserId);
         //};

         ///// <summary>
         ///// Compares ModifiedUserId used for sorting
         ///// </summary>
         //public static Comparison<SystemDecentralization> ByModifiedUserId = delegate(SystemDecentralization x, SystemDecentralization y)
         //{
         //    return Nullable.Compare(x.ModifiedUserId, y.ModifiedUserId);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<SystemDecentralization> ByIsDeleted = delegate(SystemDecentralization x, SystemDecentralization y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

     }
}
