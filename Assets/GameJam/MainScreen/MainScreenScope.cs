using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace GameJam.MainScreen
{
    public class MainScreenScope : LifetimeScope
    {
        [SerializeField] private MainScreenView mainScreenView;
        [SerializeField] private CubeRotation cubeRotation;
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponent(mainScreenView);
            builder.RegisterComponent(cubeRotation);
            builder.RegisterEntryPoint<MainScreenPresenter>();
        }
    }
}