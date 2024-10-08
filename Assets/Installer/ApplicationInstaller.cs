using Panel;
using UI;
using Zenject;

public class ApplicationInstaller : MonoInstaller<ApplicationInstaller>
{
    public override void InstallBindings()
    {
        Container
            .Bind<MainCamera>()
            .FromComponentInNewPrefabResource("Camera")
            .AsSingle()
            .NonLazy();
        
        Container
            .Bind<UIRoot>()
            .FromComponentInNewPrefabResource("Canvas")
            .AsSingle()
            .NonLazy();
        
        Container
            .Bind<ButtonAnimationController>()
            .AsSingle()
            .NonLazy();
        
        PanelInstaller
            .Install(Container);

        Container
            .Bind<GameController.GameController>()
            .AsSingle()
            .NonLazy();
    }
}
