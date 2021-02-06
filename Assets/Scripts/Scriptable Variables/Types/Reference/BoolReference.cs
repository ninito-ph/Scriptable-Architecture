using UnityEngine;

namespace ScriptableArchitecture.ScriptableVariables
{
    [CreateAssetMenu(fileName = CreateMenus.boolReferenceFileName, menuName = CreateMenus.boolReferenceMenu, order = CreateMenus.boolReferenceOrder)]
    public class BoolReference : ReferenceVariable<bool>
    {
    }
}