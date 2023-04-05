using Cysharp.Threading.Tasks;
using Extreal.Core.Common.System;
using Extreal.Core.StageNavigation;
using GameJam.App;
using UniRx;
using VContainer.Unity;

namespace GameJam.ScoreScreen
{
    public class ScoreScreenPresenter : DisposableBase, IInitializable
    {
        private StageNavigator<StageName, SceneName> stageNavigator;

        private ScoreScreenView scoreScreenView;

        private CompositeDisposable compositeDisposable = new CompositeDisposable();

        public ScoreScreenPresenter(StageNavigator<StageName, SceneName> stageNavigator,
            ScoreScreenView scoreScreenView)
        {
            this.stageNavigator = stageNavigator;
            this.scoreScreenView = scoreScreenView;
        }

        public void Initialize()
        {
            scoreScreenView.OnNextButtonClicked.Subscribe(_ =>
            {
                stageNavigator.ReplaceAsync(StageName.TitleStage).Forget();
            }).AddTo(compositeDisposable);
        }

        protected override void ReleaseManagedResources()
        {
            compositeDisposable?.Dispose();
        }
    }
}