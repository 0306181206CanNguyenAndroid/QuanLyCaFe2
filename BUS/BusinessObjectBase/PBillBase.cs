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
     /// Base class for PBill.  Do not make changes to this class,
     /// instead, put additional code in the PBill class
     /// </summary>
     public class PBillBase : PBillModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public PBillBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PBillModel SelectByPrimaryKey(int id)
         {
             return PBillDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the PBill table
         /// </summary>
         public static int GetRecordCount()
         {
             return PBillDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the PBill table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, decimal? totalPrice, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? billDetailId, int? status)
         {
             return PBillDataLayer.GetRecordCountDynamicWhere(id, totalPrice, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, billDetailId, status);
         }

         /// <summary>
         /// Selects records as a collection (List) of PBill sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<PBillModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return PBillDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PBill sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<PBillModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PBillDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PBill sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PBillModel> SelectSkipAndTakeDynamicWhere(int? id, decimal? totalPrice, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? billDetailId, int? status, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, totalPrice, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, billDetailId, status);
             sortByExpression = GetSortExpression(sortByExpression);
             return PBillDataLayer.SelectSkipAndTakeDynamicWhere(id, totalPrice, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, billDetailId, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PBill sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PBillModel> SelectSkipAndTakeDynamicWhere(int? id, decimal? totalPrice, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? billDetailId, int? status, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PBillDataLayer.SelectSkipAndTakeDynamicWhere(id, totalPrice, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, billDetailId, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Gets the grand total or sum of fields with a money or decimal data type.  E.g. TotalPriceTotal
         /// </summary>
         public static PBillModel SelectTotals()
         {
             return PBillDataLayer.SelectTotals();
         }

         /// <summary>
         /// Selects all records as a collection (List) of PBill
         /// </summary>
         public static List<PBillModel> SelectAll()
         {
             return PBillDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of PBill sorted by the sort expression
         /// </summary>
         public static List<PBillModel> SelectAll(string sortExpression)
         {
            List<PBillModel> objPBillCol = PBillDataLayer.SelectAll();
             return SortByExpression(objPBillCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PBill.
         /// </summary>
         public static List<PBillModel> SelectAllDynamicWhere(int? id, decimal? totalPrice, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? billDetailId, int? status)
         {
             return PBillDataLayer.SelectAllDynamicWhere(id, totalPrice, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, billDetailId, status);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PBill sorted by the sort expression.
         /// </summary>
         public static List<PBillModel> SelectAllDynamicWhere(int? id, decimal? totalPrice, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? billDetailId, int? status, string sortExpression)
         {
            List<PBillModel> objPBillCol = PBillDataLayer.SelectAllDynamicWhere(id, totalPrice, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, billDetailId, status);
             return SortByExpression(objPBillCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and TotalPrice columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<PBillModel> SelectPBillDropDownListData()
         {
             return PBillDataLayer.SelectPBillDropDownListData();
         }

         /// <summary>
         /// Sorts the PBillCollection by sort expression
         /// </summary>
         public static List<PBillModel> SortByExpression(List<PBillModel> objPBillCol, string sortExpression)
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
             //        objPBillCol.Sort(Cms.BusinessObject.PBill.ById);
             //        break;
             //    case "TotalPrice":
             //        objPBillCol.Sort(Cms.BusinessObject.PBill.ByTotalPrice);
             //        break;
             //    case "CreatedDate":
             //        objPBillCol.Sort(Cms.BusinessObject.PBill.ByCreatedDate);
             //        break;
             //    case "ModifiedDate":
             //        objPBillCol.Sort(Cms.BusinessObject.PBill.ByModifiedDate);
             //        break;
             //    case "CreatedUserId":
             //        objPBillCol.Sort(Cms.BusinessObject.PBill.ByCreatedUserId);
             //        break;
             //    case "ModifiedUserId":
             //        objPBillCol.Sort(Cms.BusinessObject.PBill.ByModifiedUserId);
             //        break;
             //    case "IsDeleted":
             //        objPBillCol.Sort(Cms.BusinessObject.PBill.ByIsDeleted);
             //        break;
             //    case "BillDetailId":
             //        objPBillCol.Sort(Cms.BusinessObject.PBill.ByBillDetailId);
             //        break;
             //    case "Status":
             //        objPBillCol.Sort(Cms.BusinessObject.PBill.ByStatus);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objPBillCol.Reverse();

             return objPBillCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            PBillModel objPBill = (PBillModel)this;
             return PBillDataLayer.Insert(objPBill);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            PBillModel objPBill = (PBillModel)this;
             PBillDataLayer.Update(objPBill);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             PBillDataLayer.Delete(id);
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
         //public static Comparison<PBill> ById = delegate(PBill x, PBill y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares TotalPrice used for sorting
         ///// </summary>
         //public static Comparison<PBill> ByTotalPrice = delegate(PBill x, PBill y)
         //{
         //    return Nullable.Compare(x.TotalPrice, y.TotalPrice);
         //};

         ///// <summary>
         ///// Compares CreatedDate used for sorting
         ///// </summary>
         //public static Comparison<PBill> ByCreatedDate = delegate(PBill x, PBill y)
         //{
         //    return Nullable.Compare(x.CreatedDate, y.CreatedDate);
         //};

         ///// <summary>
         ///// Compares ModifiedDate used for sorting
         ///// </summary>
         //public static Comparison<PBill> ByModifiedDate = delegate(PBill x, PBill y)
         //{
         //    return Nullable.Compare(x.ModifiedDate, y.ModifiedDate);
         //};

         ///// <summary>
         ///// Compares CreatedUserId used for sorting
         ///// </summary>
         //public static Comparison<PBill> ByCreatedUserId = delegate(PBill x, PBill y)
         //{
         //    return Nullable.Compare(x.CreatedUserId, y.CreatedUserId);
         //};

         ///// <summary>
         ///// Compares ModifiedUserId used for sorting
         ///// </summary>
         //public static Comparison<PBill> ByModifiedUserId = delegate(PBill x, PBill y)
         //{
         //    return Nullable.Compare(x.ModifiedUserId, y.ModifiedUserId);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<PBill> ByIsDeleted = delegate(PBill x, PBill y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

         ///// <summary>
         ///// Compares BillDetailId used for sorting
         ///// </summary>
         //public static Comparison<PBill> ByBillDetailId = delegate(PBill x, PBill y)
         //{
         //    return Nullable.Compare(x.BillDetailId, y.BillDetailId);
         //};

         ///// <summary>
         ///// Compares Status used for sorting
         ///// </summary>
         //public static Comparison<PBill> ByStatus = delegate(PBill x, PBill y)
         //{
         //    return Nullable.Compare(x.Status, y.Status);
         //};

     }
}
