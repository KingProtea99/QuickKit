using UnityEngine;

namespace KP.QuickKit
{
    public class Description : MonoBehaviour
    {
        [TextArea(5, 25)]
        [SerializeField] private string _description;
    }
}