using UnityEngine;

namespace Ninito.ScriptableArchitecture.Variables
{
    [System.Serializable]
    public class Vector2Reference : Reference<Vector2, Vector2Variable>
    {
        public Vector2Reference(Vector2 value) : base(value)
        {
        }
    }
}