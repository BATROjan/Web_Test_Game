using System;
using UnityEngine;

namespace Panel
{
    [CreateAssetMenu(fileName = "PanelConfig", menuName = "Configs/PanelConfig")]
    public class PanelConfig : ScriptableObject
    {
        public PanelImageModel[] PanelImageModels=> panelImageModels;
        
        [SerializeField] private PanelImageModel[] panelImageModels;
    }
    
    [Serializable]
    public struct PanelImageModel
    {
        public Sprite sprite;
    }
}