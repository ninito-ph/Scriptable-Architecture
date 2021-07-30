using UnityEngine;

namespace Ninito.ScriptableArchitecture.Variables
{
    [CreateAssetMenu(fileName = CreateAssetMenus.Vector2VariableFileName, menuName = CreateAssetMenus.Vector2VariableMenu, 
        order = CreateAssetMenus.Vector2VariableOrder)]
    public class Vector2Variable : Variable<Vector2>
    {
    }
}