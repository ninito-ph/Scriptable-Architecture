using System;
using UnityEngine;

namespace ScriptableArchitecture.Variables
{
    /// <summary>
    /// A Reference allows for the use of a <see cref="Variable{T}"/> or a value type.
    /// </summary>
    /// <typeparam name="T">The type of the reference value</typeparam>
    /// <typeparam name="U">A variable of the same type of the reference value</typeparam>
    [Serializable]
    public abstract class Reference<T, U> where U : Variable<T>
    {
        #region Field Declarations
        private bool _useConstant;
        private T _constant;
        private U _variable;
        #endregion

        #region Properties
        /// <summary>
        /// Gets the value of the reference
        /// </summary>
        public T Value
        {
            get => _useConstant ? _constant : _variable.Value;
            set
            {
                if (_useConstant == true)
                {
                    _constant = value;
                }
            
                if (_variable != null)
                {
                    _variable.Value = value;
                }
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Removes the need for implementing IComparable, IEquatable and
        /// directly referencing the .Value property, by implicitly
        /// implying the use of the .Value property by default
        /// </summary>
        /// <param name="reference"></param>
        public static implicit operator T(Reference<T, U> reference)
        {
            return reference.Value;
        }

        /// <summary>
        /// Initializes variable as a constant
        /// </summary>
        public Reference()
        {
            _useConstant = true;
        }

        /// <summary>
        /// Initializes variable as a constant and assigns it a value
        /// </summary>
        /// <param name="startingValue">The starting value of the constant</param>
        public Reference(T startingValue)
        {
            _useConstant = true;
            _constant = startingValue;
        }

        /// <summary>
        /// Returns the variable's value as a string
        /// </summary>
        /// <returns>A string of the variable's value</returns>
        public override string ToString()
        {
            return Value.ToString();
        }
        #endregion
    }
}