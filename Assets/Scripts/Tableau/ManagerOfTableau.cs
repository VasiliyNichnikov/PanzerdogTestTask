using Tableau.Creators;
using UnityEngine;

namespace Tableau
{
    public class ManagerOfTableau : MonoBehaviour
    {
        [SerializeField] private GameObject _mistake;
        [SerializeField] private GameObject _confirmPurchase;
        [SerializeField] private Transform _parent;

        private TableauBase _tableauBase;


        public void OpenConfirmPurchase(string title, string description)
        {
            var creator = new CreatorTableauConfirmPurchase(title, description);
            CreateTableau(creator, _confirmPurchase);
        }
        
        public void OpenMistake(string title, string description)
        {
            var creator = new CreatorTableauMistake(title, description);
            CreateTableau(creator, _mistake);
        }
        
        private void CreateTableau(ICreatorTableau creator, GameObject prefab)
        {
            if(_tableauBase != null)
                return;
            _tableauBase = creator.Create(_parent, prefab);
        }
    }
}