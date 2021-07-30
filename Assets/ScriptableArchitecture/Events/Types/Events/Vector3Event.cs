using UnityEngine;

namespace Ninito.ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateAssetMenus.Vector3EventFilename, menuName = CreateAssetMenus.Vector3EventMenu,
        order = CreateAssetMenus.Vector3EventOrder)]
    public class Vector3Event : GameEvent<Vector3>
    {
        
    }
}