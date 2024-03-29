﻿using UnityEngine;

namespace Ninito.ScriptableArchitecture.Variables
{
    [System.Serializable]
    public class Vector4Reference : Reference<Vector4, Vector4Variable>
    {
        public Vector4Reference(Vector4 value) : base(value)
        {
        }
    }
}