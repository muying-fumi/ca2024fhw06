using UnityEngine;
using UnityEngine.Video;
public class Video : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public AudioSource audioSource;
    private void Awake()
    {
        videoPlayer.Play();
        audioSource.Play();
    }
}

