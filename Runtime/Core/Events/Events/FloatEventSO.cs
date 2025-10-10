using UnityEngine;

namespace KP.QuickKit
{
    [CreateAssetMenu(
        fileName = "Float Event",
        menuName = Constants.EventMenuName + "Float Event",
        order = Constants.EventMenuOrderPrimitive + 1
    )]
    public class FloatEventSO : EventSO<float>
    {

    }
}