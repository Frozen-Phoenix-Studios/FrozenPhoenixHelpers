using System;
using UnityEngine;

namespace FrozenPhoenix.Audio
{
    [Serializable]
    public class AudioData
    {
        public SoundCategory SoundCategory;
        public AudioClip ClipToPlay;
        public Vector2 RandomPitchRange;
        public bool HasRandomPitch => RandomPitchRange != Vector2.zero;

        public AudioData(SoundCategory category, AudioClip clipToPlay, Vector2 randomPitchRange = default)
        {
            SoundCategory = category;
            ClipToPlay = clipToPlay;
            RandomPitchRange = randomPitchRange;
        }
    }
}