using System;
using Products.Creators;
using StoreEditor.Cells;
using UnityEngine;

namespace StoreEditor
{
    public class CreatorsBlock : MonoBehaviour
    {
        [SerializeField, Header("Prefab description")]
        private GameObject _prefabDescription;

        [SerializeField, Header("Prefab description description"), Space(10)]
        private GameObject _prefabDescriptionDescription;

        [SerializeField, Header("Prefab preview"), Space(10)]
        private GameObject _prefabPreview;

        [SerializeField, Header("Prefab preview description"), Space(10)]
        private GameObject _prefabPreviewDescription;

        [SerializeField, Header("Prefab preview preview"), Space(10)]
        private GameObject _prefabPreviewPreview;

        [SerializeField, Header("Prefab virtual currency"), Space(10)]
        private GameObject _prefabVirtualCurrency;

        public ICreatorProduct GetCreator(BlockBase block)
        {
            switch (block)
            {
                case BlockDescription blockDescription:
                    return new CreatorProductDescription(_prefabDescription, blockDescription.Description);
                
                case BlockDescriptionDescription blockDescriptionDescription:
                    return new CreatorProductDescriptionDescription(_prefabDescriptionDescription,
                        blockDescriptionDescription.DescriptionOne, blockDescriptionDescription.DescriptionTwo);
                
                case BlockPreview blockPreview:
                    return new CreatorProductPreview(_prefabPreview, blockPreview.Preview);
                
                case BlockPreviewDescription blockPreviewDescription:
                    return new CreatorProductPreviewDescription(_prefabPreviewDescription,
                        blockPreviewDescription.Description, blockPreviewDescription.Preview);
                
                case BlockPreviewPreview blockPreviewPreview:
                    return new CreatorProductPreviewPreview(_prefabPreviewPreview, blockPreviewPreview.PreviewOne,
                        blockPreviewPreview.PreviewTwo);
                
                case BlockVirtualCurrency blockVirtualCurrency:
                    return new CreatorProductVirtualCurrency(_prefabVirtualCurrency,
                        blockVirtualCurrency.VirtualCurrency);
            }

            throw new ArgumentException();
        }
    }
}