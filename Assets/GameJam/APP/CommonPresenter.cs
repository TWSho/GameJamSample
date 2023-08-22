using UnityEngine;
using Extreal.Core.Common.System;
using Extreal.Core.StageNavigation;
using GameJam.App;
using Extreal.Core.Logging;
using VContainer.Unity;
using UniRx;
using Cysharp.Threading.Tasks;

namespace GameJam.App
{
    public class CommonPresenter : DisposableBase, IInitializable
    {
        private StageNavigator<StageName, SceneName> stageNavigator;
        private AppState appState;
        private CompositeDisposable compositeDisposable = new CompositeDisposable();
        public CommonPresenter(StageNavigator<StageName, SceneName> stageNavigator, AppState appState)
        {
            this.stageNavigator = stageNavigator;
            this.appState = appState;
        }
        public void Initialize()
        {
            // Stage‘JˆÚ’†‚É‘O‰ñStage‚ðŽæ“¾
            stageNavigator.OnStageTransitioning.Subscribe(stage =>
            {
                appState.SetLastStage(appState.nowStage);
                Debug.Log($"last Stage: {appState.nowStage}");

            }).AddTo(compositeDisposable);
            stageNavigator.OnStageTransitioned.Subscribe(stage =>
           {
               appState.SetNowStage(stage);
               Debug.Log($"Now Stage: {appState.nowStage}");
           }).AddTo(compositeDisposable);
        }




        protected override void ReleaseManagedResources()
        {
            compositeDisposable?.Dispose();
        }
    }
}
