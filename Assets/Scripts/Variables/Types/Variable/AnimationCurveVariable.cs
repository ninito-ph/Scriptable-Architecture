using UnityEngine;

namespace ScriptableArchitecture.Variables
{
    [CreateAssetMenu(fileName = CreateMenus.AnimationCurveVariableFileName, 
        menuName = CreateMenus.AnimationCurveVariableMenu, order = CreateMenus.AnimationCurveVariableOrder)]
    public class AnimationCurveVariable : Variable<AnimationCurve>
    {
    }
}