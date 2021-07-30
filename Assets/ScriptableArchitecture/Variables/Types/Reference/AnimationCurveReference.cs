using UnityEngine;

namespace Ninito.ScriptableArchitecture.Variables
{
    [System.Serializable]
    public class AnimationCurveReference : Reference<AnimationCurve, AnimationCurveVariable>
    {
        public AnimationCurveReference(AnimationCurve value) : base(value)
        {
        }
    }
}