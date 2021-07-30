using UnityEngine;

namespace Ninito.ScriptableArchitecture.Actions
{
    /// <summary>
    ///     An action that can be executed
    /// </summary>
    public abstract class ScriptableAction : ScriptableObject
    {
        /// <summary>
        ///     Executes the Scriptable Action
        /// </summary>
        /// <returns>Whether the action succeeded</returns>
        public abstract bool Execute();
    }
    
    /// <summary>
    ///     An action that can be with a given parameter
    /// </summary>
    /// <typeparam name="T">The type of the argument requested by the action</typeparam>
    public abstract class ScriptableAction<T> : ScriptableObject
    {
        /// <summary>
        ///     Executes the Scriptable Action
        /// </summary>
        /// <param name="argument">The argument received by the action</param>
        /// <returns>Whether the action succeeded</returns>
        public abstract bool Execute(T argument);
    }

    /// <summary>
    ///     An action that can be with a given parameter
    /// </summary>
    /// <typeparam name="T">The type of the argument requested by the action</typeparam>
    /// <typeparam name="TU">The type of the second argument requested by the action</typeparam>
    public abstract class ScriptableAction<T, TU> : ScriptableObject
    {
        /// <summary>
        ///     Executes the Scriptable Action
        /// </summary>
        /// <param name="argument">The argument received by the action</param>
        /// <param name="secondArgument">The second argument received by the action</param>
        /// <returns>Whether the action succeeded</returns>
        public abstract bool Execute(T argument, TU secondArgument);
    }

    /// <summary>
    ///     An action that can be with a given parameter
    /// </summary>
    /// <typeparam name="T">The type of the argument requested by the action</typeparam>
    /// <typeparam name="TU">The type of the second argument requested by the action</typeparam>
    /// <typeparam name="TV">The type of the third argument requested by the action</typeparam>
    public abstract class ScriptableAction<T, TU, TV> : ScriptableObject
    {
        /// <summary>
        ///     Executes the Scriptable Action
        /// </summary>
        /// <param name="argument">The argument received by the action</param>
        /// <param name="secondArgument">The second argument received by the action</param>
        /// <param name="thirdArgument">The third argument received by the action</param>
        /// <returns>Whether the action succeeded</returns>
        public abstract bool Execute(T argument, TU secondArgument, TV thirdArgument);
    }

    /// <summary>
    ///     An action that can be with a given parameter
    /// </summary>
    /// <typeparam name="T">The type of the argument requested by the action</typeparam>
    /// <typeparam name="TU">The type of the second argument requested by the action</typeparam>
    /// <typeparam name="TV">The type of the third argument requested by the action</typeparam>
    /// <typeparam name="TY">The type of the fourth argument requested by the action</typeparam>
    public abstract class ScriptableAction<T, TU, TV, TY> : ScriptableObject
    {
        /// <summary>
        ///     Executes the Scriptable Action
        /// </summary>
        /// <param name="argument">The argument received by the action</param>
        /// <param name="secondArgument">The second argument received by the action</param>
        /// <param name="thirdArgument">The third argument received by the action</param>
        /// <param name="fourthArgument">The fourth argument received by the action</param>
        /// <returns>Whether the action succeeded</returns>
        public abstract bool Execute(T argument, TU secondArgument, TV thirdArgument, TY fourthArgument);
    }
}