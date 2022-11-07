using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collect : MonoBehaviour
{
    public GameObject bone1, bone2, bone3, bone4, bone5;
    // Start is called before the first frame update
    void Start()
    {
        bone1.SetActive(false);
        bone2.SetActive(false);
        bone3.SetActive(false);
        bone4.SetActive(false);
        bone5.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("bone1"))
        {
            print("bone1");
            Destroy(collision.gameObject);
            bone1.SetActive(true);
        }
        if (collision.gameObject.CompareTag("bone2"))
        {
            Destroy(collision.gameObject);
            print("bone1");
            bone2.SetActive(true);
        }
        if (collision.gameObject.CompareTag("bone3"))
        {

            Destroy(collision.gameObject);
            print("bone1");
            bone3.SetActive(true);
        }
        if (collision.gameObject.CompareTag("bone4"))
        {
            Destroy(collision.gameObject);
            print("bone1");
            bone4.SetActive(true);
        }
        if (collision.gameObject.CompareTag("bone5"))
        {
            Destroy(collision.gameObject);
            print("bone1");
            bone5.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
