using UnityEngine;

namespace Ninito.ScriptableArchitecture.Variables
{
    [CreateAssetMenu(fileName = CreateAssetMenus.AnimationCurveVariableFileName, 
        menuName = CreateAssetMenus.AnimationCurveVariableMenu, order = CreateAssetMenus.AnimationCurveVariableOrder)]
    public class AnimationCurveVariable : Variable<AnimationCurve>
    {
    }
}