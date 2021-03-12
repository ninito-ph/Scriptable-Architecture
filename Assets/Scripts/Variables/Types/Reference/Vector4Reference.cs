using System;
using UnityEngine;

namespace ScriptableArchitecture.Variables
{
    [Serializable]
    public class Vector4Reference : Reference<Vector4, Variable<Vector4>>
    {
        public Vector4Reference(Vector4 value) : base(value)
        {
        }
    }
}