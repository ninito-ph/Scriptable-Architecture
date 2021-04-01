using UnityEngine;

namespace ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateMenus.AnimationCurveEventFilename, 
        menuName = CreateMenus.AnimationCurveEventMenu, order = CreateMenus.AnimationCurveEventOrder)]
    public class AnimationCurveEvent : Event<AnimationCurve>
    {
    }
}