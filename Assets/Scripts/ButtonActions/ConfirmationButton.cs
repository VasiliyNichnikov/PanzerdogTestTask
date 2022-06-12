using UnityEngine;

namespace ButtonActions
{
    public class ConfirmationButton : MonoBehaviour, IButtonAction
    {
        public void Press()
        {
            EventManager.ReportPurchaseDetails();
            EventManager.ReportClosure();
        }
    }
}