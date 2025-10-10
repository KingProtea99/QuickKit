using UnityEngine;

namespace KP.QuickKit
{
    [AddComponentMenu(Constants.ScriptMenuName + "Description")]
    public class Description : MonoBehaviour
    {
        [TextArea(5, 25)]
        [SerializeField] private string _description;
    }
}