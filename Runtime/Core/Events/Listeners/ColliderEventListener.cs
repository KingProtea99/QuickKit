using UnityEngine;

namespace KP.QuickKit
{
    [AddComponentMenu(
        Constants.EventMenuName + "UnityObject/" + "Collider Event Listener",
        Constants.EventMenuOrderUnityObject + 1
    )]
    public class ColliderEventListener : EventListener<Collider>
    {

    }
}