using UnityEngine;

namespace KP.QuickKit
{
    [AddComponentMenu(Constants.ScriptMenuName + "Dont Destroy On Load")]
    public class DontDestroyOnLoad : MonoBehaviour
    {
        void Start()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}