﻿namespace Ninito.ScriptableArchitecture.Variables
{
    [System.Serializable]
    public class FloatReference : Reference<float, FloatVariable>
    {
        public FloatReference(float value) : base(value)
        {
        }
    }
}