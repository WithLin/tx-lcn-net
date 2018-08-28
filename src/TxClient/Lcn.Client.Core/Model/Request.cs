using System;
using Lcn.TxClient.Core.Utils;

namespace Lcn.TxClient.Core.Model
{
    [Serializable]
    public class Request
    {
        /**
         * key
         */
        public string Key { get; set; }
        /**
         * action
         */
        public string Action { get; set; }
        /**
         * params
         */
        public string Params { get; set; }


        public Request(string action, string @params)
        {
            Action = action;
            Params = @params;
            Key = KidUtils.GenerateShortUuid();
        }
    }
}
