using System;
using UnityEngine;

namespace ScriptableArchitecture.Variables
{
    [Serializable]
    public class GameObjectReference : Reference<GameObject, Variable<GameObject>>
    {
        public GameObjectReference(GameObject value) : base(value)
        {
        }
    }
}