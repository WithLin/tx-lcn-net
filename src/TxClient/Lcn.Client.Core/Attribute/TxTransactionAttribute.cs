using System;
using System.Collections.Generic;
using System.Text;

namespace Lcn.TxClient.Core.Attribute
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Method)]
    public class TxTransactionAttribute : System.Attribute
    {
        /**
         * 是否LCN事务发起方
         * @return true 是:是发起方 false 否:是参与方
         */
        public bool IsStart { get; set; } = false;
        /**
        * 回滚异常
        * @return
        */
        public Exception[] RollbackFor { get; set; } = { };
        /**
        * 不回滚异常
        * @return
        */
        public Exception[] NoRollbackFor { get; set; } = { };

        /**
        * 事务模式 仅在事务发起方配置有效
        * @return
        */
        public TxTransactionMode Mode { get; set; } = TxTransactionMode.TX_MODE_LCN;
        /**
        * 标示本服务是否是只读
        * 若为true : 不会加入事务组; Connection 不会被 Wrap; 事务信息能正常传递
        * 在本服务无DB操作或仅有查询时请配置 true 将提高性能
        * 若应用都没有DB配置，此配置无意义不用设值
        */
        public bool ReadOnly { get; set; } = false;

    }
}
