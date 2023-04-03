using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace GameJam.TitleScreen
{
    public class TitleScreenView : MonoBehaviour
    {
        [SerializeField] private Button startButton;

        public IObservable<Unit> OnGoButtonClicked
            => startButton.OnClickAsObservable().TakeUntilDestroy(this);
    }
}