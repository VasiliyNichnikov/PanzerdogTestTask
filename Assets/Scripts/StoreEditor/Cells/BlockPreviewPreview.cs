using UnityEngine;

namespace StoreEditor.Cells
{
    [CreateAssetMenu(fileName = "BlockPreviewPreview", menuName = "Blocks/PreviewPreview", order = 0)]
    public class BlockPreviewPreview : BlockBase
    {
        public Sprite PreviewOne => _previewOne;
        public Sprite PreviewTwo => _previewTwo;
        
        [SerializeField] private Sprite _previewOne;
        [SerializeField] private Sprite _previewTwo;
    }
}