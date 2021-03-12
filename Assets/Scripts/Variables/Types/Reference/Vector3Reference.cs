using System;
using UnityEngine;

namespace ScriptableArchitecture.Variables
{
    [Serializable]
    public class Vector3Reference : Reference<Vector3, Variable<Vector3>>
    {
        public Vector3Reference(Vector3 value) : base(value)
        {
        }
    }
}