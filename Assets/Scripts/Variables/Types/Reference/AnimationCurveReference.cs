using UnityEngine;

namespace ScriptableArchitecture.Variables
{
    [System.Serializable]
    public class AnimationCurveReference : Reference<AnimationCurve, AnimationCurveVariable>
    {
        public AnimationCurveReference(AnimationCurve value) : base(value)
        {
        }
    }
}