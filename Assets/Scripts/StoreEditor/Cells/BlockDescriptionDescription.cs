using UnityEngine;

namespace StoreEditor.Cells
{
    [CreateAssetMenu(fileName = "BlockDescriptionDescription", menuName = "Blocks/DescriptionDescription", order = 0)]
    public class BlockDescriptionDescription : BlockBase
    {
        public string DescriptionOne => _descriptionOne;
        public string DescriptionTwo => _descriptionTwo;
        
        [SerializeField] private string _descriptionOne;
        [SerializeField] private string _descriptionTwo;
    }
}