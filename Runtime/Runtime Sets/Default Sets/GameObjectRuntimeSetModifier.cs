using UnityEngine;

namespace Ninito.ScriptableArchitecture.RuntimeSets
{
    public class GameObjectRuntimeSetModifier : RuntimeSetModifier<GameObjectRuntimeSet, GameObject>
    {
        #region Unity Callbacks

        private void Reset()
        {
            GameObject gameObjectCache = gameObject;
            
            objectToAdd = gameObjectCache;
            objectKey = gameObjectCache.name;
        }

        #endregion

        #region Abstract Implementations

        protected override void AddToRuntimeSet()
        {
            runtimeSet.Add(objectKey, objectToAdd);
        }

        #endregion
    }
}