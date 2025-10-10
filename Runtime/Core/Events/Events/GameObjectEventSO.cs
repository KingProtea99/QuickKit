using UnityEngine;

namespace KP.QuickKit
{
    [CreateAssetMenu(
        fileName = "GameObject Event",
        menuName = Constants.EventMenuName + "GameObject Event",
        order = Constants.EventMenuOrderUnityObject + 2
    )]
    public class GameObjectEventSO : EventSO<GameObject>
    {

    }
}