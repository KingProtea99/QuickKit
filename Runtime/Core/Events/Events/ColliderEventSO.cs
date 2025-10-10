using UnityEngine;

namespace KP.QuickKit
{
    [CreateAssetMenu(
        fileName = "Collider Event",
        menuName = Constants.EventMenuName + "Collider Event",
        order = Constants.EventMenuOrderUnityObject + 1
    )]
    public class ColliderEventSO : EventSO<Collider>
    {

    }
}