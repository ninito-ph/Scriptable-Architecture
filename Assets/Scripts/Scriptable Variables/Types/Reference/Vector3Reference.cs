using UnityEngine;

namespace ScriptableArchitecture.ScriptableVariables
{
    [CreateAssetMenu(fileName = CreateMenus.Vector3ReferenceFileName, menuName = CreateMenus.Vector3ReferenceMenu, order = CreateMenus.Vector3ReferenceOrder)]
    public class Vector3Reference : ReferenceVariable<Vector3>
    {
    }
}