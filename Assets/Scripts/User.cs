using UnityEngine;
using Wallet.Logic;

public class User : MonoBehaviour
{
    public IBalance Balance { get; private set; }

    [SerializeField, Range(0, 1000)] private float _initialAmount;

    private void Awake()
    {
        Balance = new Balance(_initialAmount);
    }
}