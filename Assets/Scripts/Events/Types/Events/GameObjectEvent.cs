using UnityEngine;

namespace ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateMenus.GameObjectEventFilename, menuName = CreateMenus.GameObjectEventMenu,
        order = CreateMenus.GameObjectEventOrder)]
    public class GameObjectEvent : Event<GameObject>
    {
        
    }
}