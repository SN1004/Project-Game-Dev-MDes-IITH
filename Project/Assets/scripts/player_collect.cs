using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("bone1"))
        {
            print("bone1");
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("bone2"))
        {
            Destroy(collision.gameObject);
            print("bone1");
        }
        if (collision.gameObject.CompareTag("bone3"))
        {
            Destroy(collision.gameObject);
            print("bone1");
        }
        if (collision.gameObject.CompareTag("bone4"))
        {
            Destroy(collision.gameObject);
            print("bone1");
        }
        if (collision.gameObject.CompareTag("bone5"))
        {
            Destroy(collision.gameObject);
            print("bone1");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
