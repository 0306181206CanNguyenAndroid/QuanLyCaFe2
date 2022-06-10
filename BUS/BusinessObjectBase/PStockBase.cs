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
     /// Base class for PStock.  Do not make changes to this class,
     /// instead, put additional code in the PStock class
     /// </summary>
     public class PStockBase : PStockModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public PStockBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PStockModel SelectByPrimaryKey(int id)
         {
             return PStockDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the PStock table
         /// </summary>
         public static int GetRecordCount()
         {
             return PStockDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the PStock table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, int? productInfo, int? quantity, int? batchOfGoodsId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
             return PStockDataLayer.GetRecordCountDynamicWhere(id, productInfo, quantity, batchOfGoodsId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
         }

         /// <summary>
         /// Selects records as a collection (List) of PStock sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<PStockModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return PStockDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PStock sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<PStockModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PStockDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PStock sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PStockModel> SelectSkipAndTakeDynamicWhere(int? id, int? productInfo, int? quantity, int? batchOfGoodsId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, productInfo, quantity, batchOfGoodsId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
             sortByExpression = GetSortExpression(sortByExpression);
             return PStockDataLayer.SelectSkipAndTakeDynamicWhere(id, productInfo, quantity, batchOfGoodsId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PStock sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PStockModel> SelectSkipAndTakeDynamicWhere(int? id, int? productInfo, int? quantity, int? batchOfGoodsId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PStockDataLayer.SelectSkipAndTakeDynamicWhere(id, productInfo, quantity, batchOfGoodsId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of PStock
         /// </summary>
         public static List<PStockModel> SelectAll()
         {
             return PStockDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of PStock sorted by the sort expression
         /// </summary>
         public static List<PStockModel> SelectAll(string sortExpression)
         {
            List<PStockModel> objPStockCol = PStockDataLayer.SelectAll();
             return SortByExpression(objPStockCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PStock.
         /// </summary>
         public static List<PStockModel> SelectAllDynamicWhere(int? id, int? productInfo, int? quantity, int? batchOfGoodsId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
             return PStockDataLayer.SelectAllDynamicWhere(id, productInfo, quantity, batchOfGoodsId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PStock sorted by the sort expression.
         /// </summary>
         public static List<PStockModel> SelectAllDynamicWhere(int? id, int? productInfo, int? quantity, int? batchOfGoodsId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string sortExpression)
         {
            List<PStockModel> objPStockCol = PStockDataLayer.SelectAllDynamicWhere(id, productInfo, quantity, batchOfGoodsId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
             return SortByExpression(objPStockCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and ProductInfo columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<PStockModel> SelectPStockDropDownListData()
         {
             return PStockDataLayer.SelectPStockDropDownListData();
         }

         /// <summary>
         /// Sorts the PStockCollection by sort expression
         /// </summary>
         public static List<PStockModel> SortByExpression(List<PStockModel> objPStockCol, string sortExpression)
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
             //        objPStockCol.Sort(Cms.BusinessObject.PStock.ById);
             //        break;
             //    case "ProductInfo":
             //        objPStockCol.Sort(Cms.BusinessObject.PStock.ByProductInfo);
             //        break;
             //    case "Quantity":
             //        objPStockCol.Sort(Cms.BusinessObject.PStock.ByQuantity);
             //        break;
             //    case "BatchOfGoodsId":
             //        objPStockCol.Sort(Cms.BusinessObject.PStock.ByBatchOfGoodsId);
             //        break;
             //    case "CreatedDate":
             //        objPStockCol.Sort(Cms.BusinessObject.PStock.ByCreatedDate);
             //        break;
             //    case "ModifiedDate":
             //        objPStockCol.Sort(Cms.BusinessObject.PStock.ByModifiedDate);
             //        break;
             //    case "CreatedUserId":
             //        objPStockCol.Sort(Cms.BusinessObject.PStock.ByCreatedUserId);
             //        break;
             //    case "ModifiedUserId":
             //        objPStockCol.Sort(Cms.BusinessObject.PStock.ByModifiedUserId);
             //        break;
             //    case "IsDeleted":
             //        objPStockCol.Sort(Cms.BusinessObject.PStock.ByIsDeleted);
             //        break;
             //    case "Status":
             //        objPStockCol.Sort(Cms.BusinessObject.PStock.ByStatus);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objPStockCol.Reverse();

             return objPStockCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            PStockModel objPStock = (PStockModel)this;
             return PStockDataLayer.Insert(objPStock);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
             PStockModel objPStock = (PStockModel)this;
             PStockDataLayer.Update(objPStock);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             PStockDataLayer.Delete(id);
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
         //public static Comparison<PStock> ById = delegate(PStock x, PStock y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares ProductInfo used for sorting
         ///// </summary>
         //public static Comparison<PStock> ByProductInfo = delegate(PStock x, PStock y)
         //{
         //    return Nullable.Compare(x.ProductInfo, y.ProductInfo);
         //};

         ///// <summary>
         ///// Compares Quantity used for sorting
         ///// </summary>
         //public static Comparison<PStock> ByQuantity = delegate(PStock x, PStock y)
         //{
         //    return Nullable.Compare(x.Quantity, y.Quantity);
         //};

         ///// <summary>
         ///// Compares BatchOfGoodsId used for sorting
         ///// </summary>
         //public static Comparison<PStock> ByBatchOfGoodsId = delegate(PStock x, PStock y)
         //{
         //    return Nullable.Compare(x.BatchOfGoodsId, y.BatchOfGoodsId);
         //};

         ///// <summary>
         ///// Compares CreatedDate used for sorting
         ///// </summary>
         //public static Comparison<PStock> ByCreatedDate = delegate(PStock x, PStock y)
         //{
         //    return Nullable.Compare(x.CreatedDate, y.CreatedDate);
         //};

         ///// <summary>
         ///// Compares ModifiedDate used for sorting
         ///// </summary>
         //public static Comparison<PStock> ByModifiedDate = delegate(PStock x, PStock y)
         //{
         //    return Nullable.Compare(x.ModifiedDate, y.ModifiedDate);
         //};

         ///// <summary>
         ///// Compares CreatedUserId used for sorting
         ///// </summary>
         //public static Comparison<PStock> ByCreatedUserId = delegate(PStock x, PStock y)
         //{
         //    return Nullable.Compare(x.CreatedUserId, y.CreatedUserId);
         //};

         ///// <summary>
         ///// Compares ModifiedUserId used for sorting
         ///// </summary>
         //public static Comparison<PStock> ByModifiedUserId = delegate(PStock x, PStock y)
         //{
         //    return Nullable.Compare(x.ModifiedUserId, y.ModifiedUserId);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<PStock> ByIsDeleted = delegate(PStock x, PStock y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

         ///// <summary>
         ///// Compares Status used for sorting
         ///// </summary>
         //public static Comparison<PStock> ByStatus = delegate(PStock x, PStock y)
         //{
         //    return Nullable.Compare(x.Status, y.Status);
         //};

     }
}
