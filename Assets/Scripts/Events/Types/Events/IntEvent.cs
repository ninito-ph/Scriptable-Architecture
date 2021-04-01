using UnityEngine;

namespace ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateMenus.IntEventFilename, menuName = CreateMenus.IntEventMenu,
        order = CreateMenus.IntEventOrder)]
    public class IntEvent : Event<int>
    {
        
    }
}