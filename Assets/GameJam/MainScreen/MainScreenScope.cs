using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace GameJam.MainScreen
{
    public class MainScreenScope : LifetimeScope
    {
        [SerializeField] private MainScreenView mainScreenView;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponent(mainScreenView);

            builder.RegisterEntryPoint<MainScreenPresenter>();
        }
    }
}