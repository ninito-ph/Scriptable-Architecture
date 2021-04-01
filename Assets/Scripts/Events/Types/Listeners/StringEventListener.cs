using UnityEngine;
using UnityEngine.Events;

namespace ScriptableArchitecture.Events
{
    public class StringEventListener : EventListener<string>
    {
        #region Private Fields

        [SerializeField] private StringEvent _event;
        [SerializeField] private UnityEvent<string> _unityEvent;
        
        #endregion

        #region EventListener Implementation

        public override UnityEvent<string> UnityEvent => _unityEvent;
        public override Event<string> Event => _event;

        #endregion
    }
}