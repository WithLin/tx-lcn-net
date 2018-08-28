namespace Lcn.TxClient.Core.Attribute
{
    public enum TxTransactionMode
    {

        /** LCN 模式  LCN 模式,2阶段提交 读提交*/
        TX_MODE_LCN,
        /** TXC 模式  TXC 模式,未提交读(READ UNCOMMITTED) */
        TX_MODE_TXC
    }


}