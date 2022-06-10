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
     /// Base class for SystemAccessrightsgroupdetail.  Do not make changes to this class,
     /// instead, put additional code in the SystemAccessrightsgroupdetail class
     /// </summary>
     public class SystemAccessrightsgroupdetailBase : SystemAccessrightsgroupdetailModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public SystemAccessrightsgroupdetailBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static SystemAccessrightsgroupdetailModel SelectByPrimaryKey(int id)
         {
             return SystemAccessrightsgroupdetailDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the SystemAccessrightsgroupdetail table
         /// </summary>
         public static int GetRecordCount()
         {
             return SystemAccessrightsgroupdetailDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the SystemAccessrightsgroupdetail table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, int? groupId, int? accessRightsApplyId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
             return SystemAccessrightsgroupdetailDataLayer.GetRecordCountDynamicWhere(id, groupId, accessRightsApplyId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemAccessrightsgroupdetail sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<SystemAccessrightsgroupdetailModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return SystemAccessrightsgroupdetailDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemAccessrightsgroupdetail sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<SystemAccessrightsgroupdetailModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemAccessrightsgroupdetailDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemAccessrightsgroupdetail sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<SystemAccessrightsgroupdetailModel> SelectSkipAndTakeDynamicWhere(int? id, int? groupId, int? accessRightsApplyId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, groupId, accessRightsApplyId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemAccessrightsgroupdetailDataLayer.SelectSkipAndTakeDynamicWhere(id, groupId, accessRightsApplyId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemAccessrightsgroupdetail sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<SystemAccessrightsgroupdetailModel> SelectSkipAndTakeDynamicWhere(int? id, int? groupId, int? accessRightsApplyId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemAccessrightsgroupdetailDataLayer.SelectSkipAndTakeDynamicWhere(id, groupId, accessRightsApplyId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of SystemAccessrightsgroupdetail
         /// </summary>
         public static List<SystemAccessrightsgroupdetailModel> SelectAll()
         {
             return SystemAccessrightsgroupdetailDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of SystemAccessrightsgroupdetail sorted by the sort expression
         /// </summary>
         public static List<SystemAccessrightsgroupdetailModel> SelectAll(string sortExpression)
         {
            List<SystemAccessrightsgroupdetailModel> objSystemAccessrightsgroupdetailCol = SystemAccessrightsgroupdetailDataLayer.SelectAll();
             return SortByExpression(objSystemAccessrightsgroupdetailCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemAccessrightsgroupdetail.
         /// </summary>
         public static List<SystemAccessrightsgroupdetailModel> SelectAllDynamicWhere(int? id, int? groupId, int? accessRightsApplyId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
             return SystemAccessrightsgroupdetailDataLayer.SelectAllDynamicWhere(id, groupId, accessRightsApplyId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemAccessrightsgroupdetail sorted by the sort expression.
         /// </summary>
         public static List<SystemAccessrightsgroupdetailModel> SelectAllDynamicWhere(int? id, int? groupId, int? accessRightsApplyId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string sortExpression)
         {
            List<SystemAccessrightsgroupdetailModel> objSystemAccessrightsgroupdetailCol = SystemAccessrightsgroupdetailDataLayer.SelectAllDynamicWhere(id, groupId, accessRightsApplyId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
             return SortByExpression(objSystemAccessrightsgroupdetailCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and GroupId columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<SystemAccessrightsgroupdetailModel> SelectSystemAccessrightsgroupdetailDropDownListData()
         {
             return SystemAccessrightsgroupdetailDataLayer.SelectSystemAccessrightsgroupdetailDropDownListData();
         }

         /// <summary>
         /// Sorts the SystemAccessrightsgroupdetailCollection by sort expression
         /// </summary>
         public static List<SystemAccessrightsgroupdetailModel> SortByExpression(List<SystemAccessrightsgroupdetailModel> objSystemAccessrightsgroupdetailCol, string sortExpression)
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
             //        objSystemAccessrightsgroupdetailCol.Sort(Cms.BusinessObject.SystemAccessrightsgroupdetail.ById);
             //        break;
             //    case "GroupId":
             //        objSystemAccessrightsgroupdetailCol.Sort(Cms.BusinessObject.SystemAccessrightsgroupdetail.ByGroupId);
             //        break;
             //    case "AccessRightsApplyId":
             //        objSystemAccessrightsgroupdetailCol.Sort(Cms.BusinessObject.SystemAccessrightsgroupdetail.ByAccessRightsApplyId);
             //        break;
             //    case "CreatedDate":
             //        objSystemAccessrightsgroupdetailCol.Sort(Cms.BusinessObject.SystemAccessrightsgroupdetail.ByCreatedDate);
             //        break;
             //    case "ModifiedDate":
             //        objSystemAccessrightsgroupdetailCol.Sort(Cms.BusinessObject.SystemAccessrightsgroupdetail.ByModifiedDate);
             //        break;
             //    case "CreatedUserId":
             //        objSystemAccessrightsgroupdetailCol.Sort(Cms.BusinessObject.SystemAccessrightsgroupdetail.ByCreatedUserId);
             //        break;
             //    case "ModifiedUserId":
             //        objSystemAccessrightsgroupdetailCol.Sort(Cms.BusinessObject.SystemAccessrightsgroupdetail.ByModifiedUserId);
             //        break;
             //    case "IsDeleted":
             //        objSystemAccessrightsgroupdetailCol.Sort(Cms.BusinessObject.SystemAccessrightsgroupdetail.ByIsDeleted);
             //        break;
             //    case "Status":
             //        objSystemAccessrightsgroupdetailCol.Sort(Cms.BusinessObject.SystemAccessrightsgroupdetail.ByStatus);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objSystemAccessrightsgroupdetailCol.Reverse();

             return objSystemAccessrightsgroupdetailCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            SystemAccessrightsgroupdetailModel objSystemAccessrightsgroupdetail = (SystemAccessrightsgroupdetailModel)this;
             return SystemAccessrightsgroupdetailDataLayer.Insert(objSystemAccessrightsgroupdetail);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            SystemAccessrightsgroupdetailModel objSystemAccessrightsgroupdetail = (SystemAccessrightsgroupdetailModel)this;
             SystemAccessrightsgroupdetailDataLayer.Update(objSystemAccessrightsgroupdetail);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             SystemAccessrightsgroupdetailDataLayer.Delete(id);
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
         //public static Comparison<SystemAccessrightsgroupdetail> ById = delegate(SystemAccessrightsgroupdetail x, SystemAccessrightsgroupdetail y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares GroupId used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrightsgroupdetail> ByGroupId = delegate(SystemAccessrightsgroupdetail x, SystemAccessrightsgroupdetail y)
         //{
         //    return Nullable.Compare(x.GroupId, y.GroupId);
         //};

         ///// <summary>
         ///// Compares AccessRightsApplyId used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrightsgroupdetail> ByAccessRightsApplyId = delegate(SystemAccessrightsgroupdetail x, SystemAccessrightsgroupdetail y)
         //{
         //    return Nullable.Compare(x.AccessRightsApplyId, y.AccessRightsApplyId);
         //};

         ///// <summary>
         ///// Compares CreatedDate used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrightsgroupdetail> ByCreatedDate = delegate(SystemAccessrightsgroupdetail x, SystemAccessrightsgroupdetail y)
         //{
         //    return Nullable.Compare(x.CreatedDate, y.CreatedDate);
         //};

         ///// <summary>
         ///// Compares ModifiedDate used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrightsgroupdetail> ByModifiedDate = delegate(SystemAccessrightsgroupdetail x, SystemAccessrightsgroupdetail y)
         //{
         //    return Nullable.Compare(x.ModifiedDate, y.ModifiedDate);
         //};

         ///// <summary>
         ///// Compares CreatedUserId used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrightsgroupdetail> ByCreatedUserId = delegate(SystemAccessrightsgroupdetail x, SystemAccessrightsgroupdetail y)
         //{
         //    return Nullable.Compare(x.CreatedUserId, y.CreatedUserId);
         //};

         ///// <summary>
         ///// Compares ModifiedUserId used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrightsgroupdetail> ByModifiedUserId = delegate(SystemAccessrightsgroupdetail x, SystemAccessrightsgroupdetail y)
         //{
         //    return Nullable.Compare(x.ModifiedUserId, y.ModifiedUserId);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrightsgroupdetail> ByIsDeleted = delegate(SystemAccessrightsgroupdetail x, SystemAccessrightsgroupdetail y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

         ///// <summary>
         ///// Compares Status used for sorting
         ///// </summary>
         //public static Comparison<SystemAccessrightsgroupdetail> ByStatus = delegate(SystemAccessrightsgroupdetail x, SystemAccessrightsgroupdetail y)
         //{
         //    return Nullable.Compare(x.Status, y.Status);
         //};

     }
}
