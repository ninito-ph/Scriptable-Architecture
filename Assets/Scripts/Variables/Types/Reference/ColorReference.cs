using UnityEngine;

namespace ScriptableArchitecture.Variables
{
    [System.Serializable]
    public class ColorReference : Reference<Color, ColorVariable>
    {
        public ColorReference(Color value) : base(value)
        {
        }
    }
}