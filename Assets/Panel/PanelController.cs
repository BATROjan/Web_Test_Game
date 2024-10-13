using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor.AddressableAssets.Settings;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace Panel
{
    public class PanelController
    {
        private readonly PanelConfig _panelConfig;
        public string addressableName = "Panel";

        private GameObject _panel;

        public PanelController(
            PanelConfig panelConfig)
        {
            _panelConfig = panelConfig;
        }

        public async void Spawn()
        {
            var panel = await LoadPanel<PanelView>(addressableName);
            panel.Reinit(_panelConfig.PanelImageModels);
        }

        private async Task<T> LoadPanel<T>(string name)
        {
            var handle = Addressables.InstantiateAsync(name);
            _panel = await handle.Task;
            if (!_panel.TryGetComponent(out T Panel))
            {
                throw new NullReferenceException($"Object of type {typeof(T)} is null");
            }

            return Panel;
        }
    }
}