using UnityEngine;

namespace KP.QuickKit
{
    [CreateAssetMenu(
        fileName = "Transform Event",
        menuName = Constants.EventMenuName + "Transform Event",
        order = Constants.EventMenuOrderUnityObject + 3
    )]
    public class TransformEventSO : EventSO<Transform>
    {

    }
}