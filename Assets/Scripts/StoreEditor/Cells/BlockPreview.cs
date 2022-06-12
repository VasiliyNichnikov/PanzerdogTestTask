using UnityEngine;

namespace StoreEditor.Cells
{
    [CreateAssetMenu(fileName = "BlockPreview", menuName = "Blocks/Preview", order = 0)]
    public class BlockPreview : BlockBase
    {
        public Sprite Preview => _preview;
        [SerializeField] private Sprite _preview;
    }
}