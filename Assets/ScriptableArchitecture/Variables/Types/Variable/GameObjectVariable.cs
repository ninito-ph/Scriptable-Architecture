using UnityEngine;

namespace Ninito.ScriptableArchitecture.Variables
{
    [CreateAssetMenu(fileName = CreateAssetMenus.GameObjectVariableFileName, 
        menuName = CreateAssetMenus.GameObjectVariableMenu, order = CreateAssetMenus.GameObjectVariableOrder)]
    public class GameObjectVariable : Variable<GameObject>
    {
    }
}