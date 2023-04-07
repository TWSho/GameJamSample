using Cysharp.Threading.Tasks;
using Extreal.Core.Common.System;
using Extreal.Core.StageNavigation;
using GameJam.App;
using UniRx;
using VContainer.Unity;
using UnityEngine;

namespace GameJam.ScoreScreen
{
    public class ScoreScreenPresenter : DisposableBase, IInitializable
    {
        private StageNavigator<StageName, SceneName> stageNavigator;

        private ScoreScreenView scoreScreenView;

        private ScoreData scoreData;

        private CompositeDisposable compositeDisposable = new CompositeDisposable();

        public ScoreScreenPresenter(StageNavigator<StageName, SceneName> stageNavigator,
            ScoreScreenView scoreScreenView,
            ScoreData scoreData)
        {
            this.stageNavigator = stageNavigator;
            this.scoreScreenView = scoreScreenView;
            this.scoreData= scoreData;
        }

        public void Initialize()
        {
            scoreScreenView.OnNextButtonClicked.Subscribe(_ =>
            {
                stageNavigator.ReplaceAsync(StageName.TitleStage).Forget();
            }).AddTo(compositeDisposable);
            scoreData.scoreInt.Subscribe(value => Debug.Log($"New value: {value}"))
                .AddTo(compositeDisposable);
        }

        protected override void ReleaseManagedResources()
        {
            compositeDisposable?.Dispose();
        }
    }
}