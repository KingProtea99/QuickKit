using UnityEngine;

namespace KP.QuickKit
{
    [CreateAssetMenu(
        fileName = "Collision Event",
        menuName = Constants.EventMenuName + "Collision Event",
        order = Constants.EventMenuOrderUnityPrimitive + 3
    )]
    public class CollisionEventSO : EventSO<Collision>
    {

    }
}