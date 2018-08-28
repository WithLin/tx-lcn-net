using System;
using System.Collections.Generic;
using System.Text;

namespace Lcn.TxClient.Core.Model
{
    [Serializable]
    public class TransactionInvocation
    {
       /**
        * 事务执行器
        */
        public Type TargetClazz { get; set; }
        /**
         * 方法
         */
        public string Method { get; set; }
        /**
         * 参数值
         */
        public object[] ArgumentValues { get; set; }

        /**
         * 参数类型
         */
        public Type[] ParameterTypes { get; set; }

        /**
         * 方法字符串
         */
        private string MethodStr { get; set; }

        public TransactionInvocation()
        {
        }

        public TransactionInvocation(Type targetClazz, string method, string methodStr, object[] argumentValues, Type[] parameterTypes)
        {
            TargetClazz = targetClazz;
            Method = method;
            MethodStr = methodStr;
            ArgumentValues = argumentValues;
            ParameterTypes = parameterTypes;
        }
    }
}
