using UnityEngine;

namespace Tableau.Logic
{
    public interface ITableau
    {
        public void Create(GameObject prefab, Transform parent);
        
        public void Remove();
    }
}