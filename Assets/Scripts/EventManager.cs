using System;
using Products.Logic;
using Wallet.Logic;

public static class EventManager
{
    #region TableauActions

    public static Action<ProductBase> ReportPurchase;
    public static Action ReportPurchaseMistake;
    public static Action ReportPurchaseDetails;
    public static Action ReportClosure;

    #endregion

    #region PurchaseProduct
    public static Action<ProductBase> Buy;
    #endregion
    
}