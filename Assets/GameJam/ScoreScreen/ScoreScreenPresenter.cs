using Cysharp.Threading.Tasks;
using Extreal.Core.Common.System;
using Extreal.Core.StageNavigation;
using Extreal.Core.Logging;
using GameJam.App;
using UniRx;
using VContainer.Unity;
using UnityEngine;

namespace GameJam.ScoreScreen
{
    public class ScoreScreenPresenter : DisposableBase, IInitializable
    {
        private static readonly ELogger Logger = LoggingManager.GetLogger(nameof(ScoreScreenPresenter));
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

            scoreData.scoreInt.Subscribe(score =>
            {
                scoreScreenView.SetScoreDataText(score.ToString());
                if (Logger.IsDebug())
                {
                    Logger.LogDebug($"Score : {score}");
                }
            }).AddTo(compositeDisposable);
        }

        


        protected override void ReleaseManagedResources()
        {
            compositeDisposable?.Dispose();
        }
    }
}