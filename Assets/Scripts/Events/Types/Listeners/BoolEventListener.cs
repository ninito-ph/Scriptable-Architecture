using UnityEngine;
using UnityEngine.Events;

namespace ScriptableArchitecture.Events
{
    public class BoolEventListener : EventListener<bool>
    {
        #region Private Fields

        [SerializeField] private BoolEvent _event;
        [SerializeField] private UnityEvent<bool> _unityEvent;
        
        #endregion

        #region EventListener Implementation

        public override UnityEvent<bool> UnityEvent => _unityEvent;
        public override Event<bool> Event => _event;

        #endregion
    }
}