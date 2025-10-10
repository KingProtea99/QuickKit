using UnityEngine;

namespace KP.QuickKit
{
    [AddComponentMenu(Constants.CheatMenuName + "Time Cheat")]
    public class TimeCheat : MonoBehaviour
    {
        [Range(0.0f, 99.9f)]
        [SerializeField] private float _timeScale = 1.0f;

        private void OnValidate()
        {
            Time.timeScale = _timeScale;
        }

        void Awake()
        {
            Debug.LogWarning("[TimeCheat]");
        }
    }
}