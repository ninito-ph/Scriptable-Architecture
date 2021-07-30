using UnityEngine;

namespace Ninito.ScriptableArchitecture.Variables
{
    [CreateAssetMenu(fileName = CreateAssetMenus.boolVariableFileName, menuName = CreateAssetMenus.boolVariableMenu, 
        order = CreateAssetMenus.boolVariableOrder)]
    public class BoolVariable : Variable<bool>
    {
    }
}