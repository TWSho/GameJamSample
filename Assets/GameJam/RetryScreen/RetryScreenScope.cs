using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace GameJam.RetryScreen
{
    public class RetryScreenScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<RetryScreenPresenter>();
        }
    }
}