using UnityEngine;

namespace Ninito.ScriptableArchitecture.Variables
{
    [CreateAssetMenu(fileName = CreateAssetMenus.Vector3VariableFileName, menuName = CreateAssetMenus.Vector3VariableMenu, 
        order = CreateAssetMenus.Vector3VariableOrder)]
    public class Vector3Variable : Variable<Vector3>
    {
    }
}