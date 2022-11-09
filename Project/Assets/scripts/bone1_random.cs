using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bone1_random : MonoBehaviour
{
    int random_int = 0;

    public GameObject bone1, bone2, bone3, bone4;

    
   
    // Start is called before the first frame update
    void Start()
    {
        random_int = Random.Range(0, 4);

        if (random_int == 1)
        {
            bone1.SetActive(true);
            bone1.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            bone1.SetActive(false);
            bone1.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (random_int == 2)
        {
            bone2.SetActive(true);
            bone2.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            bone2.SetActive(false);
            bone2.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (random_int == 3)
        {
            bone3.SetActive(true);
            bone3.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            bone3.SetActive(false);
            bone3.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (random_int == 0)
        {
            bone4.SetActive(true);
            bone4.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            bone4.SetActive(false);
            bone4.GetComponent<SpriteRenderer>().enabled = false;
        }

    }

    // Update is called once per frame
    void Update()
    { 
    }
}
