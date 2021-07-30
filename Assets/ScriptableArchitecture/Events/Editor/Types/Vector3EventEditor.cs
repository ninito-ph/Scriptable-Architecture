using UnityEditor;
using UnityEngine;

namespace Ninito.ScriptableArchitecture.Events
{
    #if UNITY_EDITOR
    [CustomEditor(typeof(Vector3Event))]
    public class Vector3EventEditor : GameEventEditor<Vector3>
    {
        
    }
    #endif
}