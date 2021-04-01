using System;
using ScriptableArchitecture.Events.Types;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableArchitecture.Events
{
    /// <summary>
    /// Listens to an <see cref="Event"/>.
    /// </summary>
    public class EventListener : MonoBehaviour
    {
        #region Private Fields

        [SerializeField] private Event _event;
        [SerializeField] private UnityEvent _onEventInvoked;

        #endregion

        #region Properties

        public Event Event
        {
            get => _event;
        }

        #endregion

        #region MonoBehaviour Implementation

        private void OnEnable()
        {
            _event.AddListener(this);
        }

        private void OnDisable()
        {
            _event.RemoveListener(this);
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Invokes the unity event when the event is invoked
        /// </summary>
        public void OnEventInvoked()
        {
            _onEventInvoked.Invoke();
        }

        #endregion
    }

    /// <summary>
    /// Listens to an event with an argument of type T
    /// </summary>
    /// <typeparam name="T">An argument of type T</typeparam>
    public abstract class EventListener<T> : MonoBehaviour, IEventListener<T>
    {
        #region Abstract Properties

        public abstract UnityEvent<T> UnityEvent { get; }
        public abstract Event<T> Event { get; }

        #endregion

        #region MonoBehaviour Implementation

        private void OnEnable()
        {
            Event.AddListener(this);
        }

        private void OnDisable()
        {
            Event.RemoveListener(this);
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Invokes the unity event when the event is invoked
        /// </summary>
        public void OnEventInvoked(T value)
        {
            UnityEvent.Invoke(value);
        }

        #endregion
    }
}