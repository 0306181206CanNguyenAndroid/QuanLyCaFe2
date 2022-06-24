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
     /// Base class for PBilldetail.  Do not make changes to this class,
     /// instead, put additional code in the PBilldetail class
     /// </summary>
     public class PBilldetailBase : PBilldetailModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public PBilldetailBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PBilldetailModel SelectByPrimaryKey(int id)
         {
             return PBilldetailDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the PBilldetail table
         /// </summary>
         public static int GetRecordCount()
         {
             return PBilldetailDataLayer.GetRecordCount();
         }

        /// <summary>
        /// Gets the total number of records in the PBilldetail table based on search parameters
        /// </summary>
        public static int GetRecordCountDynamicWhere(int? id, int? billId, int? productId, int? quantity, decimal? unitPrice, DateTime? createdDate, DateTime? modifiedDate, int? modifiedUserId, int? createdUserId, bool? isDeleted, int? status, int? discount)
         {
             return PBilldetailDataLayer.GetRecordCountDynamicWhere(id, billId, productId, quantity, unitPrice, createdDate, modifiedDate, modifiedUserId,createdUserId, isDeleted, status,discount);
         }

         /// <summary>
         /// Selects records as a collection (List) of PBilldetail sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<PBilldetailModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return PBilldetailDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PBilldetail sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<PBilldetailModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PBilldetailDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PBilldetail sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PBilldetailModel> SelectSkipAndTakeDynamicWhere(int? id, int? billId, int? productId, int? quantity, decimal? unitPrice, DateTime? createdDate, DateTime? modifiedDate, int? modifiedUserId, int? createdUserId, bool? isDeleted, int? status, int? discount, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, billId, productId, quantity, unitPrice, createdDate, modifiedDate, modifiedUserId, createdUserId, isDeleted, status, discount);
             sortByExpression = GetSortExpression(sortByExpression);
             return PBilldetailDataLayer.SelectSkipAndTakeDynamicWhere(id, billId, productId, quantity, unitPrice, createdDate, modifiedDate, modifiedUserId, createdUserId, isDeleted, status, discount, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PBilldetail sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PBilldetailModel> SelectSkipAndTakeDynamicWhere(int? id, int? billId, int? productId, int? quantity, decimal? unitPrice, DateTime? createdDate, DateTime? modifiedDate, int? modifiedUserId, int? createdUserId, bool? isDeleted, int? status, int? discount, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PBilldetailDataLayer.SelectSkipAndTakeDynamicWhere(id, billId, productId, quantity, unitPrice, createdDate, modifiedDate, modifiedUserId, createdUserId, isDeleted, status, discount, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Gets the grand total or sum of fields with a money or decimal data type.  E.g. UnitPriceTotal
         /// </summary>
         public static PBilldetailModel SelectTotals()
         {
             return PBilldetailDataLayer.SelectTotals();
         }

         /// <summary>
         /// Selects all records as a collection (List) of PBilldetail
         /// </summary>
         public static List<PBilldetailModel> SelectAll()
         {
             return PBilldetailDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of PBilldetail sorted by the sort expression
         /// </summary>
         public static List<PBilldetailModel> SelectAll(string sortExpression)
         {
            List<PBilldetailModel> objPBilldetailCol = PBilldetailDataLayer.SelectAll();
             return SortByExpression(objPBilldetailCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PBilldetail.
         /// </summary>
         public static List<PBilldetailModel> SelectAllDynamicWhere(int? id, int? billId, int? productId, int? quantity, decimal? unitPrice, DateTime? createdDate, DateTime? modifiedDate, int? modifiedUserId, int? createdUserId, bool? isDeleted, int? status, int? discount)
         {
            return PBilldetailDataLayer.SelectAllDynamicWhere(id, billId, productId, quantity, unitPrice, createdDate, modifiedDate, modifiedUserId, createdUserId, isDeleted, status, discount);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PBilldetail sorted by the sort expression.
         /// </summary>
         public static List<PBilldetailModel> SelectAllDynamicWhere(int? id, int? billId, int? productId, int? quantity, decimal? unitPrice, DateTime? createdDate, DateTime? modifiedDate, int? modifiedUserId, int? createdUserId, bool? isDeleted, int? status, int? discount, string sortExpression)
         {
            List<PBilldetailModel> objPBilldetailCol = PBilldetailDataLayer.SelectAllDynamicWhere(id, billId, productId, quantity, unitPrice, createdDate, modifiedDate, modifiedUserId, createdUserId, isDeleted, status, discount);
             return SortByExpression(objPBilldetailCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and BillId columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<PBilldetailModel> SelectPBilldetailDropDownListData()
         {
             return PBilldetailDataLayer.SelectPBilldetailDropDownListData();
         }

         /// <summary>
         /// Sorts the PBilldetailCollection by sort expression
         /// </summary>
         public static List<PBilldetailModel> SortByExpression(List<PBilldetailModel> objPBilldetailCol, string sortExpression)
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
             //        objPBilldetailCol.Sort(Cms.BusinessObject.PBilldetail.ById);
             //        break;
             //    case "BillId":
             //        objPBilldetailCol.Sort(Cms.BusinessObject.PBilldetail.ByBillId);
             //        break;
             //    case "ProductId":
             //        objPBilldetailCol.Sort(Cms.BusinessObject.PBilldetail.ByProductId);
             //        break;
             //    case "Quantity":
             //        objPBilldetailCol.Sort(Cms.BusinessObject.PBilldetail.ByQuantity);
             //        break;
             //    case "UnitPrice":
             //        objPBilldetailCol.Sort(Cms.BusinessObject.PBilldetail.ByUnitPrice);
             //        break;
             //    case "CreatedDate":
             //        objPBilldetailCol.Sort(Cms.BusinessObject.PBilldetail.ByCreatedDate);
             //        break;
             //    case "ModifiedDate":
             //        objPBilldetailCol.Sort(Cms.BusinessObject.PBilldetail.ByModifiedDate);
             //        break;
             //    case "ModifiedUserId":
             //        objPBilldetailCol.Sort(Cms.BusinessObject.PBilldetail.ByModifiedUserId);
             //        break;
             //    case "IsDeleted":
             //        objPBilldetailCol.Sort(Cms.BusinessObject.PBilldetail.ByIsDeleted);
             //        break;
             //    case "Status":
             //        objPBilldetailCol.Sort(Cms.BusinessObject.PBilldetail.ByStatus);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objPBilldetailCol.Reverse();

             return objPBilldetailCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public static int Insert(PBilldetailModel b)
         {
            PBilldetailModel objPBilldetail = b;
             return PBilldetailDataLayer.Insert(objPBilldetail);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            PBilldetailModel objPBilldetail = (PBilldetailModel)this;
             PBilldetailDataLayer.Update(objPBilldetail);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             PBilldetailDataLayer.Delete(id);
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
         //public static Comparison<PBilldetail> ById = delegate(PBilldetail x, PBilldetail y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares BillId used for sorting
         ///// </summary>
         //public static Comparison<PBilldetail> ByBillId = delegate(PBilldetail x, PBilldetail y)
         //{
         //    return Nullable.Compare(x.BillId, y.BillId);
         //};

         ///// <summary>
         ///// Compares ProductId used for sorting
         ///// </summary>
         //public static Comparison<PBilldetail> ByProductId = delegate(PBilldetail x, PBilldetail y)
         //{
         //    return Nullable.Compare(x.ProductId, y.ProductId);
         //};

         ///// <summary>
         ///// Compares Quantity used for sorting
         ///// </summary>
         //public static Comparison<PBilldetail> ByQuantity = delegate(PBilldetail x, PBilldetail y)
         //{
         //    return Nullable.Compare(x.Quantity, y.Quantity);
         //};

         ///// <summary>
         ///// Compares UnitPrice used for sorting
         ///// </summary>
         //public static Comparison<PBilldetail> ByUnitPrice = delegate(PBilldetail x, PBilldetail y)
         //{
         //    return Nullable.Compare(x.UnitPrice, y.UnitPrice);
         //};

         ///// <summary>
         ///// Compares CreatedDate used for sorting
         ///// </summary>
         //public static Comparison<PBilldetail> ByCreatedDate = delegate(PBilldetail x, PBilldetail y)
         //{
         //    return Nullable.Compare(x.CreatedDate, y.CreatedDate);
         //};

         ///// <summary>
         ///// Compares ModifiedDate used for sorting
         ///// </summary>
         //public static Comparison<PBilldetail> ByModifiedDate = delegate(PBilldetail x, PBilldetail y)
         //{
         //    return Nullable.Compare(x.ModifiedDate, y.ModifiedDate);
         //};

         ///// <summary>
         ///// Compares ModifiedUserId used for sorting
         ///// </summary>
         //public static Comparison<PBilldetail> ByModifiedUserId = delegate(PBilldetail x, PBilldetail y)
         //{
         //    return Nullable.Compare(x.ModifiedUserId, y.ModifiedUserId);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<PBilldetail> ByIsDeleted = delegate(PBilldetail x, PBilldetail y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

         ///// <summary>
         ///// Compares Status used for sorting
         ///// </summary>
         //public static Comparison<PBilldetail> ByStatus = delegate(PBilldetail x, PBilldetail y)
         //{
         //    return Nullable.Compare(x.Status, y.Status);
         //};

     }
}
