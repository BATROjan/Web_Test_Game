using Zenject;

namespace Panel
{
    public class PanelInstaller : Installer<PanelInstaller>
    {
        public override void InstallBindings()
        {
            Container
                .Bind<PanelConfig>()
                .FromScriptableObjectResource("PanelConfig")
                .AsSingle()
                .NonLazy();  
            
            Container
                .Bind<PanelController>()
                .AsSingle()
                .NonLazy(); 
            
            Container
                .BindMemoryPool<PanelView, PanelView.Pool>()
                .FromComponentInNewPrefabResource("Panel");
        }
    }
}