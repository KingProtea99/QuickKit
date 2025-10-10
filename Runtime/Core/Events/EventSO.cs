using UnityEngine;
using UnityEngine.Events;

namespace KP.QuickKit
{
    public abstract class EventSO<T> : ScriptableObject
    {
        public event UnityAction<T> OnEventRaised;

        public void RaiseEvent(T value)
        {
            OnEventRaised?.Invoke(value);
        }
    }
}