using UnityEngine;

namespace KP.QuickKit
{
    [CreateAssetMenu(
        fileName = "Collider2D Event",
        menuName = Constants.EventMenuName + "Collider2D Event",
        order = Constants.EventMenuOrderUnityObject + 0
    )]
    public class Collider2DEventSO : EventSO<Collider2D>
    {

    }
}