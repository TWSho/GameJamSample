using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace GameJam.MainScreen
{
    public class MainScreenView : MonoBehaviour
    {
        [SerializeField] private Button startButton;

        public IObservable<Unit> OnGoButtonClicked
            => startButton.OnClickAsObservable().TakeUntilDestroy(this);
    }
}