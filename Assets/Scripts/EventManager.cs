using System;
using Products;

public static class EventManager
{
    #region TableauActions

    public static Action ReportPurchase;
    public static Action ReportPurchaseMistake;
    public static Action ReportClosure;

    #endregion

    #region PurchaseProduct

    public static Action<IProduct> StartPurchase;
    public static Action<bool> CompletePurchase;

    #endregion

    #region AddMoney

    public static Action<float> AddAmount;

    #endregion

    #region RemoveProduct

    public static Action<ProductBase> DestroyerProduct;

    #endregion
}