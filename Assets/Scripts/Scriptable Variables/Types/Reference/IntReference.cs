using UnityEngine;

namespace ScriptableArchitecture.ScriptableVariables
{
    [CreateAssetMenu(fileName = CreateMenus.intReferenceFileName, menuName = CreateMenus.intReferenceMenu, order = CreateMenus.intReferenceOrder)]
    public class IntReference : ReferenceVariable<int>
    {
    }
}