using System.Collections.Generic;
using ScriptableArchitecture.Events.Types;
using UnityEngine;

namespace ScriptableArchitecture.Events
{
    /// <summary>
    /// A class that contains a invokable event for communication between scripts
    /// </summary>
    [CreateAssetMenu(fileName = CreateMenus.EventFileName, menuName = CreateMenus.EventMenu, 
        order = CreateMenus.EventOrder)]
    public class Event : ScriptableObject
    {
        #region Private Fields
        [Multiline] [SerializeField]
        private string _description = string.Empty;
        [SerializeField] 
        private bool _debug = false;

        private List<EventListener> _listeners = new List<EventListener>();
        #endregion

        #region Properties

        public List<EventListener> Listeners
        {
            get => _listeners;
        }

        #endregion
        
        #region Public Functions
        [ContextMenu("Invoke")]
        public void Invoke()
        {
            if (_debug)
            {
                Debug.Log($"<b>{name}</b> event raised successfully.", this);
            }

            for (int index = 0, upper = _listeners.Count; index < upper; index++)
            {
                _listeners[index].OnEventInvoked();
            }
        }

        /// <summary>
        /// Adds a listener to the event
        /// </summary>
        /// <param name="listener">The listener to be added</param>
        public void AddListener(EventListener listener)
        {
            _listeners.Add(listener);
        }

        /// <summary>
        /// Removes a listener from the event
        /// </summary>
        /// <param name="listener">The listener to be removed</param>
        public void RemoveListener(EventListener listener)
        {
            _listeners.Remove(listener);
        }

        /// <summary>
        /// Removes all listeners from the event
        /// </summary>
        public void RemoveAllListeners()
        {
            _listeners.Clear();
        }
        #endregion

    }

    public class Event<T> : ScriptableObject
    {
        #region Private Fields

        [SerializeField] 
        private T _value;
        [Multiline] [SerializeField]
        private string _description = string.Empty;
        [SerializeField]
        private bool _debug = false;

        private readonly List<IEventListener<T>> _listeners = new List<IEventListener<T>>();
        
        #endregion

        #region Properties

        public List<IEventListener<T>> Listeners
        {
            get => _listeners;
        }

        public T Value
        {
            get => _value;
            set => _value = value;
        }

        #endregion
        
        #region Public Functions
        [ContextMenu("Invoke")]
        public void Invoke()
        {
            if (_debug)
            {
                Debug.Log($"<b>{name}</b> event raised successfully with value: {_value}.", this);
            }

            for (int index = 0, upper = _listeners.Count; index < upper; index++)
            {
                _listeners[index].OnEventInvoked(_value);
            }
        }

        /// <summary>
        /// Adds a listener to the event
        /// </summary>
        /// <param name="listener">The listener to be added</param>
        public void AddListener(IEventListener<T> listener)
        {
            _listeners.Add(listener);
        }

        /// <summary>
        /// Removes a listener from the event
        /// </summary>
        /// <param name="listener">The listener to be removed</param>
        public void RemoveListener(IEventListener<T> listener)
        {
            _listeners.Remove(listener);
        }

        /// <summary>
        /// Removes all listeners from the event
        /// </summary>
        public void RemoveAllListeners()
        {
            _listeners.Clear();
        }
        #endregion
    }
}