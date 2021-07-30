using UnityEditor;
using UnityEngine;

namespace Ninito.ScriptableArchitecture.Events
{
    #if UNITY_EDITOR
    [CustomEditor(typeof(AnimationCurveEvent))]
    public class AnimationCurveEventEditor : GameEventEditor<AnimationCurve>
    {
        
    }
    #endif
}