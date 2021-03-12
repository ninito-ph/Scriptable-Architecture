using System;

namespace ScriptableArchitecture.Variables
{
    [Serializable]
    public class FloatReference : Reference<float, Variable<float>>
    {
        public FloatReference(float value) : base(value)
        {
        }
    }
}