using UnityEngine;

namespace KP.QuickKit
{
    [AddComponentMenu(
        Constants.EventMenuName + "UnityPrimitive/" + "Collision Event Listener",
        Constants.EventMenuOrderUnityPrimitive + 3
    )]
    public class CollisionEventListener : EventListener<Collision>
    {

    }
}