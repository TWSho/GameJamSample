using Cysharp.Threading.Tasks;
using Extreal.Core.Common.System;
using Extreal.Core.StageNavigation;
using GameJam.App;
using UniRx;
using VContainer.Unity;

namespace GameJam.RetryScreen
{
    public class RetryScreenPresenter : DisposableBase, IInitializable
    {
        private StageNavigator<StageName, SceneName> stageNavigator;
        private AppState appState;
        private CompositeDisposable compositeDisposable = new CompositeDisposable();

        public RetryScreenPresenter(StageNavigator<StageName, SceneName> stageNavigator, AppState appState)
        {
            this.stageNavigator = stageNavigator;
            this.appState = appState;
        }

        public void Initialize()
        {
            // Stage遷移後遷移前Stageに遷移
            stageNavigator.OnStageTransitioned.Subscribe(_ =>
            {
                stageNavigator.ReplaceAsync(appState.lastStage).Forget();
            }).AddTo(compositeDisposable);
        }

        protected override void ReleaseManagedResources()
        {
            compositeDisposable?.Dispose();
        }
    }
}