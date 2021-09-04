using UnityEngine;

namespace Ninito.ScriptableArchitecture.Variables
{
    [CreateAssetMenu(fileName = CreateAssetMenus.floatVariableFileName, menuName = CreateAssetMenus.floatVariableMenu, 
        order = CreateAssetMenus.floatVariableOrder)]
    public class FloatVariable : Variable<float>
    {
    }
}