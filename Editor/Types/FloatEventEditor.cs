using UnityEditor;

namespace Ninito.ScriptableArchitecture.Events
{
    #if UNITY_EDITOR
    [CustomEditor(typeof(FloatEvent))]
    public class FloatEventEditor : GameEventEditor<float>
    {
        
    }
    #endif
}