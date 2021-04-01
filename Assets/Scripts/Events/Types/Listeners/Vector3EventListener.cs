using UnityEngine;
using UnityEngine.Events;

namespace ScriptableArchitecture.Events
{
    public class Vector3EventListener : EventListener<Vector3>
    {
        #region Private Fields

        [SerializeField] private Vector3Event _event;
        [SerializeField] private UnityEvent<Vector3> _unityEvent;
        
        #endregion

        #region EventListener Implementation

        public override UnityEvent<Vector3> UnityEvent => _unityEvent;
        public override Event<Vector3> Event => _event;

        #endregion
    }
}