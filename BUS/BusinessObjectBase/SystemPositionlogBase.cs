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
     /// Base class for SystemPositionlog.  Do not make changes to this class,
     /// instead, put additional code in the SystemPositionlog class
     /// </summary>
     public class SystemPositionlogBase : SystemPositionlogModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public SystemPositionlogBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static SystemPositionlogModel SelectByPrimaryKey(int id)
         {
             return SystemPositionlogDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the SystemPositionlog table
         /// </summary>
         public static int GetRecordCount()
         {
             return SystemPositionlogDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the SystemPositionlog table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, int? positionId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
             return SystemPositionlogDataLayer.GetRecordCountDynamicWhere(id, positionId, action, modifiedDate, modifiedUserId, isDeleted);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemPositionlog sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<SystemPositionlogModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return SystemPositionlogDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemPositionlog sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<SystemPositionlogModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemPositionlogDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemPositionlog sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<SystemPositionlogModel> SelectSkipAndTakeDynamicWhere(int? id, int? positionId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, positionId, action, modifiedDate, modifiedUserId, isDeleted);
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemPositionlogDataLayer.SelectSkipAndTakeDynamicWhere(id, positionId, action, modifiedDate, modifiedUserId, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemPositionlog sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<SystemPositionlogModel> SelectSkipAndTakeDynamicWhere(int? id, int? positionId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemPositionlogDataLayer.SelectSkipAndTakeDynamicWhere(id, positionId, action, modifiedDate, modifiedUserId, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of SystemPositionlog
         /// </summary>
         public static List<SystemPositionlogModel> SelectAll()
         {
             return SystemPositionlogDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of SystemPositionlog sorted by the sort expression
         /// </summary>
         public static List<SystemPositionlogModel> SelectAll(string sortExpression)
         {
            List<SystemPositionlogModel> objSystemPositionlogCol = SystemPositionlogDataLayer.SelectAll();
             return SortByExpression(objSystemPositionlogCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemPositionlog.
         /// </summary>
         public static List<SystemPositionlogModel> SelectAllDynamicWhere(int? id, int? positionId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
             return SystemPositionlogDataLayer.SelectAllDynamicWhere(id, positionId, action, modifiedDate, modifiedUserId, isDeleted);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemPositionlog sorted by the sort expression.
         /// </summary>
         public static List<SystemPositionlogModel> SelectAllDynamicWhere(int? id, int? positionId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted, string sortExpression)
         {
            List<SystemPositionlogModel> objSystemPositionlogCol = SystemPositionlogDataLayer.SelectAllDynamicWhere(id, positionId, action, modifiedDate, modifiedUserId, isDeleted);
             return SortByExpression(objSystemPositionlogCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and PositionId columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<SystemPositionlogModel> SelectSystemPositionlogDropDownListData()
         {
             return SystemPositionlogDataLayer.SelectSystemPositionlogDropDownListData();
         }

         /// <summary>
         /// Sorts the SystemPositionlogCollection by sort expression
         /// </summary>
         public static List<SystemPositionlogModel> SortByExpression(List<SystemPositionlogModel> objSystemPositionlogCol, string sortExpression)
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
             //        objSystemPositionlogCol.Sort(Cms.BusinessObject.SystemPositionlog.ById);
             //        break;
             //    case "PositionId":
             //        objSystemPositionlogCol.Sort(Cms.BusinessObject.SystemPositionlog.ByPositionId);
             //        break;
             //    case "Action":
             //        objSystemPositionlogCol.Sort(Cms.BusinessObject.SystemPositionlog.ByAction);
             //        break;
             //    case "ModifiedDate":
             //        objSystemPositionlogCol.Sort(Cms.BusinessObject.SystemPositionlog.ByModifiedDate);
             //        break;
             //    case "ModifiedUserId":
             //        objSystemPositionlogCol.Sort(Cms.BusinessObject.SystemPositionlog.ByModifiedUserId);
             //        break;
             //    case "IsDeleted":
             //        objSystemPositionlogCol.Sort(Cms.BusinessObject.SystemPositionlog.ByIsDeleted);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objSystemPositionlogCol.Reverse();

             return objSystemPositionlogCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            SystemPositionlogModel objSystemPositionlog = (SystemPositionlogModel)this;
             return SystemPositionlogDataLayer.Insert(objSystemPositionlog);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            SystemPositionlogModel objSystemPositionlog = (SystemPositionlogModel)this;
             SystemPositionlogDataLayer.Update(objSystemPositionlog);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             SystemPositionlogDataLayer.Delete(id);
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
         //public static Comparison<SystemPositionlog> ById = delegate(SystemPositionlog x, SystemPositionlog y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares PositionId used for sorting
         ///// </summary>
         //public static Comparison<SystemPositionlog> ByPositionId = delegate(SystemPositionlog x, SystemPositionlog y)
         //{
         //    return Nullable.Compare(x.PositionId, y.PositionId);
         //};

         ///// <summary>
         ///// Compares Action used for sorting
         ///// </summary>
         //public static Comparison<SystemPositionlog> ByAction = delegate(SystemPositionlog x, SystemPositionlog y)
         //{
         //    return Nullable.Compare(x.Action, y.Action);
         //};

         ///// <summary>
         ///// Compares ModifiedDate used for sorting
         ///// </summary>
         //public static Comparison<SystemPositionlog> ByModifiedDate = delegate(SystemPositionlog x, SystemPositionlog y)
         //{
         //    return Nullable.Compare(x.ModifiedDate, y.ModifiedDate);
         //};

         ///// <summary>
         ///// Compares ModifiedUserId used for sorting
         ///// </summary>
         //public static Comparison<SystemPositionlog> ByModifiedUserId = delegate(SystemPositionlog x, SystemPositionlog y)
         //{
         //    return Nullable.Compare(x.ModifiedUserId, y.ModifiedUserId);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<SystemPositionlog> ByIsDeleted = delegate(SystemPositionlog x, SystemPositionlog y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

     }
}
