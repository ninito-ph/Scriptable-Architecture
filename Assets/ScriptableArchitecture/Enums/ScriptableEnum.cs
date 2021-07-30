using UnityEngine;

namespace Ninito.ScriptableArchitecture.ScriptableArchitecture
{
    /// <summary>
    ///     A designer-friendly, empty scriptable object class meant to replace outward-facing enums
    /// </summary>
    [CreateAssetMenu(order = CreateAssetMenus.ScriptableEnumOrder, fileName = CreateAssetMenus.ScriptableEnumFileName,
        menuName = CreateAssetMenus.ScriptableEnumMenuName)]
    public class ScriptableEnum : ScriptableObject
    {
        [SerializeField, TextArea]
        private string description;

        #region Properties

        public string Description => description;

        #endregion
    }
}