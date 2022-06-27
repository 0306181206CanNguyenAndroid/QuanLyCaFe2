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
     /// Base class for PProduct.  Do not make changes to this class,
     /// instead, put additional code in the PProduct class
     /// </summary>
     public class PProductBase : PProductModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public PProductBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PProductModel SelectByPrimaryKey(int id)
         {
             return PProductDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the PProduct table
         /// </summary>
         public static int GetRecordCount()
         {
             return PProductDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the PProduct table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string name, string description, int? manuId, int? productTypeId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string productCode, int? discount, decimal? price)
         {
             return PProductDataLayer.GetRecordCountDynamicWhere(id, name, description, manuId, productTypeId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, productCode, discount, price);
         }

         /// <summary>
         /// Selects records as a collection (List) of PProduct sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<PProductModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return PProductDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PProduct sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<PProductModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PProductDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PProduct sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PProductModel> SelectSkipAndTakeDynamicWhere(int? id, string name, string description, int? manuId, int? productTypeId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string productCode, int? discount, decimal? price, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, name, description, manuId, productTypeId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, productCode, discount, price);
             sortByExpression = GetSortExpression(sortByExpression);
             return PProductDataLayer.SelectSkipAndTakeDynamicWhere(id, name, description, manuId, productTypeId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, productCode, discount, price, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PProduct sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PProductModel> SelectSkipAndTakeDynamicWhere(int? id, string name, string description, int? manuId, int? productTypeId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string productCode, int? discount, decimal? price, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PProductDataLayer.SelectSkipAndTakeDynamicWhere(id, name, description, manuId, productTypeId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, productCode, discount, price, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of PProduct
         /// </summary>
         public static List<PProductModel> SelectAll()
         {
             return PProductDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of PProduct sorted by the sort expression
         /// </summary>
         public static List<PProductModel> SelectAll(string sortExpression)
         {
            List<PProductModel> objPProductCol = PProductDataLayer.SelectAll();
             return SortByExpression(objPProductCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PProduct.
         /// </summary>
         public static List<PProductModel> SelectAllDynamicWhere(int? id, string name, string description, int? manuId, int? productTypeId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string productCode, int? discount, decimal? price)
         {
             return PProductDataLayer.SelectAllDynamicWhere(id, name, description, manuId, productTypeId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, productCode, discount, price);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PProduct sorted by the sort expression.
         /// </summary>
         public static List<PProductModel> SelectAllDynamicWhere(int? id, string name, string description, int? manuId, int? productTypeId, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string productCode, int? discount, decimal? price, string sortExpression)
         {
            List<PProductModel> objPProductCol = PProductDataLayer.SelectAllDynamicWhere(id, name, description, manuId, productTypeId, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, productCode, discount, price);
             return SortByExpression(objPProductCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and Name columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<PProductModel> SelectPProductDropDownListData()
         {
             return PProductDataLayer.SelectPProductDropDownListData();
         }

         /// <summary>
         /// Sorts the PProductCollection by sort expression
         /// </summary>
         public static List<PProductModel> SortByExpression(List<PProductModel> objPProductCol, string sortExpression)
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
             //        objPProductCol.Sort(Cms.BusinessObject.PProduct.ById);
             //        break;
             //    case "Name":
             //        objPProductCol.Sort(Cms.BusinessObject.PProduct.ByName);
             //        break;
             //    case "Description":
             //        objPProductCol.Sort(Cms.BusinessObject.PProduct.ByDescription);
             //        break;
             //    case "ManuId":
             //        objPProductCol.Sort(Cms.BusinessObject.PProduct.ByManuId);
             //        break;
             //    case "ProductTypeId":
             //        objPProductCol.Sort(Cms.BusinessObject.PProduct.ByProductTypeId);
             //        break;
             //    case "CreatedDate":
             //        objPProductCol.Sort(Cms.BusinessObject.PProduct.ByCreatedDate);
             //        break;
             //    case "ModifiedDate":
             //        objPProductCol.Sort(Cms.BusinessObject.PProduct.ByModifiedDate);
             //        break;
             //    case "CreatedUserId":
             //        objPProductCol.Sort(Cms.BusinessObject.PProduct.ByCreatedUserId);
             //        break;
             //    case "ModifiedUserId":
             //        objPProductCol.Sort(Cms.BusinessObject.PProduct.ByModifiedUserId);
             //        break;
             //    case "IsDeleted":
             //        objPProductCol.Sort(Cms.BusinessObject.PProduct.ByIsDeleted);
             //        break;
             //    case "Status":
             //        objPProductCol.Sort(Cms.BusinessObject.PProduct.ByStatus);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objPProductCol.Reverse();

             return objPProductCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            PProductModel objPProduct = (PProductModel)this;
             return PProductDataLayer.Insert(objPProduct);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            PProductModel objPProduct = (PProductModel)this;
             PProductDataLayer.Update(objPProduct);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             PProductDataLayer.Delete(id);
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
         //public static Comparison<PProduct> ById = delegate(PProduct x, PProduct y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares Name used for sorting
         ///// </summary>
         //public static Comparison<PProduct> ByName = delegate(PProduct x, PProduct y)
         //{
         //    string value1 = x.Name ?? String.Empty;
         //    string value2 = y.Name ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares Description used for sorting
         ///// </summary>
         //public static Comparison<PProduct> ByDescription = delegate(PProduct x, PProduct y)
         //{
         //    string value1 = x.Description ?? String.Empty;
         //    string value2 = y.Description ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares ManuId used for sorting
         ///// </summary>
         //public static Comparison<PProduct> ByManuId = delegate(PProduct x, PProduct y)
         //{
         //    return Nullable.Compare(x.ManuId, y.ManuId);
         //};

         ///// <summary>
         ///// Compares ProductTypeId used for sorting
         ///// </summary>
         //public static Comparison<PProduct> ByProductTypeId = delegate(PProduct x, PProduct y)
         //{
         //    return Nullable.Compare(x.ProductTypeId, y.ProductTypeId);
         //};

         ///// <summary>
         ///// Compares CreatedDate used for sorting
         ///// </summary>
         //public static Comparison<PProduct> ByCreatedDate = delegate(PProduct x, PProduct y)
         //{
         //    return Nullable.Compare(x.CreatedDate, y.CreatedDate);
         //};

         ///// <summary>
         ///// Compares ModifiedDate used for sorting
         ///// </summary>
         //public static Comparison<PProduct> ByModifiedDate = delegate(PProduct x, PProduct y)
         //{
         //    return Nullable.Compare(x.ModifiedDate, y.ModifiedDate);
         //};

         ///// <summary>
         ///// Compares CreatedUserId used for sorting
         ///// </summary>
         //public static Comparison<PProduct> ByCreatedUserId = delegate(PProduct x, PProduct y)
         //{
         //    return Nullable.Compare(x.CreatedUserId, y.CreatedUserId);
         //};

         ///// <summary>
         ///// Compares ModifiedUserId used for sorting
         ///// </summary>
         //public static Comparison<PProduct> ByModifiedUserId = delegate(PProduct x, PProduct y)
         //{
         //    return Nullable.Compare(x.ModifiedUserId, y.ModifiedUserId);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<PProduct> ByIsDeleted = delegate(PProduct x, PProduct y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

         ///// <summary>
         ///// Compares Status used for sorting
         ///// </summary>
         //public static Comparison<PProduct> ByStatus = delegate(PProduct x, PProduct y)
         //{
         //    return Nullable.Compare(x.Status, y.Status);
         //};

     }
}
