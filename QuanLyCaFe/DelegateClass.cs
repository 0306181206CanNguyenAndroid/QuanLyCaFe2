using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe
{
    public delegate void FireEventForActionBillsSuccess(object sender, ActionBillsSuccessEventArgs e);
    public delegate void FireEventForActionAccountsSuccess(object sender, ActionAccountsSuccessEventArgs e);
    public delegate void FireEventForAction_RequestBills(object sender, RequestBillsSuccessEventArgs e);
    public delegate void FireEventForAction_RequestEmplyeesManage(object sender, RequestEmplyeesManageSuccessEventArgs e);
    public delegate void FireEventForAction_LogoutSuccess(object sender, Action_LogoutSuccessEventArgs e);
    
    public class Action_LogoutSuccessEventArgs : EventArgs
    {

    }

    public class ActionBillsSuccessEventArgs : EventArgs
    {
        
    }
    public class ActionAccountsSuccessEventArgs : EventArgs
    {

    }

    public class RequestBillsSuccessEventArgs : EventArgs
    {

    }

    public class RequestEmplyeesManageSuccessEventArgs
    {
    }

}
