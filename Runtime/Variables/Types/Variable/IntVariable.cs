using UnityEngine;

namespace Ninito.ScriptableArchitecture.Variables
{
    [CreateAssetMenu(fileName = CreateAssetMenus.intVariableFileName, menuName = CreateAssetMenus.intVariableMenu, 
        order = CreateAssetMenus.intVariableOrder)]
    public class IntVariable : Variable<int>
    {
    }
}