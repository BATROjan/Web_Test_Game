using UnityEngine;
using Zenject;

namespace Panel
{
    public class PanelView : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer[] _spriteRenderers;

        public void Reinit(PanelImageModel[] panelImageModels)
        {
            for (int i = 0; i < _spriteRenderers.Length; i++)
            {
                _spriteRenderers[i].sprite = panelImageModels[i].sprite;
            }
        }
        public class Pool : MonoMemoryPool<PanelImageModel[],PanelView>
        {
            protected override void Reinitialize(PanelImageModel[] panelImageModels, PanelView item)
            {
                item.Reinit(panelImageModels);
            }
        }
    }
}