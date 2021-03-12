using System;
using UnityEngine;

namespace ScriptableArchitecture.Variables
{
    [Serializable]
    public class Vector2Reference : Reference<Vector2, Variable<Vector2>>
    {
        public Vector2Reference(Vector2 value) : base(value)
        {
        }
    }
}