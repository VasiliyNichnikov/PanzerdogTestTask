using System;
using Products;
using Seller;

public static class EventManager
{
    #region PurchaseProduct

    public static Action<IProduct, TypesOfActionsWithBalance> StartPurchase;
    public static Action CompletePurchase;
    public static Action<float, TypesOfActionsWithBalance> PurchaseWithoutConfirmation;

    #endregion

    #region RemoveProduct

    public static Action<ProductBase> DestroyerProduct;

    #endregion
}