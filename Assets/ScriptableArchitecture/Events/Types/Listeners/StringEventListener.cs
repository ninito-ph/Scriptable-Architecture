using UnityEngine;
using UnityEngine.Events;

namespace Ninito.ScriptableArchitecture.Events
{
    public class StringEventListener : EventListener<string>
    {
        #region Private Fields

        [SerializeField] private StringEvent _event;
        [SerializeField] private UnityEvent<string> _unityEvent = new UnityEvent<string>();
        
        #endregion

        #region EventListener Implementation

        public override UnityEvent<string> UnityEvent => _unityEvent;
        public override GameEvent<string> GameEvent
        {
            get => _event;
            set
            {
                if (_event != null)
                {
                    _event.RemoveListener(this);
                }
            
                _event = value as StringEvent;
            
                if (_event != null)
                {
                    _event.AddListener(this);
                }
            }
        }

        #endregion
    }
}