using UnityEngine;
using UnityEngine.UI;

namespace Tableau
{
    public class TableauBaseConfirmPurchase : TableauBase
    {
        [SerializeField] private Text _titleText;
        [SerializeField] private Text _descriptionText;

        public override void SetTitle(string title)
        {
            _titleText.text = title;
        }

        public override void SetDescription(string description)
        {
            _descriptionText.text = description;
        }

        public override void Close()
        {
            Destroy(gameObject);
        }
    }
}