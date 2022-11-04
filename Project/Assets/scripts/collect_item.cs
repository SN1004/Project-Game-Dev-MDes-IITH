using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect_item : MonoBehaviour
{
    
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (CompareTag("player")) { }
    }
}
