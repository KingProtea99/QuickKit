using UnityEngine;

namespace KP.QuickKit
{
    [CreateAssetMenu(
        fileName = "String Event",
        menuName = Constants.EventMenuName + "String Event",
        order = Constants.EventMenuOrderPrimitive + 2
    )]
    public class StringEventSO : EventSO<string>
    {

    }
}