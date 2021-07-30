using UnityEngine;

namespace Ninito.ScriptableArchitecture.Variables
{
    [CreateAssetMenu(fileName = CreateAssetMenus.ColorVariableFileName, menuName = CreateAssetMenus.ColorVariableMenu, 
        order = CreateAssetMenus.ColorVariableOrder)]
    public class ColorVariable : Variable<Color>
    {
    }
}