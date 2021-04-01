using UnityEngine;

namespace ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateMenus.StringEventFilename, menuName = CreateMenus.StringEventMenu,
        order = CreateMenus.StringEventOrder)]
    public class StringEvent : Event<string>
    {
        
    }
}