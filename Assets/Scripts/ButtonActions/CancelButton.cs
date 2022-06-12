using UnityEngine;

namespace ButtonActions
{
    public class CancelButton : MonoBehaviour, IButtonAction
    {
        public void Press()
        {
            EventManager.ReportClosure();
        }
    }
}
