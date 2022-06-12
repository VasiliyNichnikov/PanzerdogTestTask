namespace Wallet.Logic
{
    public interface IBalance
    {
        public float AmountOfMoney { get; }
        public void Subtract(float amountOfMoney);
        public void Add(float amount);
    }
}