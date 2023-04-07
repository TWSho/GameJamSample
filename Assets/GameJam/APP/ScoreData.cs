using UniRx;
using Extreal.Core.Common.System;
using VContainer.Unity;

namespace GameJam.App
{
    public class ScoreData : DisposableBase, IInitializable
    {
        public IntReactiveProperty scoreInt = new IntReactiveProperty();

        private CompositeDisposable compositeDisposable = new CompositeDisposable();


        public void Initialize()
        {

        }
        protected override void ReleaseManagedResources()
        {
            compositeDisposable?.Dispose();
        }
    }
}
