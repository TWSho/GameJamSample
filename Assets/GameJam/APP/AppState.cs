using UniRx;
using Extreal.Core.Common.System;
using VContainer.Unity;

namespace GameJam.App
{
    public class AppState : DisposableBase, IInitializable
    {
        public int ScoreInt { get; private set; }


        private CompositeDisposable compositeDisposable = new CompositeDisposable();

        public void SetScoreInt(int scoreInt) => ScoreInt = scoreInt;
        public void Initialize()
        {

        }
        protected override void ReleaseManagedResources()
        {
            compositeDisposable?.Dispose();
        }
    }
}
