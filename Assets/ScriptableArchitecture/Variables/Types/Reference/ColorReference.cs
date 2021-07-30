using UnityEngine;

namespace Ninito.ScriptableArchitecture.Variables
{
    [System.Serializable]
    public class ColorReference : Reference<Color, ColorVariable>
    {
        public ColorReference(Color value) : base(value)
        {
        }
    }
}