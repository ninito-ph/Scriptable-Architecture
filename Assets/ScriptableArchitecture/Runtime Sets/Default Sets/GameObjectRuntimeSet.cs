using UnityEngine;

namespace Ninito.ScriptableArchitecture.RuntimeSets
{
    /// <summary>
    ///     A runtime set for GameObjects
    /// </summary>
    [CreateAssetMenu(fileName = CreateAssetMenus.GameObjectRuntimeSetFileName,
        menuName = CreateAssetMenus.GameObjectRuntimeSetMenuName,
        order = CreateAssetMenus.GameObjectRuntimeSetOrder)]
    public class GameObjectRuntimeSet : RuntimeSet<GameObject>
    {
    }
}