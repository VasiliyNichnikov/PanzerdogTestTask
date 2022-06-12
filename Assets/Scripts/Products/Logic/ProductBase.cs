using UnityEngine;

namespace Products.Logic
{
    public abstract class ProductBase: MonoBehaviour
    {
        public float Price { get; protected set; }
        public abstract void GetPurchased();
    }
}
