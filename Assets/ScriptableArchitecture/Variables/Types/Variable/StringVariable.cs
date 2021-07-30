using UnityEngine;

namespace Ninito.ScriptableArchitecture.Variables
{
    [CreateAssetMenu(fileName = CreateAssetMenus.StringVariableFileName, menuName = CreateAssetMenus.StringVariableMenu, 
        order = CreateAssetMenus.StringVariableOrder)]
    public class StringVariable : Variable<string>
    {
    }
}