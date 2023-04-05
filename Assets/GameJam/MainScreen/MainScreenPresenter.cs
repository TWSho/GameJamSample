using Cysharp.Threading.Tasks;
using Extreal.Core.Common.System;
using Extreal.Core.StageNavigation;
using GameJam.App;
using UniRx;
using VContainer.Unity;

namespace GameJam.MainScreen
{
    public class MainScreenPresenter : DisposableBase, IInitializable
    {
        private StageNavigator<StageName, SceneName> stageNavigator;

        private MainScreenView mainScreenView;

        private CompositeDisposable compositeDisposable = new CompositeDisposable();

        public MainScreenPresenter(StageNavigator<StageName, SceneName> stageNavigator,
            MainScreenView mainScreenView)
        {
            this.stageNavigator = stageNavigator;
            this.mainScreenView = mainScreenView;
        }

        public void Initialize()
        {
            mainScreenView.OnNextButtonClicked.Subscribe(_ =>
            {
                stageNavigator.ReplaceAsync(StageName.ScoreStage).Forget();
            }).AddTo(compositeDisposable);
        }

        protected override void ReleaseManagedResources()
        {
            compositeDisposable?.Dispose();
        }
    }
}