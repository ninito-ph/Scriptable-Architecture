using UnityEditor;

namespace Ninito.ScriptableArchitecture.Events
{
    #if UNITY_EDITOR
    [CustomEditor(typeof(BoolEvent))]
    public class BoolEventEditor : GameEventEditor<bool>
    {
        
    }
    #endif
}