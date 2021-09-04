using UnityEditor;
using UnityEngine;

namespace Ninito.ScriptableArchitecture.Events
{
    #if UNITY_EDITOR
    [CustomEditor(typeof(Vector4Event))]
    public class Vector4EventEditor : GameEventEditor<Vector4>
    {
        
    }
    #endif
}