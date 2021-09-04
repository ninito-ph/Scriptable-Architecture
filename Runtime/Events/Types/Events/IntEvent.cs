using UnityEngine;

namespace Ninito.ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateAssetMenus.IntEventFilename, menuName = CreateAssetMenus.IntEventMenu,
        order = CreateAssetMenus.IntEventOrder)]
    public class IntEvent : GameEvent<int>
    {
        
    }
}