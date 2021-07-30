using UnityEngine;

namespace Ninito.ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateAssetMenus.Vector4EventFilename, menuName = CreateAssetMenus.Vector4EventMenu,
        order = CreateAssetMenus.Vector4EventOrder)]
    public class Vector4Event : GameEvent<Vector4>
    {
        
    }
}