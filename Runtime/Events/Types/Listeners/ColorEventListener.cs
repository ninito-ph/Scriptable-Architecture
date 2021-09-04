using UnityEngine;
using UnityEngine.Events;

namespace Ninito.ScriptableArchitecture.Events
{
    public class ColorEventListener : EventListener<Color>
    {
        #region Private Fields

        [SerializeField] private ColorEvent _event;
        [SerializeField] private UnityEvent<Color> _unityEvent = new UnityEvent<Color>();
        
        #endregion

        #region EventListener Implementation

        public override UnityEvent<Color> UnityEvent => _unityEvent;
        public override GameEvent<Color> GameEvent
        {
            get => _event;
            set
            {
                if (_event != null)
                {
                    _event.RemoveListener(this);
                }
            
                _event = value as ColorEvent;
            
                if (_event != null)
                {
                    _event.AddListener(this);
                }
            }
        }

        #endregion
    }
}