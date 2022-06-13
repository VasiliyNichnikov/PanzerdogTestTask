using Tableau;
using UnityEngine;

namespace ButtonActions
{
    public class CancelButton : MonoBehaviour, IButtonAction
    {
        [SerializeField] private TableauBase _tableau;
        
        public void Press()
        {
            _tableau.Close();
        }
    }
}
