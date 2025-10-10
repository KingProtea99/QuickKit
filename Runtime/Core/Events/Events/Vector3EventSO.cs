using UnityEngine;

namespace KP.QuickKit
{
    [CreateAssetMenu(
        fileName = "Vector3 Event",
        menuName = Constants.EventMenuName + "Vector3 Event",
        order = Constants.EventMenuOrderUnityPrimitive + 1
    )]
    public class Vector3EventSO : EventSO<Vector3>
    {

    }
}