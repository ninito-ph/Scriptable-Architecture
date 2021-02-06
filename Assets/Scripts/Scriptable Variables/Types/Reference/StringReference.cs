using UnityEngine;

namespace ScriptableArchitecture.ScriptableVariables
{
    [CreateAssetMenu(fileName = CreateMenus.StringReferenceFileName, menuName = CreateMenus.StringReferenceMenu, order = CreateMenus.StringReferenceOrder)]
    public class StringReference : ReferenceVariable<string>
    {
    }
}