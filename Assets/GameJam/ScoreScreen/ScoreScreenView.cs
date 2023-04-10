using System;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace GameJam.ScoreScreen
{
    public class ScoreScreenView : MonoBehaviour
    {
        [SerializeField] private Button nextButton;
        [SerializeField] private TextMeshProUGUI scoreDataText;

        public void SetScoreDataText(string score)
        {
            scoreDataText.text = score;
        }

        public IObservable<Unit> OnNextButtonClicked
            => nextButton.OnClickAsObservable().TakeUntilDestroy(this);
    }
}