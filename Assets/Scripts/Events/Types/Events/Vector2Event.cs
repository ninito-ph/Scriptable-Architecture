using UnityEngine;

namespace ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateMenus.Vector2EventFilename, menuName = CreateMenus.Vector2EventMenu,
        order = CreateMenus.Vector2EventOrder)]
    public class Vector2Event : Event<Vector2>
    {
        
    }
}