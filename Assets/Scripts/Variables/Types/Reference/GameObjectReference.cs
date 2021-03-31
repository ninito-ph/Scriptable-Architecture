﻿using UnityEngine;

namespace ScriptableArchitecture.Variables
{
    [System.Serializable]
    public class GameObjectReference : Reference<GameObject, GameObjectVariable>
    {
        public GameObjectReference(GameObject value) : base(value)
        {
        }
    }
}