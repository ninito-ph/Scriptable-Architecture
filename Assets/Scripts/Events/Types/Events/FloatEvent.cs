using UnityEngine;

namespace ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateMenus.FloatEventFilename, menuName = CreateMenus.FloatEventMenu,
        order = CreateMenus.FloatEventOrder)]
    public class FloatEvent : Event<float>
    {
        
    }
}