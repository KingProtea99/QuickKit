using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace KP.QuickKit.Events
{
    public class VoidEventChannelListener : MonoBehaviour
    {
        [Header("Listen Event Channel")]
        [SerializeField] private VoidEventChannelSO _eventChannel;

        [Space]
        [SerializeField] private UnityEvent _response;
        [SerializeField] private float _delay;

        private void OnEnable()
        {
            if (_eventChannel != null)
                _eventChannel.OnEventRaised += OnEventRaised;
        }

        private void OnDisable()
        {
            if (_eventChannel != null)
                _eventChannel.OnEventRaised -= OnEventRaised;
        }

        private void OnEventRaised()
        {
            StartCoroutine(RaiseEventDelayed(_delay));
        }

        private IEnumerator RaiseEventDelayed(float delay)
        {
            yield return WaitForSecondsCache.Get(delay);
            _response?.Invoke();
        }
    }
}