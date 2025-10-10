using UnityEngine;

namespace KP.QuickKit
{
    [CreateAssetMenu(
        fileName = "Quaternion Event",
        menuName = Constants.EventMenuName + "Quaternion Event",
        order = Constants.EventMenuOrderUnityPrimitive + 4
    )]
    public class QuaternionEventSO : EventSO<Quaternion>
    {

    }
}