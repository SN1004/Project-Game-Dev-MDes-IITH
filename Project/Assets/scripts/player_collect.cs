using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class player_collect : MonoBehaviour
{
    public GameObject bone1, bone2, bone3, bone4, bone5;
    public int no_collected = 0;
    public bool collection_completed = false;
    public TextMeshProUGUI tm;
    public float timer = 0;
    public int total_time = 0;
    public bool Win = false;
    public GameObject LoadingCanvas;
    // Start is called before the first frame update
    void Start()
    {
        bone1.SetActive(false);
        bone2.SetActive(false);
        bone3.SetActive(false);
        bone4.SetActive(false);
        bone5.SetActive(false);
        LoadingCanvas.SetActive(false);
    }

    private void OnTriggerEnter(Collider collision)
    {        
        if(collision.gameObject.CompareTag("bone1"))
        {
            Destroy(collision.gameObject);
            bone1.SetActive(true);
            no_collected++;
        }
        if (collision.gameObject.CompareTag("bone2"))
        {
            Destroy(collision.gameObject);
            bone2.SetActive(true);
            no_collected++;
        }
        if (collision.gameObject.CompareTag("bone3"))
        {

            Destroy(collision.gameObject);
            bone3.SetActive(true);
            no_collected++;
        }
        if (collision.gameObject.CompareTag("bone4"))
        {
            Destroy(collision.gameObject);
            bone4.SetActive(true);
            no_collected++;
        }
        if (collision.gameObject.CompareTag("bone5"))
        {
            Destroy(collision.gameObject);
            bone5.SetActive(true);
            no_collected++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (no_collected == 5 || Win)
        {
            collection_completed = true;
            total_time = (int)timer;
            LoadingCanvas.SetActive(true);
            StartCoroutine(Wait());
        }
        else
        {
            timer += Time.deltaTime;
            tm.text = (int)timer + "s";
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        EventManager.LoadLevel2();
    }
}
