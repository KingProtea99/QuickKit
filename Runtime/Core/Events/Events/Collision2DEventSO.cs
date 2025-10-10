using UnityEngine;

namespace KP.QuickKit
{
    [CreateAssetMenu(
        fileName = "Collision2D Event",
        menuName = Constants.EventMenuName + "Collision2D Event",
        order = Constants.EventMenuOrderUnityPrimitive + 2
    )]
    public class Collision2DEventSO : EventSO<Collision2D>
    {

    }
}