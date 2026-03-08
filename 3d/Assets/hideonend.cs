using UnityEngine;
using UnityEngine.Video;

public class HideOnVideoEnd : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    void Start()
    {
        // Get the VideoPlayer component on this GameObject
        videoPlayer = GetComponent<VideoPlayer>();

        if (videoPlayer != null)
        {
            // Subscribe to the loopPointReached event
            videoPlayer.loopPointReached += OnVideoEnd;
        }
        else
        {
            Debug.LogError("No VideoPlayer component found on this GameObject!");
        }
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // Disable the GameObject (make it disappear)
        gameObject.SetActive(false);
    }

    void OnDestroy()
    {
        // Unsubscribe from the event to avoid errors
        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached -= OnVideoEnd;
        }
    }
}
