using UnityEngine;

namespace KP.QuickKit
{
    [CreateAssetMenu(
        fileName = "Bool Event",
        menuName = Constants.EventMenuName + "Bool Event",
        order = Constants.EventMenuOrderPrimitive + 3
    )]
    public class BoolEventSO : EventSO<bool>
    {

    }
}