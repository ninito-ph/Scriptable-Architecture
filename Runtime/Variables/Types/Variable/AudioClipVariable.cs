using UnityEngine;

namespace Ninito.ScriptableArchitecture.Variables
{
    [CreateAssetMenu(fileName = CreateAssetMenus.AudioClipVariableFileName, 
        menuName = CreateAssetMenus.AudioClipVariableMenu, order = CreateAssetMenus.AudioClipVariableOrder)]
    public class AudioClipVariable : Variable<AudioClip>
    {
    }
}