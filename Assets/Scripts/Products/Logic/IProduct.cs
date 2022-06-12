namespace Products.Logic
{
    public interface IProduct
    {
        public float Price { get; }
        public void GetPurchased();
    }
}