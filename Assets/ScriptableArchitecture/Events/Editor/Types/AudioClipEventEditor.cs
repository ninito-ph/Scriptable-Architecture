using UnityEditor;
using UnityEngine;

namespace Ninito.ScriptableArchitecture.Events
{
    #if UNITY_EDITOR
    [CustomEditor(typeof(AudioClipEvent))]
    public class AudioClipEventEditor : GameEventEditor<AudioClip>
    {
        
    }
    #endif
}