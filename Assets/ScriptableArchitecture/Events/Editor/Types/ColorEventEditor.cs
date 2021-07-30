using UnityEditor;
using UnityEngine;

namespace Ninito.ScriptableArchitecture.Events
{
    #if UNITY_EDITOR
    [CustomEditor(typeof(ColorEvent))]
    public class ColorEventEditor : GameEventEditor<Color>
    {
        
    }
    #endif
}