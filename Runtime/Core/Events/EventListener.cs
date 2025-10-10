using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace KP.QuickKit
{
    public abstract class EventListener<T> : MonoBehaviour
    {
        [SerializeField] private EventSO<T>[] _listenEvents;

        [Space]
        [SerializeField] private UnityEvent<T> _response;
        [SerializeField] private float _delay;

        private void OnEnable()
        {
            foreach (var listenEvent in _listenEvents)
            {
                if (listenEvent != null)
                    listenEvent.OnEventRaised += OnEventRaised;
            }
        }

        private void OnDisable()
        {
            foreach (var listenEvent in _listenEvents)
            {
                if (listenEvent != null)
                    listenEvent.OnEventRaised -= OnEventRaised;
            }
        }

        private void OnEventRaised(T value)
        {
            StartCoroutine(RaiseEventDelayed(value, _delay));
        }

        private IEnumerator RaiseEventDelayed(T value, float delay)
        {
            yield return WaitForSecondsCache.Get(delay);
            _response?.Invoke(value);
        }
    }
}