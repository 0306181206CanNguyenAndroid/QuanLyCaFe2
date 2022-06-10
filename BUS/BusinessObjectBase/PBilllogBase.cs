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
     /// Base class for PBilllog.  Do not make changes to this class,
     /// instead, put additional code in the PBilllog class
     /// </summary>
     public class PBilllogBase : PBilllogModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public PBilllogBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PBilllogModel SelectByPrimaryKey(int id)
         {
             return PBilllogDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the PBilllog table
         /// </summary>
         public static int GetRecordCount()
         {
             return PBilllogDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the PBilllog table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, int? billId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
             return PBilllogDataLayer.GetRecordCountDynamicWhere(id, billId, action, modifiedDate, modifiedUserId, isDeleted);
         }

         /// <summary>
         /// Selects records as a collection (List) of PBilllog sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<PBilllogModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return PBilllogDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PBilllog sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<PBilllogModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PBilllogDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PBilllog sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PBilllogModel> SelectSkipAndTakeDynamicWhere(int? id, int? billId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, billId, action, modifiedDate, modifiedUserId, isDeleted);
             sortByExpression = GetSortExpression(sortByExpression);
             return PBilllogDataLayer.SelectSkipAndTakeDynamicWhere(id, billId, action, modifiedDate, modifiedUserId, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PBilllog sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PBilllogModel> SelectSkipAndTakeDynamicWhere(int? id, int? billId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PBilllogDataLayer.SelectSkipAndTakeDynamicWhere(id, billId, action, modifiedDate, modifiedUserId, isDeleted, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of PBilllog
         /// </summary>
         public static List<PBilllogModel> SelectAll()
         {
             return PBilllogDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of PBilllog sorted by the sort expression
         /// </summary>
         public static List<PBilllogModel> SelectAll(string sortExpression)
         {
            List<PBilllogModel> objPBilllogCol = PBilllogDataLayer.SelectAll();
             return SortByExpression(objPBilllogCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PBilllog.
         /// </summary>
         public static List<PBilllogModel> SelectAllDynamicWhere(int? id, int? billId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted)
         {
             return PBilllogDataLayer.SelectAllDynamicWhere(id, billId, action, modifiedDate, modifiedUserId, isDeleted);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PBilllog sorted by the sort expression.
         /// </summary>
         public static List<PBilllogModel> SelectAllDynamicWhere(int? id, int? billId, int? action, DateTime? modifiedDate, int? modifiedUserId, bool? isDeleted, string sortExpression)
         {
            List<PBilllogModel> objPBilllogCol = PBilllogDataLayer.SelectAllDynamicWhere(id, billId, action, modifiedDate, modifiedUserId, isDeleted);
             return SortByExpression(objPBilllogCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and BillId columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<PBilllogModel> SelectPBilllogDropDownListData()
         {
             return PBilllogDataLayer.SelectPBilllogDropDownListData();
         }

         /// <summary>
         /// Sorts the PBilllogCollection by sort expression
         /// </summary>
         public static List<PBilllogModel> SortByExpression(List<PBilllogModel> objPBilllogCol, string sortExpression)
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
             //        objPBilllogCol.Sort(Cms.BusinessObject.PBilllog.ById);
             //        break;
             //    case "BillId":
             //        objPBilllogCol.Sort(Cms.BusinessObject.PBilllog.ByBillId);
             //        break;
             //    case "Action":
             //        objPBilllogCol.Sort(Cms.BusinessObject.PBilllog.ByAction);
             //        break;
             //    case "ModifiedDate":
             //        objPBilllogCol.Sort(Cms.BusinessObject.PBilllog.ByModifiedDate);
             //        break;
             //    case "ModifiedUserId":
             //        objPBilllogCol.Sort(Cms.BusinessObject.PBilllog.ByModifiedUserId);
             //        break;
             //    case "IsDeleted":
             //        objPBilllogCol.Sort(Cms.BusinessObject.PBilllog.ByIsDeleted);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objPBilllogCol.Reverse();

             return objPBilllogCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            PBilllogModel objPBilllog = (PBilllogModel)this;
             return PBilllogDataLayer.Insert(objPBilllog);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            PBilllogModel objPBilllog = (PBilllogModel)this;
             PBilllogDataLayer.Update(objPBilllog);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             PBilllogDataLayer.Delete(id);
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
         //public static Comparison<PBilllog> ById = delegate(PBilllog x, PBilllog y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares BillId used for sorting
         ///// </summary>
         //public static Comparison<PBilllog> ByBillId = delegate(PBilllog x, PBilllog y)
         //{
         //    return Nullable.Compare(x.BillId, y.BillId);
         //};

         ///// <summary>
         ///// Compares Action used for sorting
         ///// </summary>
         //public static Comparison<PBilllog> ByAction = delegate(PBilllog x, PBilllog y)
         //{
         //    return Nullable.Compare(x.Action, y.Action);
         //};

         ///// <summary>
         ///// Compares ModifiedDate used for sorting
         ///// </summary>
         //public static Comparison<PBilllog> ByModifiedDate = delegate(PBilllog x, PBilllog y)
         //{
         //    return Nullable.Compare(x.ModifiedDate, y.ModifiedDate);
         //};

         ///// <summary>
         ///// Compares ModifiedUserId used for sorting
         ///// </summary>
         //public static Comparison<PBilllog> ByModifiedUserId = delegate(PBilllog x, PBilllog y)
         //{
         //    return Nullable.Compare(x.ModifiedUserId, y.ModifiedUserId);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<PBilllog> ByIsDeleted = delegate(PBilllog x, PBilllog y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

     }
}
