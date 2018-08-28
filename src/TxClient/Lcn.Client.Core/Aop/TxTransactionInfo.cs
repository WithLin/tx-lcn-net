using System;
using Lcn.TxClient.Core.Attribute;
using Lcn.TxClient.Core.Model;

namespace Lcn.TxClient.Core.Aop
{
    public class TxTransactionInfo
    {
        public TxTransactionAttribute Transaction { get; set; }


        public TxTransactionLocal TxTransactionLocal { get; set; }

        /**
         * 事务组Id
         */
        public string TxGroupId { get; set; }


        public TransactionInvocation Invocation { get; set; }

        public TxTransactionMode Mode { get; set; }


        public TxTransactionInfo(TxTransactionAttribute transaction, TxTransactionLocal txTransactionLocal, TransactionInvocation invocation, string txGroupId)
        {
            Transaction = transaction;
            TxTransactionLocal = txTransactionLocal;
            TxGroupId = txGroupId;
            Invocation = invocation;
        }
    }
}