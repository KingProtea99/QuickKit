using UnityEngine;

namespace KP.QuickKit.Audio
{
    [CreateAssetMenu(menuName = "Audio/Audio Delegate")]
    public class AudioDelegateSO : ScriptableObject
    {
        [SerializeField] private AudioClip[] clips;
        [SerializeField] private RangedFloat volume;
        [SerializeField] private RangedFloat pitch;

        public virtual void Play(AudioSource source)
        {
            if (clips.Length == 0 || source == null)
                return;

            source.clip = clips[Random.Range(0, clips.Length)];
            source.volume = Random.Range(volume.minValue, volume.maxValue);
            source.pitch = Random.Range(pitch.minValue, pitch.maxValue);

            source.Play();
        }
    }
}