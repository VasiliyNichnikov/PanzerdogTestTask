using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

namespace Wallet.UI
{
    public class BalanceTextManager : MonoBehaviour
    {
        private Text _balance;

        private void Start()
        {
            _balance = GetComponent<Text>();
        }

        public void ChangeBalance(float newBalance)
        {
            _balance.text = $"Account: {newBalance.ToString(CultureInfo.InvariantCulture)}$";
        }
    }
}
