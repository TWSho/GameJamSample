using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace GameJam.MainScreen
{
    public class MainScreenView : MonoBehaviour
    {
        [SerializeField] private Button nextButton;
        [SerializeField] private Button retryButton;
        [SerializeField] private Button returnButton;

        public IObservable<Unit> OnNextButtonClicked
            => nextButton.OnClickAsObservable().TakeUntilDestroy(this);
        public IObservable<Unit> OnRetryButtonClicked
            => retryButton.OnClickAsObservable().TakeUntilDestroy(this);
        public IObservable<Unit> OnReturnButtonClicked
            => returnButton.OnClickAsObservable().TakeUntilDestroy(this);
    }
}