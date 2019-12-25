using System;
using System.Collections.Generic;
using System.Text;

namespace HRIS.DL.manageEmployees
{
   public class AddressDL
    {
        public long Insert(EL. purchaseOrder)
        {
            return Helper.executeNonQueryLong("insert into purchaseorders (supplierid, accountid, purchaseordername, purchasedatecreated, purchasedaterecieved, purchasestatus, purchasetotalamount) values ('" + purchaseOrder.Supplierid + "', '" + purchaseOrder.Accountid + "', '" + purchaseOrder.Purchaseordername + "', '" + purchaseOrder.Purchasedatecreated + "', '" + purchaseOrder.Purchasedaterecieved + "', '" + purchaseOrder.Purchasestatus + "', '" + purchaseOrder.Purchasetotalammount + "')");
        }

    }
}
