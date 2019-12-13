using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    VideoPlayer videoPlayer;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log((ulong)videoPlayer.frame + " " + videoPlayer.frameCount);
        if ((ulong)videoPlayer.frame + 1 == videoPlayer.frameCount)
        {
            SceneManager.LoadScene("Opening");
        }
    }
}
