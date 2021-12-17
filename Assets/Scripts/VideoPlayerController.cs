using UnityEngine;
using UnityEngine.Video;

namespace ARVideoPlayer
{
    public class VideoPlayerController : MonoBehaviour
    {
        [SerializeField] private VideoClip[] _clipsArray;
        [SerializeField] private VideoPlayer _videoPlayer;
        private int _currentVideoClipIndex;

        private void Start()
        {
            _videoPlayer.clip = _clipsArray[0];
            _videoPlayer.Play();
        }

        public void PlayVideo()
        {
            _videoPlayer.Play();
        }

        public void StopVideo()
        {
            _videoPlayer.Pause();
        }

        public void PlayPause()
        {
            if (_videoPlayer.isPlaying)
                _videoPlayer.Pause();
            else
                _videoPlayer.Play();
        }

        public void PlayNext()
        {
            _currentVideoClipIndex++;

            if (_currentVideoClipIndex >= _clipsArray.Length)
                _currentVideoClipIndex %= _clipsArray.Length;

            _videoPlayer.clip = _clipsArray[_currentVideoClipIndex];
            _videoPlayer.Play();
        }

        public void PlayPrevious()
        {
            _currentVideoClipIndex--;

            if (_currentVideoClipIndex < 0)
                _currentVideoClipIndex = _clipsArray.Length - 1;

            _videoPlayer.clip = _clipsArray[_currentVideoClipIndex];
            _videoPlayer.Play();
        }
    }
}
