using UnityEngine;

namespace Tableau.Logic
{
    public class TableauMistake: ITableau
    {
        private GameObject _createdTableau;
        
        public void Create(GameObject prefab, Transform parent)
        {
            _createdTableau = Object.Instantiate(prefab, parent);
        }

        public void Remove()
        {
            if(_createdTableau != null)
                Object.Destroy(_createdTableau);
        }
    }
}