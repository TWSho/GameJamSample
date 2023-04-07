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

        private ScoreData scoreData;

        private CubeRotation cubeRotation;

        private CompositeDisposable compositeDisposable = new CompositeDisposable();

        public MainScreenPresenter(StageNavigator<StageName, SceneName> stageNavigator,
            MainScreenView mainScreenView,
            ScoreData scoreData,
            CubeRotation cubeRotation)
        {
            this.stageNavigator = stageNavigator;
            this.mainScreenView = mainScreenView;
            this.scoreData= scoreData;
            this.cubeRotation = cubeRotation;
        }

        public void Initialize()
        {
            mainScreenView.OnNextButtonClicked.Subscribe(_ =>
            {
                scoreData.scoreInt.Value = (int)(cubeRotation.Rotate * 100f);    // 適当にScoreを入れる
                stageNavigator.ReplaceAsync(StageName.ScoreStage).Forget();
            }).AddTo(compositeDisposable);
        }

        protected override void ReleaseManagedResources()
        {
            compositeDisposable?.Dispose();
        }
    }
}