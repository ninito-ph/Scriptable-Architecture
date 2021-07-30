using UnityEngine;

namespace Ninito.ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateAssetMenus.AnimationCurveEventFilename, 
        menuName = CreateAssetMenus.AnimationCurveEventMenu, order = CreateAssetMenus.AnimationCurveEventOrder)]
    public class AnimationCurveEvent : GameEvent<AnimationCurve>
    {
    }
}