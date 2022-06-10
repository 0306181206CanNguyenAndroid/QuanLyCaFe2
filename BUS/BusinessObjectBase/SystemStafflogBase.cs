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
     /// Base class for SystemStafflog.  Do not make changes to this class,
     /// instead, put additional code in the SystemStafflog class
     /// </summary>
     public class SystemStafflogBase : SystemStafflogModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public SystemStafflogBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static SystemStafflogModel SelectByPrimaryKey(int id)
         {
             return SystemStafflogDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the SystemStafflog table
         /// </summary>
         public static int GetRecordCount()
         {
             return SystemStafflogDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the SystemStafflog table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, int? staffId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
             return SystemStafflogDataLayer.GetRecordCountDynamicWhere(id, staffId, action, modifiedDate, modifiedUserId, isDeleted);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemStafflog sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<SystemStafflogModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return SystemStafflogDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemStafflog sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<SystemStafflogModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemStafflogDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemStafflog sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<SystemStafflogModel> SelectSkipAndTakeDynamicWhere(int? id, int? staffId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, staffId, action, modifiedDate, modifiedUserId, isDeleted);
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemStafflogDataLayer.SelectSkipAndTakeDynamicWhere(id, staffId, action, modifiedDate, modifiedUserId, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemStafflog sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<SystemStafflogModel> SelectSkipAndTakeDynamicWhere(int? id, int? staffId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemStafflogDataLayer.SelectSkipAndTakeDynamicWhere(id, staffId, action, modifiedDate, modifiedUserId, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of SystemStafflog
         /// </summary>
         public static List<SystemStafflogModel> SelectAll()
         {
             return SystemStafflogDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of SystemStafflog sorted by the sort expression
         /// </summary>
         public static List<SystemStafflogModel> SelectAll(string sortExpression)
         {
            List<SystemStafflogModel> objSystemStafflogCol = SystemStafflogDataLayer.SelectAll();
             return SortByExpression(objSystemStafflogCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemStafflog.
         /// </summary>
         public static List<SystemStafflogModel> SelectAllDynamicWhere(int? id, int? staffId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
             return SystemStafflogDataLayer.SelectAllDynamicWhere(id, staffId, action, modifiedDate, modifiedUserId, isDeleted);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemStafflog sorted by the sort expression.
         /// </summary>
         public static List<SystemStafflogModel> SelectAllDynamicWhere(int? id, int? staffId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted, string sortExpression)
         {
            List<SystemStafflogModel> objSystemStafflogCol = SystemStafflogDataLayer.SelectAllDynamicWhere(id, staffId, action, modifiedDate, modifiedUserId, isDeleted);
             return SortByExpression(objSystemStafflogCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and StaffId columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<SystemStafflogModel> SelectSystemStafflogDropDownListData()
         {
             return SystemStafflogDataLayer.SelectSystemStafflogDropDownListData();
         }

         /// <summary>
         /// Sorts the SystemStafflogCollection by sort expression
         /// </summary>
         public static List<SystemStafflogModel> SortByExpression(List<SystemStafflogModel> objSystemStafflogCol, string sortExpression)
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
             //        objSystemStafflogCol.Sort(Cms.BusinessObject.SystemStafflog.ById);
             //        break;
             //    case "StaffId":
             //        objSystemStafflogCol.Sort(Cms.BusinessObject.SystemStafflog.ByStaffId);
             //        break;
             //    case "Action":
             //        objSystemStafflogCol.Sort(Cms.BusinessObject.SystemStafflog.ByAction);
             //        break;
             //    case "ModifiedDate":
             //        objSystemStafflogCol.Sort(Cms.BusinessObject.SystemStafflog.ByModifiedDate);
             //        break;
             //    case "ModifiedUserId":
             //        objSystemStafflogCol.Sort(Cms.BusinessObject.SystemStafflog.ByModifiedUserId);
             //        break;
             //    case "IsDeleted":
             //        objSystemStafflogCol.Sort(Cms.BusinessObject.SystemStafflog.ByIsDeleted);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objSystemStafflogCol.Reverse();

             return objSystemStafflogCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            SystemStafflogModel objSystemStafflog = (SystemStafflogModel)this;
             return SystemStafflogDataLayer.Insert(objSystemStafflog);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            SystemStafflogModel objSystemStafflog = (SystemStafflogModel)this;
             SystemStafflogDataLayer.Update(objSystemStafflog);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             SystemStafflogDataLayer.Delete(id);
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
         //public static Comparison<SystemStafflog> ById = delegate(SystemStafflog x, SystemStafflog y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares StaffId used for sorting
         ///// </summary>
         //public static Comparison<SystemStafflog> ByStaffId = delegate(SystemStafflog x, SystemStafflog y)
         //{
         //    return Nullable.Compare(x.StaffId, y.StaffId);
         //};

         ///// <summary>
         ///// Compares Action used for sorting
         ///// </summary>
         //public static Comparison<SystemStafflog> ByAction = delegate(SystemStafflog x, SystemStafflog y)
         //{
         //    return Nullable.Compare(x.Action, y.Action);
         //};

         ///// <summary>
         ///// Compares ModifiedDate used for sorting
         ///// </summary>
         //public static Comparison<SystemStafflog> ByModifiedDate = delegate(SystemStafflog x, SystemStafflog y)
         //{
         //    return Nullable.Compare(x.ModifiedDate, y.ModifiedDate);
         //};

         ///// <summary>
         ///// Compares ModifiedUserId used for sorting
         ///// </summary>
         //public static Comparison<SystemStafflog> ByModifiedUserId = delegate(SystemStafflog x, SystemStafflog y)
         //{
         //    return Nullable.Compare(x.ModifiedUserId, y.ModifiedUserId);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<SystemStaffModel> ByIsDeleted = delegate(SystemStaffModel x, SystemStaffModel y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

     }
}
