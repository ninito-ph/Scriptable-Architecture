using UnityEngine;

namespace Ninito.ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateAssetMenus.ColorVariableFileName, menuName = CreateAssetMenus.ColorEventMenu,
        order = CreateAssetMenus.ColorEventOrder)]
    public class ColorEvent : GameEvent<Color>
    {
        
    }
}