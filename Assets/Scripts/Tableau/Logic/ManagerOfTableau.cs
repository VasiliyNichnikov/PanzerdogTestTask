using UnityEngine;

namespace Tableau.Logic
{
    public class ManagerOfTableau : MonoBehaviour
    {
        [SerializeField] private GameObject _mistake;
        [SerializeField] private GameObject _confirmPurchase;
        [SerializeField] private Transform _parent;

        private ITableau _tableau;

        private void OnEnable()
        {
            EventManager.ReportPurchase += ToCreateNewConfirmPurchase;
            EventManager.ReportClosure += ToClose;
            EventManager.ReportPurchaseMistake += ToCreateNewMistake;
        }

        private void OnDisable()
        {
            EventManager.ReportPurchase -= ToCreateNewConfirmPurchase;
            EventManager.ReportClosure -= ToClose;
            EventManager.ReportPurchaseMistake -= ToCreateNewMistake;
        }

        private void ToCreateNewConfirmPurchase()
        {
            if (_tableau != null)
                return;
            _tableau = new TableauConfirmPurchase();
            ToCreateTableau(_confirmPurchase);
        }

        private void ToCreateNewMistake()
        {
            if (_tableau != null)
                return;
            _tableau = new TableauMistake();
            ToCreateTableau(_mistake);
        }

        private void ToClose()
        {
            _tableau?.Remove();
            _tableau = null;
        }

        private void ToCreateTableau(GameObject prefab)
        {
            _tableau.Create(prefab, _parent);
        }
    }
}