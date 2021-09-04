using UnityEngine;

namespace Ninito.ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateAssetMenus.StringEventFilename, menuName = CreateAssetMenus.StringEventMenu,
        order = CreateAssetMenus.StringEventOrder)]
    public class StringEvent : GameEvent<string>
    {
        
    }
}