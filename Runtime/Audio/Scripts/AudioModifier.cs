using UnityEngine;

namespace KP.QuickKit.Audio
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioModifier : MonoBehaviour
    {
        [SerializeField] private AudioSource _audioSource;

        [Header("Audio Delegate")]
        [SerializeField] private AudioDelegateSO _audioDelegate;

        void Reset()
        {
            _audioSource = GetComponent<AudioSource>();
        }

        public void Play()
        {
            if (_audioDelegate == null)
                return;

            _audioDelegate.Play(_audioSource);
        }
    }
}