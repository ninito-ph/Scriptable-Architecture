using UnityEngine;

namespace ScriptableArchitecture.ScriptableVariables
{
    /// <summary>
    /// A Scriptable Variable allows for the use of a <see cref="ReferenceVariable{T}"/> or a value type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    public abstract class ScriptableVariable<T, U> where U : ReferenceVariable<T>
    {
        #region Field Declarations
        private bool _useConstant = true;
        private T _constant;
        private U _variable;
        #endregion

        #region Properties
        /// <summary>
        /// Gets the value of the meta type
        /// </summary>
        public T Value
        {
            get
            {
                if (_useConstant == true)
                {
                    return _constant;
                }

                if (_variable == null)
                {
                    return _constant;
                }
                else
                {
                    return _variable.Value;
                }
            }
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
        /// directly referencing the .Value property, by cleverly implicitly
        /// implying the use of the .Value property by default
        /// </summary>
        /// <param name="variable"></param>
        public static implicit operator T(ScriptableVariable<T, U> variable)
        {
            return variable.Value;
        }

        /// <summary>
        /// Initializes variable as a constant
        /// </summary>
        public ScriptableVariable()
        {
            _useConstant = true;
        }

        /// <summary>
        /// Initializes variable as a constant and assigns it a value
        /// </summary>
        /// <param name="startingValue">The starting value of the constant</param>
        public ScriptableVariable(T startingValue)
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