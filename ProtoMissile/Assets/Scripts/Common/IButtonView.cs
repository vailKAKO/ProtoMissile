using System;
using UniRx;

namespace Common
{
    public interface IButtonView
    {
        IObservable<Unit> OnButtonClickedAsObservable();
    }
}