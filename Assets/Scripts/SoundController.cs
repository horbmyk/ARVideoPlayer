using UnityEngine;

namespace ARVideoPlayer
{
    public class SoundController : MonoBehaviour
    {
        [SerializeField] private AudioSource _backgroundSound;

        public void PlaySound()
        {
            _backgroundSound.Play();
        }

        public void StopSound()
        {
            _backgroundSound.Stop();
        }
    }
}

