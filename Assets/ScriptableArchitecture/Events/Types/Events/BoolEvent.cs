using UnityEngine;

namespace Ninito.ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateAssetMenus.BoolEventFilename, menuName = CreateAssetMenus.BoolEventMenu,
        order = CreateAssetMenus.BoolEventOrder)]
    public class BoolEvent : GameEvent<bool>
    {
    }
}