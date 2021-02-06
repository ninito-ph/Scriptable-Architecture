using UnityEngine;

namespace ScriptableArchitecture.ScriptableVariables
{
    [CreateAssetMenu(fileName = CreateMenus.ColorReferenceFileName, menuName = CreateMenus.ColorReferenceMenu, order = CreateMenus.ColorReferenceOrder)]
    public class ColorReference : ReferenceVariable<Color>
    {
    }
}