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
     /// Base class for SystemStaff.  Do not make changes to this class,
     /// instead, put additional code in the SystemStaff class
     /// </summary>
     public class SystemStaffBase : SystemStaffModel
     {

         /// <summary>
         /// Constructor
         /// </summary>
         public SystemStaffBase()
         {
         }

         /// <summary>
         /// Selects a record by primary key(s)
         /// </summary>
         public static SystemStaffModel SelectByPrimaryKey(int id)
         {
             return SystemStaffDataLayer.SelectByPrimaryKey(id);
         }

         /// <summary>
         /// Gets the total number of records in the SystemStaff table
         /// </summary>
         public static int GetRecordCount()
         {
             return SystemStaffDataLayer.GetRecordCount();
         }

         /// <summary>
         /// Gets the total number of records in the SystemStaff table based on search parameters
         /// </summary>
         public static int GetRecordCountDynamicWhere(int? id, string firstName, string lastName, string fullName, DateTime? birth, string address, string image, string phone, string email, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, int? positionId, bool? isDeleted, int? status)
         {
             return SystemStaffDataLayer.GetRecordCountDynamicWhere(id, firstName, lastName, fullName, birth, address, image, phone, email, createdDate, modifiedDate, createdUserId, modifiedUserId, positionId, isDeleted, status);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemStaff sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex
         /// </summary>
         public static List<SystemStaffModel> SelectSkipAndTake(int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCount();
             sortByExpression = GetSortExpression(sortByExpression);

             return SystemStaffDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemStaff sorted by the sortByExpression starting from the startRowIndex.
         /// </summary>
         public static List<SystemStaffModel> SelectSkipAndTake(int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemStaffDataLayer.SelectSkipAndTake(sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemStaff sorted by the sortByExpression and returns the rows (# of records) starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<SystemStaffModel> SelectSkipAndTakeDynamicWhere(int? id, string firstName, string lastName, string fullName, DateTime? birth, string address, string image, string phone, string email, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, int? positionId, bool? isDeleted, int? status, int rows, int startRowIndex, out int totalRowCount, string sortByExpression)
         {
             totalRowCount = GetRecordCountDynamicWhere(id, firstName, lastName, fullName, birth, address, image, phone, email, createdDate, modifiedDate, createdUserId, modifiedUserId, positionId, isDeleted, status);
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemStaffDataLayer.SelectSkipAndTakeDynamicWhere(id, firstName, lastName, fullName, birth, address, image, phone, email, createdDate, modifiedDate, createdUserId, modifiedUserId, positionId, isDeleted, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects records as a collection (List) of SystemStaff sorted by the sortByExpression starting from the startRowIndex, based on the search parameters
         /// </summary>
         public static List<SystemStaffModel> SelectSkipAndTakeDynamicWhere(int? id, string firstName, string lastName, string fullName, DateTime? birth, string address, string image, string phone, string email, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, int? positionId, bool? isDeleted, int? status, int rows, int startRowIndex, string sortByExpression)
         {
             sortByExpression = GetSortExpression(sortByExpression);
             return SystemStaffDataLayer.SelectSkipAndTakeDynamicWhere(id, firstName, lastName, fullName, birth, address, image, phone, email, createdDate, modifiedDate, createdUserId, modifiedUserId, positionId, isDeleted, status, sortByExpression, startRowIndex, rows);
         }

         /// <summary>
         /// Selects all records as a collection (List) of SystemStaff
         /// </summary>
         public static List<SystemStaffModel> SelectAll()
         {
             return SystemStaffDataLayer.SelectAll();
         }

         /// <summary>
         /// Selects all records as a collection (List) of SystemStaff sorted by the sort expression
         /// </summary>
         public static List<SystemStaffModel> SelectAll(string sortExpression)
         {
            List<SystemStaffModel> objSystemStaffCol = SystemStaffDataLayer.SelectAll();
             return SortByExpression(objSystemStaffCol, sortExpression);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemStaff.
         /// </summary>
         public static List<SystemStaffModel> SelectAllDynamicWhere(int? id, string firstName, string lastName, string fullName, DateTime? birth, string address, string image, string phone, string email, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, int? positionId, bool? isDeleted, int? status)
         {
             return SystemStaffDataLayer.SelectAllDynamicWhere(id, firstName, lastName, fullName, birth, address, image, phone, email, createdDate, modifiedDate, createdUserId, modifiedUserId, positionId, isDeleted, status);
         }

         /// <summary>
         /// Selects records based on the passed filters as a collection (List) of SystemStaff sorted by the sort expression.
         /// </summary>
         public static List<SystemStaffModel> SelectAllDynamicWhere(int? id, string firstName, string lastName, string fullName, DateTime? birth, string address, string image, string phone, string email, DateTime? createdDate, DateTime? modifiedDate, int? createdUserId, int? modifiedUserId, int? positionId, bool? isDeleted, int? status, string sortExpression)
         {
            List<SystemStaffModel> objSystemStaffCol = SystemStaffDataLayer.SelectAllDynamicWhere(id, firstName, lastName, fullName, birth, address, image, phone, email, createdDate, modifiedDate, createdUserId, modifiedUserId, positionId, isDeleted, status);
             return SortByExpression(objSystemStaffCol, sortExpression);
         }

         /// <summary>
         /// Selects Id and FirstName columns for use with a DropDownList web control, ComboBox, CheckedBoxList, ListView, ListBox, etc
         /// </summary>
         public static List<SystemStaffModel> SelectSystemStaffDropDownListData()
         {
             return SystemStaffDataLayer.SelectSystemStaffDropDownListData();
         }

         /// <summary>
         /// Sorts the SystemStaffCollection by sort expression
         /// </summary>
         public static List<SystemStaffModel> SortByExpression(List<SystemStaffModel> objSystemStaffCol, string sortExpression)
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
             //        objSystemStaffCol.Sort(Cms.BusinessObject.SystemStaff.ById);
             //        break;
             //    case "FirstName":
             //        objSystemStaffCol.Sort(Cms.BusinessObject.SystemStaff.ByFirstName);
             //        break;
             //    case "LastName":
             //        objSystemStaffCol.Sort(Cms.BusinessObject.SystemStaff.ByLastName);
             //        break;
             //    case "FullName":
             //        objSystemStaffCol.Sort(Cms.BusinessObject.SystemStaff.ByFullName);
             //        break;
             //    case "Birth":
             //        objSystemStaffCol.Sort(Cms.BusinessObject.SystemStaff.ByBirth);
             //        break;
             //    case "Address":
             //        objSystemStaffCol.Sort(Cms.BusinessObject.SystemStaff.ByAddress);
             //        break;
             //    case "Image":
             //        objSystemStaffCol.Sort(Cms.BusinessObject.SystemStaff.ByImage);
             //        break;
             //    case "Phone":
             //        objSystemStaffCol.Sort(Cms.BusinessObject.SystemStaff.ByPhone);
             //        break;
             //    case "Email":
             //        objSystemStaffCol.Sort(Cms.BusinessObject.SystemStaff.ByEmail);
             //        break;
             //    case "CreatedDate":
             //        objSystemStaffCol.Sort(Cms.BusinessObject.SystemStaff.ByCreatedDate);
             //        break;
             //    case "ModifiedDate":
             //        objSystemStaffCol.Sort(Cms.BusinessObject.SystemStaff.ByModifiedDate);
             //        break;
             //    case "CreatedUserId":
             //        objSystemStaffCol.Sort(Cms.BusinessObject.SystemStaff.ByCreatedUserId);
             //        break;
             //    case "ModifiedUserId":
             //        objSystemStaffCol.Sort(Cms.BusinessObject.SystemStaff.ByModifiedUserId);
             //        break;
             //    case "PositionId":
             //        objSystemStaffCol.Sort(Cms.BusinessObject.SystemStaff.ByPositionId);
             //        break;
             //    case "IsDeleted":
             //        objSystemStaffCol.Sort(Cms.BusinessObject.SystemStaff.ByIsDeleted);
             //        break;
             //    case "Status":
             //        objSystemStaffCol.Sort(Cms.BusinessObject.SystemStaff.ByStatus);
             //        break;
             //    default:
             //        break;
             //}

             //if (isSortDescending)
             //    objSystemStaffCol.Reverse();

             return objSystemStaffCol;
         }

         /// <summary>
         /// Inserts a record
         /// </summary>
         public int Insert()
         {
            SystemStaffModel objSystemStaff = (SystemStaffModel)this;
             return SystemStaffDataLayer.Insert(objSystemStaff);
         }

         /// <summary>
         /// Updates a record
         /// </summary>
         public void Update()
         {
            SystemStaffModel objSystemStaff = (SystemStaffModel)this;
             SystemStaffDataLayer.Update(objSystemStaff);
         }

         /// <summary>
         /// Deletes a record based on primary key(s)
         /// </summary>
         public static void Delete(int id)
         {
             SystemStaffDataLayer.Delete(id);
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
         //public static Comparison<SystemStaff> ById = delegate(SystemStaff x, SystemStaff y)
         //{
         //    return x.Id.CompareTo(y.Id);
         //};

         ///// <summary>
         ///// Compares FirstName used for sorting
         ///// </summary>
         //public static Comparison<SystemStaff> ByFirstName = delegate(SystemStaff x, SystemStaff y)
         //{
         //    string value1 = x.FirstName ?? String.Empty;
         //    string value2 = y.FirstName ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares LastName used for sorting
         ///// </summary>
         //public static Comparison<SystemStaff> ByLastName = delegate(SystemStaff x, SystemStaff y)
         //{
         //    string value1 = x.LastName ?? String.Empty;
         //    string value2 = y.LastName ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares FullName used for sorting
         ///// </summary>
         //public static Comparison<SystemStaff> ByFullName = delegate(SystemStaff x, SystemStaff y)
         //{
         //    string value1 = x.FullName ?? String.Empty;
         //    string value2 = y.FullName ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares Birth used for sorting
         ///// </summary>
         //public static Comparison<SystemStaff> ByBirth = delegate(SystemStaff x, SystemStaff y)
         //{
         //    return Nullable.Compare(x.Birth, y.Birth);
         //};

         ///// <summary>
         ///// Compares Address used for sorting
         ///// </summary>
         //public static Comparison<SystemStaff> ByAddress = delegate(SystemStaff x, SystemStaff y)
         //{
         //    string value1 = x.Address ?? String.Empty;
         //    string value2 = y.Address ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares Image used for sorting
         ///// </summary>
         //public static Comparison<SystemStaff> ByImage = delegate(SystemStaff x, SystemStaff y)
         //{
         //    string value1 = x.Image ?? String.Empty;
         //    string value2 = y.Image ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares Phone used for sorting
         ///// </summary>
         //public static Comparison<SystemStaff> ByPhone = delegate(SystemStaff x, SystemStaff y)
         //{
         //    string value1 = x.Phone ?? String.Empty;
         //    string value2 = y.Phone ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares Email used for sorting
         ///// </summary>
         //public static Comparison<SystemStaff> ByEmail = delegate(SystemStaff x, SystemStaff y)
         //{
         //    string value1 = x.Email ?? String.Empty;
         //    string value2 = y.Email ?? String.Empty;
         //    return value1.CompareTo(value2);
         //};

         ///// <summary>
         ///// Compares CreatedDate used for sorting
         ///// </summary>
         //public static Comparison<SystemStaff> ByCreatedDate = delegate(SystemStaff x, SystemStaff y)
         //{
         //    return Nullable.Compare(x.CreatedDate, y.CreatedDate);
         //};

         ///// <summary>
         ///// Compares ModifiedDate used for sorting
         ///// </summary>
         //public static Comparison<SystemStaff> ByModifiedDate = delegate(SystemStaff x, SystemStaff y)
         //{
         //    return Nullable.Compare(x.ModifiedDate, y.ModifiedDate);
         //};

         ///// <summary>
         ///// Compares CreatedUserId used for sorting
         ///// </summary>
         //public static Comparison<SystemStaff> ByCreatedUserId = delegate(SystemStaff x, SystemStaff y)
         //{
         //    return Nullable.Compare(x.CreatedUserId, y.CreatedUserId);
         //};

         ///// <summary>
         ///// Compares ModifiedUserId used for sorting
         ///// </summary>
         //public static Comparison<SystemStaff> ByModifiedUserId = delegate(SystemStaff x, SystemStaff y)
         //{
         //    return Nullable.Compare(x.ModifiedUserId, y.ModifiedUserId);
         //};

         ///// <summary>
         ///// Compares PositionId used for sorting
         ///// </summary>
         //public static Comparison<SystemStaff> ByPositionId = delegate(SystemStaff x, SystemStaff y)
         //{
         //    return Nullable.Compare(x.PositionId, y.PositionId);
         //};

         ///// <summary>
         ///// Compares IsDeleted used for sorting
         ///// </summary>
         //public static Comparison<SystemStaff> ByIsDeleted = delegate(SystemStaff x, SystemStaff y)
         //{
         //    return x.IsDeleted.CompareTo(y.IsDeleted);
         //};

         ///// <summary>
         ///// Compares Status used for sorting
         ///// </summary>
         //public static Comparison<SystemStaff> ByStatus = delegate(SystemStaff x, SystemStaff y)
         //{
         //    return Nullable.Compare(x.Status, y.Status);
         //};

     }
}
