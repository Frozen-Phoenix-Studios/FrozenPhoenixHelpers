using System;
using UnityEngine;

namespace FrozenPhoenixStudios.Audio
{
    [Serializable]
    public class AudioData
    {
        public AudioType AudioType;
        public AudioClip ClipToPlay;
        public Vector2 RandomPitchRange;
        public bool HasRandomPitch => RandomPitchRange != Vector2.zero;

        public AudioData(AudioType audioType, AudioClip clipToPlay, Vector2 randomPitchRange = default)
        {
            AudioType = audioType;
            ClipToPlay = clipToPlay;
            RandomPitchRange = randomPitchRange;
        }
    }
}