using UnityEngine;

namespace Ninito.ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateAssetMenus.FloatEventFilename, menuName = CreateAssetMenus.FloatEventMenu,
        order = CreateAssetMenus.FloatEventOrder)]
    public class FloatEvent : GameEvent<float>
    {
        
    }
}