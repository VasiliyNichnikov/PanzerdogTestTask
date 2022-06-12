using System;
using Products.Logic;

public static class EventManager
{
    #region TableauActions

    public static Action ReportPurchase;
    public static Action ReportPurchaseMistake;
    public static Action ReportClosure;

    #endregion

    #region PurchaseProduct

    public static Action<ProductBase> StartPurchase;
    public static Action CompletePurchase;

    #endregion
}