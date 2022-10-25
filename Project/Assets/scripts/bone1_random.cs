using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Sprites;

public class bone1_random : MonoBehaviour
{
    int random_int = 0;

    public GameObject bone1, bone2, bone3, bone4;

    
   
    // Start is called before the first frame update
    void Start()
    {
        random_int = Random.Range(0, 5);
        
        if(random_int==1)
        {
            bone1.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            bone1.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (random_int == 2)
        {
            bone2.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            bone2.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (random_int == 3)
        {
            bone3.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            bone3.GetComponent<SpriteRenderer>().enabled = false;
        }

        if (random_int == 4)
        {
            bone4.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            bone4.GetComponent<SpriteRenderer>().enabled = false;
        }

    }

    // Update is called once per frame
    void Update()
    { 
    }
}
