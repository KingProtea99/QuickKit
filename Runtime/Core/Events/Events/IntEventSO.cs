using UnityEngine;

namespace KP.QuickKit
{
    [CreateAssetMenu(
        fileName = "Int Event",
        menuName = Constants.EventMenuName + "Int Event",
        order = Constants.EventMenuOrderPrimitive + 0
    )]
    public class IntEventSO : EventSO<int>
    {

    }
}