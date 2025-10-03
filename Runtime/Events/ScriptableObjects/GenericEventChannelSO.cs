using UnityEngine;
using UnityEngine.Events;

namespace KP.QuickKit.Events
{
    public abstract class GenericEventChannelSO<T> : ScriptableObject
    {
        public UnityAction<T> OnEventRaised;

        public void RaiseEvent(T value)
        {
            OnEventRaised?.Invoke(value);
        }
    }
}