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
     /// Base class for PCustomer.  Do not make changes to this class,
     /// instead, put additional code in the PCustomer class
     /// </summary>
     public class PCustomerBase : PCustomerModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public PCustomerBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static PCustomerModel SelectByPrimaryKey(int id)
         {
             return PCustomerDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the PCustomer table
         /// </summary>
         public static int GetRecordCount()
         {
             return PCustomerDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the PCustomer table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string name, string code, DateTime? birth, string address, string phone, string email, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
             return PCustomerDataLayer.GetRecordCountDynamicWhere(id, name, code, birth, address, phone, email, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
         }

         /// <summary>
         /// Selects records as a collection (List) of PCustomer sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<PCustomerModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return PCustomerDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PCustomer sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<PCustomerModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PCustomerDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PCustomer sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PCustomerModel> SelectSkipAndTakeDynamicWhere(int? id, string name, string code, DateTime? birth, string address, string phone, string email, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, name, code, birth, address, phone, email, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
             sortByExpression = GetSortExpression(sortByExpression);
             return PCustomerDataLayer.SelectSkipAndTakeDynamicWhere(id, name, code, birth, address, phone, email, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of PCustomer sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<PCustomerModel> SelectSkipAndTakeDynamicWhere(int? id, string name, string code, DateTime? birth, string address, string phone, string email, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return PCustomerDataLayer.SelectSkipAndTakeDynamicWhere(id, name, code, birth, address, phone, email, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of PCustomer
         /// </summary>
         public static List<PCustomerModel> SelectAll()
         {
             return PCustomerDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of PCustomer sorted by the sort expression
         /// </summary>
         public static List<PCustomerModel> SelectAll(string sortExpression)
         {
            List<PCustomerModel> objPCustomerCol = PCustomerDataLayer.SelectAll();
             return SortByExpression(objPCustomerCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PCustomer.
         /// </summary>
         public static List<PCustomerModel> SelectAllDynamicWhere(int? id, string name, string code, DateTime? birth, string address, string phone, string email, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status)
         {
             return PCustomerDataLayer.SelectAllDynamicWhere(id, name, code, birth, address, phone, email, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of PCustomer sorted by the sort expression.
         /// </summary>
         public static List<PCustomerModel> SelectAllDynamicWhere(int? id, string name, string code, DateTime? birth, string address, string phone, string email, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, bool? isDeleted, int? status, string sortExpression)
         {
            List<PCustomerModel> objPCustomerCol = PCustomerDataLayer.SelectAllDynamicWhere(id, name, code, birth, address, phone, email, createdDate, modifiedDate, createdUserId, modifiedUserId, isDeleted, status);
             return SortByExpression(objPCustomerCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and Name columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<PCustomerModel> SelectPCustomerDropDownListData()
         {
             return PCustomerDataLayer.SelectPCustomerDropDownListData();
         }

         /// <summary>
         /// Sorts the PCustomerCollection by sort expression
         /// </summary>
         public static List<PCustomerModel> SortByExpression(List<PCustomerModel> objPCustomerCol, string sortExpression)
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
             //        objPCustomerCol.Sort(Cms.BusinessObject.PCustomer.ById);
             //        break;
             //    case "Name":
             //        objPCustomerCol.Sort(Cms.BusinessObject.PCustomer.ByName);
             //        break;
             //    case "Code":
             //        objPCustomerCol.Sort(Cms.BusinessObject.PCustomer.ByCode);
             //        break;
             //    case "Birth":
             //        objPCustomerCol.Sort(Cms.BusinessObject.PCustomer.ByBirth);
             //        break;
             //    case "Address":
             //        objPCustomerCol.Sort(Cms.BusinessObject.PCustomer.ByAddress);
             //        break;
             //    case "Phone":
             //        objPCustomerCol.Sort(Cms.BusinessObject.PCustomer.ByPhone);
             //        break;
             //    case "Email":
             //        objPCustomerCol.Sort(Cms.BusinessObject.PCustomer.ByEmail);
             //        break;
             //    case "CreatedDate":
             //        objPCustomerCol.Sort(Cms.BusinessObject.PCustomer.ByCreatedDate);
             //        break;
             //    case "ModifiedDate":
             //        objPCustomerCol.Sort(Cms.BusinessObject.PCustomer.ByModifiedDate);
             //        break;
             //    case "CreatedUserId":
             //        objPCustomerCol.Sort(Cms.BusinessObject.PCustomer.ByCreatedUserId);
             //        break;
             //    case "ModifiedUserId":
             //        objPCustomerCol.Sort(Cms.BusinessObject.PCustomer.ByModifiedUserId);
             //        break;
             //    case "IsDeleted":
             //        objPCustomerCol.Sort(Cms.BusinessObject.PCustomer.ByIsDeleted);
             //        break;
             //    case "Status":
             //        objPCustomerCol.Sort(Cms.BusinessObject.PCustomer.ByStatus);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objPCustomerCol.Reverse();

             return objPCustomerCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            PCustomerModel objPCustomer = (PCustomerModel)this;
             return PCustomerDataLayer.Insert(objPCustomer);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            PCustomerModel objPCustomer = (PCustomerModel)this;
             PCustomerDataLayer.Update(objPCustomer);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             PCustomerDataLayer.Delete(id);
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
         //public static Comparison<PCustomer> ById = delegate(PCustomer x, PCustomer y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares Name used for sorting
         ///// </summary>
         //public static Comparison<PCustomer> ByName = delegate(PCustomer x, PCustomer y)
         //{
         //    string value1 = x.Name ?? String.Empty;
         //    string value2 = y.Name ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares Code used for sorting
         ///// </summary>
         //public static Comparison<PCustomer> ByCode = delegate(PCustomer x, PCustomer y)
         //{
         //    string value1 = x.Code ?? String.Empty;
         //    string value2 = y.Code ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares Birth used for sorting
         ///// </summary>
         //public static Comparison<PCustomer> ByBirth = delegate(PCustomer x, PCustomer y)
         //{
         //    return Nullable.Compare(x.Birth, y.Birth);
         //};

         ///// <summary>
         ///// Compares Address used for sorting
         ///// </summary>
         //public static Comparison<PCustomer> ByAddress = delegate(PCustomer x, PCustomer y)
         //{
         //    string value1 = x.Address ?? String.Empty;
         //    string value2 = y.Address ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares Phone used for sorting
         ///// </summary>
         //public static Comparison<PCustomer> ByPhone = delegate(PCustomer x, PCustomer y)
         //{
         //    string value1 = x.Phone ?? String.Empty;
         //    string value2 = y.Phone ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares Email used for sorting
         ///// </summary>
         //public static Comparison<PCustomer> ByEmail = delegate(PCustomer x, PCustomer y)
         //{
         //    string value1 = x.Email ?? String.Empty;
         //    string value2 = y.Email ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares CreatedDate used for sorting
         ///// </summary>
         //public static Comparison<PCustomer> ByCreatedDate = delegate(PCustomer x, PCustomer y)
         //{
         //    return Nullable.Compare(x.CreatedDate, y.CreatedDate);
         //};

         ///// <summary>
         ///// Compares ModifiedDate used for sorting
         ///// </summary>
         //public static Comparison<PCustomer> ByModifiedDate = delegate(PCustomer x, PCustomer y)
         //{
         //    return Nullable.Compare(x.ModifiedDate, y.ModifiedDate);
         //};

         ///// <summary>
         ///// Compares CreatedUserId used for sorting
         ///// </summary>
         //public static Comparison<PCustomer> ByCreatedUserId = delegate(PCustomer x, PCustomer y)
         //{
         //    return Nullable.Compare(x.CreatedUserId, y.CreatedUserId);
         //};

         ///// <summary>
         ///// Compares ModifiedUserId used for sorting
         ///// </summary>
         //public static Comparison<PCustomer> ByModifiedUserId = delegate(PCustomer x, PCustomer y)
         //{
         //    return Nullable.Compare(x.ModifiedUserId, y.ModifiedUserId);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<PCustomer> ByIsDeleted = delegate(PCustomer x, PCustomer y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

         ///// <summary>
         ///// Compares Status used for sorting
         ///// </summary>
         //public static Comparison<PCustomer> ByStatus = delegate(PCustomer x, PCustomer y)
         //{
         //    return Nullable.Compare(x.Status, y.Status);
         //};

     }
}
