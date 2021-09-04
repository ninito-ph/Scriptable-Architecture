using UnityEngine;

namespace Ninito.ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateAssetMenus.Vector2EventFilename, menuName = CreateAssetMenus.Vector2EventMenu,
        order = CreateAssetMenus.Vector2EventOrder)]
    public class Vector2Event : GameEvent<Vector2>
    {
        
    }
}