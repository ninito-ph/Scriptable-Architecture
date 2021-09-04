using UnityEngine;

namespace Ninito.ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateAssetMenus.AudioClipEventFileName, menuName = CreateAssetMenus.AudioClipEventMenu,
        order = CreateAssetMenus.AudioClipEventOrder)]
    public class AudioClipEvent : GameEvent<AudioClip>
    {
        
    }
}