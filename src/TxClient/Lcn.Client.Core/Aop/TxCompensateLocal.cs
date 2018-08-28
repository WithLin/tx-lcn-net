using System.Threading;

namespace Lcn.TxClient.Core.Aop
{
    /// <summary>
    /// 分布式事务远程调用控制对象
    /// </summary>
    public class TxCompensateLocal
    {
        public static AsyncLocal<TxCompensateLocal> CurrentLocal = new AsyncLocal<TxCompensateLocal>();

        public string GroupId { get; set; }

        private string Type { get; set; }

        public int StartState { get; set; }
    }
}
