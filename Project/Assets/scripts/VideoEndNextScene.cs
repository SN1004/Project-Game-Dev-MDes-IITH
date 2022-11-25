using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoEndNextScene : MonoBehaviour
{
    [SerializeField] private VideoPlayer Video;
    [SerializeField] private string NextScene;
    [SerializeField] private double time;
    [SerializeField] private double currentTime;
    // Use this for initialization
    void Start()
    {
        time = gameObject.GetComponent<VideoPlayer>().clip.length;
    }


    // Update is called once per frame
    void Update()
    {
        currentTime = gameObject.GetComponent<VideoPlayer>().time;
        if (currentTime >= time-0.1f)
        {
            Video.gameObject.SetActive(false);
            SceneManager.LoadScene(NextScene);
        }
    }
}
