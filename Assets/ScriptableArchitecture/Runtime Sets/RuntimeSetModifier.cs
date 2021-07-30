using System;
using UnityEngine;

namespace Ninito.ScriptableArchitecture.RuntimeSets
{
    /// <summary>
    ///     A class that modifies a runtime set by adding or removing an object
    /// </summary>
    /// <typeparam name="T">The type of the RuntimeSet</typeparam>
    /// <typeparam name="TU">The type of the object being added to the RuntimeSet</typeparam>
    public abstract class RuntimeSetModifier<T, TU> : MonoBehaviour
    {
        #region Protected Fields

        [Header("Runtime Set"), SerializeField]
        protected T runtimeSet;

        [Header("Object"), SerializeField]
        protected string objectKey;
        
        [SerializeField]
        protected TU objectToAdd;
        
        [SerializeField]
        protected Mode mode = Mode.Add;

        #endregion

        #region Unity Callbacks

        private void Start()
        {
            ModifyRuntimeSet();
        }

        #endregion

        #region Protected Methods

        protected abstract void ModifyRuntimeSet();

        #endregion

        #region Protected Enums

        [Serializable]
        protected enum Mode
        {
            Add,
            Remove
        }

        #endregion
    }
}