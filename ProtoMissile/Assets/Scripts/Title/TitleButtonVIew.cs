using System;
using Common;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace Title
{
    public class TitleButtonVIew : MonoBehaviour , IButtonView
    {
        [SerializeField] private Button _button;
        
        public IObservable<Unit> OnButtonClickedAsObservable()
        {
            return _button.OnClickAsObservable();
        }

        private void Awake()
        {
            if (_button == null)
            {
                _button = GetComponent<Button>();
            }
        }
    }
}
