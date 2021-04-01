using UnityEngine;

namespace ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateMenus.ColorVariableFileName, menuName = CreateMenus.ColorEventMenu,
        order = CreateMenus.ColorEventOrder)]
    public class ColorEvent : Event<Color>
    {
        
    }
}