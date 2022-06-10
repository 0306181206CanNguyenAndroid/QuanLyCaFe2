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
     /// Base class for PImportgoodsdetail.  Do not make changes to this class,
     /// instead, put additional code in the PImportgoodsdetail class
     /// </summary>
     public class PImportgoodsdetailBase : PImportgoodsdetailModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public PImportgoodsdetailBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PImportgoodsdetailModel SelectByPrimaryKey(int id)
         {
             return PImportgoodsdetailDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the PImportgoodsdetail table
         /// </summary>
         public static int GetRecordCount()
         {
             return PImportgoodsdetailDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the PImportgoodsdetail table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, int? importGoodsId, int? productInfo, DateTime? manuDate, DateTime? expiryDate, string productNumber, string productCode, int? productTypeId, int? importQuantity, bool? isDeleted, int? status)
         {
             return PImportgoodsdetailDataLayer.GetRecordCountDynamicWhere(id, importGoodsId, productInfo, manuDate, expiryDate, productNumber, productCode, productTypeId, importQuantity, isDeleted, status);
         }

         /// <summary>
         /// Selects records as a collection (List) of PImportgoodsdetail sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<PImportgoodsdetailModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return PImportgoodsdetailDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PImportgoodsdetail sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<PImportgoodsdetailModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PImportgoodsdetailDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PImportgoodsdetail sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PImportgoodsdetailModel> SelectSkipAndTakeDynamicWhere(int? id, int? importGoodsId, int? productInfo, DateTime? manuDate, DateTime? expiryDate, string productNumber, string productCode, int? productTypeId, int? importQuantity, bool? isDeleted, int? status, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, importGoodsId, productInfo, manuDate, expiryDate, productNumber, productCode, productTypeId, importQuantity, isDeleted, status);
             sortByExpression = GetSortExpression(sortByExpression);
             return PImportgoodsdetailDataLayer.SelectSkipAndTakeDynamicWhere(id, importGoodsId, productInfo, manuDate, expiryDate, productNumber, productCode, productTypeId, importQuantity, isDeleted, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PImportgoodsdetail sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PImportgoodsdetailModel> SelectSkipAndTakeDynamicWhere(int? id, int? importGoodsId, int? productInfo, DateTime? manuDate, DateTime? expiryDate, string productNumber, string productCode, int? productTypeId, int? importQuantity, bool? isDeleted, int? status, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PImportgoodsdetailDataLayer.SelectSkipAndTakeDynamicWhere(id, importGoodsId, productInfo, manuDate, expiryDate, productNumber, productCode, productTypeId, importQuantity, isDeleted, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of PImportgoodsdetail
         /// </summary>
         public static List<PImportgoodsdetailModel> SelectAll()
         {
             return PImportgoodsdetailDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of PImportgoodsdetail sorted by the sort expression
         /// </summary>
         public static List<PImportgoodsdetailModel> SelectAll(string sortExpression)
         {
            List<PImportgoodsdetailModel> objPImportgoodsdetailCol = PImportgoodsdetailDataLayer.SelectAll();
             return SortByExpression(objPImportgoodsdetailCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PImportgoodsdetail.
         /// </summary>
         public static List<PImportgoodsdetailModel> SelectAllDynamicWhere(int? id, int? importGoodsId, int? productInfo, DateTime? manuDate, DateTime? expiryDate, string productNumber, string productCode, int? productTypeId, int? importQuantity, bool? isDeleted, int? status)
         {
             return PImportgoodsdetailDataLayer.SelectAllDynamicWhere(id, importGoodsId, productInfo, manuDate, expiryDate, productNumber, productCode, productTypeId, importQuantity, isDeleted, status);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PImportgoodsdetail sorted by the sort expression.
         /// </summary>
         public static List<PImportgoodsdetailModel> SelectAllDynamicWhere(int? id, int? importGoodsId, int? productInfo, DateTime? manuDate, DateTime? expiryDate, string productNumber, string productCode, int? productTypeId, int? importQuantity, bool? isDeleted, int? status, string sortExpression)
         {
            List<PImportgoodsdetailModel> objPImportgoodsdetailCol = PImportgoodsdetailDataLayer.SelectAllDynamicWhere(id, importGoodsId, productInfo, manuDate, expiryDate, productNumber, productCode, productTypeId, importQuantity, isDeleted, status);
             return SortByExpression(objPImportgoodsdetailCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and ProductNumber columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<PImportgoodsdetailModel> SelectPImportgoodsdetailDropDownListData()
         {
             return PImportgoodsdetailDataLayer.SelectPImportgoodsdetailDropDownListData();
         }

         /// <summary>
         /// Sorts the PImportgoodsdetailCollection by sort expression
         /// </summary>
         public static List<PImportgoodsdetailModel> SortByExpression(List<PImportgoodsdetailModel> objPImportgoodsdetailCol, string sortExpression)
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
             //        objPImportgoodsdetailCol.Sort(Cms.BusinessObject.PImportgoodsdetail.ById);
             //        break;
             //    case "ImportGoodsId":
             //        objPImportgoodsdetailCol.Sort(Cms.BusinessObject.PImportgoodsdetail.ByImportGoodsId);
             //        break;
             //    case "ProductInfo":
             //        objPImportgoodsdetailCol.Sort(Cms.BusinessObject.PImportgoodsdetail.ByProductInfo);
             //        break;
             //    case "ManuDate":
             //        objPImportgoodsdetailCol.Sort(Cms.BusinessObject.PImportgoodsdetail.ByManuDate);
             //        break;
             //    case "ExpiryDate":
             //        objPImportgoodsdetailCol.Sort(Cms.BusinessObject.PImportgoodsdetail.ByExpiryDate);
             //        break;
             //    case "ProductNumber":
             //        objPImportgoodsdetailCol.Sort(Cms.BusinessObject.PImportgoodsdetail.ByProductNumber);
             //        break;
             //    case "ProductCode":
             //        objPImportgoodsdetailCol.Sort(Cms.BusinessObject.PImportgoodsdetail.ByProductCode);
             //        break;
             //    case "ProductTypeId":
             //        objPImportgoodsdetailCol.Sort(Cms.BusinessObject.PImportgoodsdetail.ByProductTypeId);
             //        break;
             //    case "ImportQuantity":
             //        objPImportgoodsdetailCol.Sort(Cms.BusinessObject.PImportgoodsdetail.ByImportQuantity);
             //        break;
             //    case "IsDeleted":
             //        objPImportgoodsdetailCol.Sort(Cms.BusinessObject.PImportgoodsdetail.ByIsDeleted);
             //        break;
             //    case "Status":
             //        objPImportgoodsdetailCol.Sort(Cms.BusinessObject.PImportgoodsdetail.ByStatus);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objPImportgoodsdetailCol.Reverse();

             return objPImportgoodsdetailCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            PImportgoodsdetailModel objPImportgoodsdetail = (PImportgoodsdetailModel)this;
             return PImportgoodsdetailDataLayer.Insert(objPImportgoodsdetail);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            PImportgoodsdetailModel objPImportgoodsdetail = (PImportgoodsdetailModel)this;
             PImportgoodsdetailDataLayer.Update(objPImportgoodsdetail);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             PImportgoodsdetailDataLayer.Delete(id);
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
         //public static Comparison<PImportgoodsdetail> ById = delegate(PImportgoodsdetail x, PImportgoodsdetail y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares ImportGoodsId used for sorting
         ///// </summary>
         //public static Comparison<PImportgoodsdetail> ByImportGoodsId = delegate(PImportgoodsdetail x, PImportgoodsdetail y)
         //{
         //    return Nullable.Compare(x.ImportGoodsId, y.ImportGoodsId);
         //};

         ///// <summary>
         ///// Compares ProductInfo used for sorting
         ///// </summary>
         //public static Comparison<PImportgoodsdetail> ByProductInfo = delegate(PImportgoodsdetail x, PImportgoodsdetail y)
         //{
         //    return Nullable.Compare(x.ProductInfo, y.ProductInfo);
         //};

         ///// <summary>
         ///// Compares ManuDate used for sorting
         ///// </summary>
         //public static Comparison<PImportgoodsdetail> ByManuDate = delegate(PImportgoodsdetail x, PImportgoodsdetail y)
         //{
         //    return Nullable.Compare(x.ManuDate, y.ManuDate);
         //};

         ///// <summary>
         ///// Compares ExpiryDate used for sorting
         ///// </summary>
         //public static Comparison<PImportgoodsdetail> ByExpiryDate = delegate(PImportgoodsdetail x, PImportgoodsdetail y)
         //{
         //    return Nullable.Compare(x.ExpiryDate, y.ExpiryDate);
         //};

         ///// <summary>
         ///// Compares ProductNumber used for sorting
         ///// </summary>
         //public static Comparison<PImportgoodsdetail> ByProductNumber = delegate(PImportgoodsdetail x, PImportgoodsdetail y)
         //{
         //    string value1 = x.ProductNumber ?? String.Empty;
         //    string value2 = y.ProductNumber ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares ProductCode used for sorting
         ///// </summary>
         //public static Comparison<PImportgoodsdetail> ByProductCode = delegate(PImportgoodsdetail x, PImportgoodsdetail y)
         //{
         //    string value1 = x.ProductCode ?? String.Empty;
         //    string value2 = y.ProductCode ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares ProductTypeId used for sorting
         ///// </summary>
         //public static Comparison<PImportgoodsdetail> ByProductTypeId = delegate(PImportgoodsdetail x, PImportgoodsdetail y)
         //{
         //    return Nullable.Compare(x.ProductTypeId, y.ProductTypeId);
         //};

         ///// <summary>
         ///// Compares ImportQuantity used for sorting
         ///// </summary>
         //public static Comparison<PImportgoodsdetail> ByImportQuantity = delegate(PImportgoodsdetail x, PImportgoodsdetail y)
         //{
         //    return Nullable.Compare(x.ImportQuantity, y.ImportQuantity);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<PImportgoodsdetail> ByIsDeleted = delegate(PImportgoodsdetail x, PImportgoodsdetail y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

         ///// <summary>
         ///// Compares Status used for sorting
         ///// </summary>
         //public static Comparison<PImportgoodsdetail> ByStatus = delegate(PImportgoodsdetail x, PImportgoodsdetail y)
         //{
         //    return Nullable.Compare(x.Status, y.Status);
         //};

     }
}
