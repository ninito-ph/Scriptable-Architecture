using System;
using System.Collections.Generic;
using Ninito.ScriptableArchitecture.Events.Types;
using UnityEngine;

namespace Ninito.ScriptableArchitecture.Events
{
    /// <summary>
    ///     A class that contains a invokable event for communication between scripts
    /// </summary>
    [CreateAssetMenu(fileName = CreateAssetMenus.EventFileName, menuName = CreateAssetMenus.EventMenu,
        order = CreateAssetMenus.EventOrder)]
    public sealed class GameEvent : ScriptableObject, IEvent
    {
        #region Private Fields

        [Multiline]
        [SerializeField]
        private string description = String.Empty;

        [SerializeField]
        private bool _debug;

        #endregion

        #region Properties

        public List<EventListener> Listeners { get; } = new List<EventListener>();

        #endregion

        #region Public Functions

        /// <summary>
        ///     Invokes the event
        /// </summary>
        public void Invoke()
        {
            if (_debug)
            {
                Debug.Log($"<b>{name}</b> event raised to <b>{Listeners.Count}</b> listeners.", this);
            }

            for (int index = Listeners.Count - 1; index >= 0; index--)
            {
                if (Listeners[index] == null)
                {
                    Listeners.RemoveAt(index);
                    continue;
                }
                
                if (_debug)
                {
                    Debug.Log($"Listener <b>{Listeners[index]}</b> was called.");
                }

                Listeners[index].OnEventInvoked();
            }
        }

        /// <summary>
        ///     Adds a listener to the event
        /// </summary>
        /// <param name="listener">The listener to be added</param>
        public void AddListener(EventListener listener)
        {
            Listeners.Add(listener);
        }

        /// <summary>
        ///     Removes a listener from the event
        /// </summary>
        /// <param name="listener">The listener to be removed</param>
        public void RemoveListener(EventListener listener)
        {
            Listeners.Remove(listener);
        }

        /// <summary>
        ///     Removes all listeners from the event
        /// </summary>
        public void RemoveAllListeners()
        {
            Listeners.Clear();
        }

        #endregion
    }

    public class GameEvent<T> : ScriptableObject, IEvent
    {
        #region Private Fields

        [SerializeField]
        private T _value;

        [Multiline]
        [SerializeField]
        private string description = String.Empty;

        [SerializeField]
        private bool _debug;

        #endregion

        #region Properties

        public List<IEventListener<T>> Listeners { get; } = new List<IEventListener<T>>();

        public T Value
        {
            get => _value;
            set => _value = value;
        }

        #endregion

        #region Public Functions

        /// <summary>
        ///     Invokes the event
        /// </summary>
        public void Invoke()
        {
            if (_debug)
            {
                Debug.Log(
                    $"<b>{name}</b> event raised with value <b>{_value}</b> to <b>{Listeners.Count}</b> listeners.",
                    this);
            }

            for (int index = Listeners.Count - 1; index >= 0; index--)
            {
                if (Listeners[index] == null)
                {
                    Listeners.RemoveAt(index);
                    continue;
                }
                
                if (_debug)
                {
                    Debug.Log($"Listener <b>{Listeners[index]}</b> was called.");
                }

                Listeners[index].OnEventInvoked(_value);
            }
        }

        /// <summary>
        ///     Invokes the event with a specific value
        /// </summary>
        /// <param name="value">The specific value to invoke with</param>
        public void Invoke(T value)
        {
            if (_debug)
            {
                Debug.Log(
                    $"<b>{name}</b> event raised with value <b>{value}</b> to <b>{Listeners.Count}</b> listeners.",
                    this);
            }

            for (int index = Listeners.Count - 1; index >= 0; index--)
            {
                if (Listeners[index] == null)
                {
                    Listeners.RemoveAt(index);
                    continue;
                }
                
                if (_debug)
                {
                    Debug.Log($"Listener <b>{Listeners[index]}</b> was called.");
                }

                Listeners[index].OnEventInvoked(value);
            }
        }

        /// <summary>
        ///     Adds a listener to the event
        /// </summary>
        /// <param name="listener">The listener to be added</param>
        public void AddListener(IEventListener<T> listener)
        {
            Listeners.Add(listener);
        }

        /// <summary>
        ///     Removes a listener from the event
        /// </summary>
        /// <param name="listener">The listener to be removed</param>
        public void RemoveListener(IEventListener<T> listener)
        {
            Listeners.Remove(listener);
        }

        /// <summary>
        ///     Removes all listeners from the event
        /// </summary>
        public void RemoveAllListeners()
        {
            Listeners.Clear();
        }

        #endregion
    }
}