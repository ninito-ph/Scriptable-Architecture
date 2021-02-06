using UnityEngine;

namespace ScriptableArchitecture.ScriptableVariables
{
    [CreateAssetMenu(fileName = CreateMenus.Vector2ReferenceFileName, menuName = CreateMenus.Vector2ReferenceMenu, order = CreateMenus.Vector2ReferenceOrder)]
    public class Vector2Reference : ReferenceVariable<Vector2>
    {
    }
}