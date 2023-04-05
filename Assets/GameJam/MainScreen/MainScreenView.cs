using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace GameJam.MainScreen
{
    public class MainScreenView : MonoBehaviour
    {
        [SerializeField] private Button nextButton;

        public IObservable<Unit> OnNextButtonClicked
            => nextButton.OnClickAsObservable().TakeUntilDestroy(this);
    }
}