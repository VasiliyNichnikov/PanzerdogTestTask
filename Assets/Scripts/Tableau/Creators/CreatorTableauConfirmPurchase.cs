using UnityEngine;

namespace Tableau.Creators
{
    public class CreatorTableauConfirmPurchase : ICreatorTableau
    {
        private readonly string _title;
        private readonly string _description;


        public CreatorTableauConfirmPurchase(string title, string description)
        {
            _title = title;
            _description = description;
        }

        public TableauBase Create(Transform parent, GameObject prefab)
        {
            var tableau = Object.Instantiate(prefab, parent).GetComponent<TableauBase>();
            tableau.SetTitle(_title);
            tableau.SetDescription(_description);
            return tableau;
        }
    }
}