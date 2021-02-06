using UnityEngine;

namespace ScriptableArchitecture.ScriptableVariables
{
    [CreateAssetMenu(fileName = CreateMenus.floatReferenceFileName, menuName = CreateMenus.floatReferenceMenu, order = CreateMenus.floatReferenceOrder)]
    public class FloatReference : ReferenceVariable<float>
    {
    }
}