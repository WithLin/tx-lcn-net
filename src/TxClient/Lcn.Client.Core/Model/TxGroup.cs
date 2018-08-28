using System;
using Newtonsoft.Json.Linq;

namespace Lcn.TxClient.Core.Model
{
    public class TxGroup
    {
        public string GroupId { get; set; }

        public long StartTime { get; set; }

        public long NowTime { get; set; }

        public int HasOver { get; set; }

        public int IsCompensate { get; set; }

        public static TxGroup Parser(string json)
        {
            try
            {
                if (string.IsNullOrEmpty(json))
                {
                    return null;
                }
                var jsonObject = JObject.Parse(json);
                var txGroup = new TxGroup()
                {
                    GroupId = (string)jsonObject["g"],
                    StartTime = (long)jsonObject["st"],
                    NowTime = (long)jsonObject["nt"],
                    HasOver = (int)jsonObject["o"],
                    IsCompensate = (int)jsonObject["i"]
                };
                return txGroup;

            }
            catch (Exception e)
            {
                return null;
            }

        }
        public string ToJsonString()
        {
            var jsonObject = JObject.FromObject(this);
            jsonObject.Add("g", GroupId);
            jsonObject.Add("st", StartTime);
            jsonObject.Add("o", HasOver);
            jsonObject.Add("nt", NowTime);
            jsonObject.Add("i", HasOver);
            var jsonArray = new JArray();
            jsonObject.Add("l", jsonArray);
            return jsonObject.ToString();
        }
    }
}
