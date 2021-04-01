using UnityEngine;

namespace ScriptableArchitecture.Events
{
    [CreateAssetMenu(fileName = CreateMenus.AudioClipEventFileName, menuName = CreateMenus.AudioClipEventMenu,
        order = CreateMenus.AudioClipEventOrder)]
    public class AudioClipEvent : Event<AudioClip>
    {
        
    }
}