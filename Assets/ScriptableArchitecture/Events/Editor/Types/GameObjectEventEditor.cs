using UnityEditor;
using UnityEngine;

namespace Ninito.ScriptableArchitecture.Events
{
    #if UNITY_EDITOR
    [CustomEditor(typeof(GameObjectEvent))]
    public class GameObjectEventEditor : GameEventEditor<GameObject>
    {
        
    }
    #endif
}