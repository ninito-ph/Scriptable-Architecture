using System;
using UnityEngine;

namespace ScriptableArchitecture.Variables
{
    [Serializable]
    public class ColorReference : Reference<Color, Variable<Color>>
    {
        public ColorReference(Color value) : base(value)
        {
        }
    }
}