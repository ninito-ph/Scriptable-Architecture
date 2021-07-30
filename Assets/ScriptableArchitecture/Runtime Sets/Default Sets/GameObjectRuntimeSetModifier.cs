using System;
using UnityEngine;

namespace Ninito.ScriptableArchitecture.RuntimeSets
{
    public class GameObjectRuntimeSetModifier : RuntimeSetModifier<GameObjectRuntimeSet, GameObject>
    {
        protected override void ModifyRuntimeSet()
        {
            switch (mode)
            {
                case Mode.Add:
                    runtimeSet.Add(objectKey, objectToAdd);
                    break;
                case Mode.Remove:
                    runtimeSet.Remove(objectKey);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}