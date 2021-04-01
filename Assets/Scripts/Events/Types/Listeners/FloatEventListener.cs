using UnityEngine;
using UnityEngine.Events;

namespace ScriptableArchitecture.Events
{
    public class FloatEventListener : EventListener<float>
    {
        #region Private Fields

        [SerializeField] private FloatEvent _event;
        [SerializeField] private UnityEvent<float> _unityEvent;
        
        #endregion

        #region EventListener Implementation

        public override UnityEvent<float> UnityEvent => _unityEvent;
        public override Event<float> Event => _event;

        #endregion
    }
}