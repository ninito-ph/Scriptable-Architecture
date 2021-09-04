using UnityEngine;

namespace Ninito.ScriptableArchitecture.Variables
{
    [CreateAssetMenu(fileName = CreateAssetMenus.Vector4VariableFileName, menuName = CreateAssetMenus.Vector4VariableMenu, 
        order = CreateAssetMenus.Vector4VariableOrder)]
    public class Vector4Variable : Variable<Vector4>
    {
    }
}