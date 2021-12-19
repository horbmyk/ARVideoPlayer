using UnityEngine;

namespace ARVideoPlayer
{
    public class SoundController : MonoBehaviour
    {
        [SerializeField] private AudioSource _backGroundSound;

        public void PlaySound()
        {
            _backGroundSound.Play();
        }

        public void StopSound()
        {
            _backGroundSound.Stop();
        }
    }
}

