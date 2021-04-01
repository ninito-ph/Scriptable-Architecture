using UnityEngine;

namespace ScriptableArchitecture.Variables
{
    [System.Serializable]
    public class AudioClipReference : Reference<AudioClip, AudioClipVariable>
    {
        public AudioClipReference(AudioClip value) : base(value)
        {
        }
    }
}