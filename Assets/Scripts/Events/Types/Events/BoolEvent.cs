using UnityEngine;

namespace ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateMenus.BoolEventFilename, menuName = CreateMenus.BoolEventMenu,
        order = CreateMenus.BoolEventOrder)]
    public class BoolEvent : Event<bool>
    {
    }
}