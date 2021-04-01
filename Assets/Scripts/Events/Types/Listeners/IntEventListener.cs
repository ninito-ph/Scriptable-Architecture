using UnityEngine;
using UnityEngine.Events;

namespace ScriptableArchitecture.Events
{
    public class IntEventListener : EventListener<int>
    {
        #region Private Fields

        [SerializeField] private IntEvent _event;
        [SerializeField] private UnityEvent<int> _unityEvent;
        
        #endregion

        #region EventListener Implementation

        public override UnityEvent<int> UnityEvent => _unityEvent;
        public override Event<int> Event => _event;

        #endregion
    }
}
