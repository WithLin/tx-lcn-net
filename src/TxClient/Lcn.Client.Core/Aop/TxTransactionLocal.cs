using System;
using System.Collections.Concurrent;
using System.Threading;
using Lcn.TxClient.Core.Attribute;

namespace Lcn.TxClient.Core.Aop
{
    public class TxTransactionLocal
    {
        public  static AsyncLocal<TxTransactionLocal> CurrentLocal = new AsyncLocal<TxTransactionLocal>();

        public string GroupId;

        public int MaxTimeOut;

        private ConcurrentDictionary<string, string> CacheModelInfo = new ConcurrentDictionary<string, string>();

        /**
         * 是否同一个模块被多次请求
         */
        public bool HasIsGroup { get; set; }= false;

        /**
         * 是否是发起方模块
         */
        public bool HasStart { get; set; } = false;

        /**
         * 时候已经获取到连接对象
         */
        private bool HasConnection { get; set; } = false;


        private string Kid { get; set; }

        private string Type { get; set; }

        private bool ReadOnly { get; set; } = true;

        private TxTransactionMode Mode { get; set; }
    }
}