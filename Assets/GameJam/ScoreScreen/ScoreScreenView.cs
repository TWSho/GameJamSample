using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace GameJam.ScoreScreen
{
    public class ScoreScreenView : MonoBehaviour
    {
        [SerializeField] private Button nextButton;

        public IObservable<Unit> OnNextButtonClicked
            => nextButton.OnClickAsObservable().TakeUntilDestroy(this);
    }
}