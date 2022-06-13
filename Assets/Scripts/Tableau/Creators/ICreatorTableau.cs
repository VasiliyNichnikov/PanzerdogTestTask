using UnityEngine;

namespace Tableau.Creators
{
    public interface ICreatorTableau
    {
        public TableauBase Create(Transform parent, GameObject prefab);
    }
}