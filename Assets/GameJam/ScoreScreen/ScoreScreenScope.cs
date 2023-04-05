using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace GameJam.ScoreScreen
{
    public class ScoreScreenScope : LifetimeScope
    {
        [SerializeField] private ScoreScreenView scoreScreenView;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponent(scoreScreenView);

            builder.RegisterEntryPoint<ScoreScreenPresenter>();
        }
    }
}