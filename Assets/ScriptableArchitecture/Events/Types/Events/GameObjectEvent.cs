using UnityEngine;

namespace Ninito.ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateAssetMenus.GameObjectEventFilename, menuName = CreateAssetMenus.GameObjectEventMenu,
        order = CreateAssetMenus.GameObjectEventOrder)]
    public class GameObjectEvent : GameEvent<GameObject>
    {
        
    }
}