using Tableau;
using UnityEngine;

namespace ButtonActions
{
    public class ConfirmationButton : MonoBehaviour, IButtonAction
    {
        [SerializeField] private TableauBase _tableau;
        
        public void Press()
        {
            EventManager.CompletePurchase();
            _tableau.Close();
        }
    }
}
