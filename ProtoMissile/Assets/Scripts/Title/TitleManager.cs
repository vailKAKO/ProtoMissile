using System;
using Common;
using Cysharp.Threading.Tasks;
using UniRx;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace Title
{
    public class TitleManager : MonoBehaviour
    {
        // Sceneまたぐことでしかなりたたないのでそもそも使う意味がない
        [Inject] private IButtonView _titleButton;

        private void Start()
        {
            _titleButton.OnButtonClickedAsObservable().Subscribe(_ => StartGame()).AddTo(this);
        }

        void StartGame()
        {
            SceneManager.LoadScene("Scenes/TestGameScene");
        }

    }
}