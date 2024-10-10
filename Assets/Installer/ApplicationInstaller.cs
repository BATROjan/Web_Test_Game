using Panel;
using Sound;
using UI;
using UnityEngine;
using Zenject;

public class ApplicationInstaller : MonoInstaller<ApplicationInstaller>
{
    [SerializeField] private MainCamera mainCamera;
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
        
        Container
            .Bind<AudioView>()
            .FromComponentInNewPrefabResource("AudioView")
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
