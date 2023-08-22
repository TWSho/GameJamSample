using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace GameJam.App
{
    public class CommonScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<CommonPresenter>();
        }
    }
}