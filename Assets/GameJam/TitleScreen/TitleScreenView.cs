using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace GameJam.TitleScreen
{
    public class TitleScreenView : MonoBehaviour
    {
        [SerializeField] private Button nextButton;

        public IObservable<Unit> OnNextButtonClicked
            => nextButton.OnClickAsObservable().TakeUntilDestroy(this);
    }
}