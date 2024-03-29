using UnityEngine;
using UnityEngine.Events;

namespace Ninito.ScriptableArchitecture.Events
{
    public class Vector4EventListener : EventListener<Vector4>
    {
        #region Private Fields

        [SerializeField] private Vector4Event _event;
        [SerializeField] private UnityEvent<Vector4> _unityEvent = new UnityEvent<Vector4>();
        
        #endregion

        #region EventListener Implementation

        public override UnityEvent<Vector4> UnityEvent => _unityEvent;
        public override GameEvent<Vector4> GameEvent
        {
            get => _event;
            set
            {
                if (_event != null)
                {
                    _event.RemoveListener(this);
                }
            
                _event = value as Vector4Event;
            
                if (_event != null)
                {
                    _event.AddListener(this);
                }
            }
        }

        #endregion
    }
}