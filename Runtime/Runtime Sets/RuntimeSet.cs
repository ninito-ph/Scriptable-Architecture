using System;
using System.Collections.Generic;
using UnityEngine;

namespace Ninito.ScriptableArchitecture.RuntimeSets
{
    /// <summary>
    ///     A runtime set of a given object type
    /// </summary>
    /// <typeparam name="T">The type contained within the runtime set</typeparam>
    public abstract class RuntimeSet<T> : ScriptableObject
    {
        #region Private Fields

        [NonSerialized]
        private readonly Dictionary<string, T> _set = new Dictionary<string, T>();

        #endregion

        #region Properties

        [field: SerializeField]
        [field: TextArea]
        [field: Tooltip("How this set should be used, and what it should contain.")]
        public string UsageDescription { get; private set; } = String.Empty;

        #endregion

        #region Public Methods

        public bool ContainsKey(string key) => _set.ContainsKey(key);
        public bool Contains(T setObject) => _set.ContainsValue(setObject); 
        
        /// <summary>
        ///     Gets a specific item from the set
        /// </summary>
        /// <param name="key">The key of the desired item</param>
        /// <returns>The item at the given index</returns>
        public T Get(string key)
        {
            return _set[key];
        }

        /// <summary>
        ///     Gets a specific item from the set
        /// </summary>
        /// <param name="key">The key of the desired item</param>
        /// <param name="result"></param>
        /// <returns>The item at the given index</returns>
        public bool TryToGet(string key, out T result)
        {
            if (_set.ContainsKey(key))
            {
                result = _set[key];
                return true;
            }
            else
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        ///     Adds an item to the set
        /// </summary>
        /// <param name="key">The key to add the item to</param>
        /// <param name="item">The item to add</param>
        public void Add(string key, T item)
        {
            if (_set.ContainsValue(item)) return;
            _set.Add(key, item);
        }

        /// <summary>
        ///     Removes an item from the runtime set
        /// </summary>
        /// <param name="key">The key to remove</param>
        public void Remove(string key)
        {
            _set.Remove(key);
        }

        #endregion

        #region Private Methods

        /// <summary>
        ///     Resets the runtime set
        /// </summary>
        private void ResetRuntimeSet()
        {
            _set.Clear();
        }

        #endregion
    }
}