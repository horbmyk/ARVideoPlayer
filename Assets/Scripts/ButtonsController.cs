using UnityEngine;

namespace ARVideoPlayer
{
    public class ButtonsController : MonoBehaviour
    {
        [SerializeField] private VideoPlayerController _videoPlayerController;

        public void QuitApplication()
        {
            Application.Quit();
        }

        public void PlayPauseVideo()
        {
            _videoPlayerController.PlayPause();
        }

        public void PlayNextVideo()
        {
            _videoPlayerController.PlayNext();
        }

        public void PlayPreviousVideo()
        {
            _videoPlayerController.PlayPrevious();
        }
    }
}
