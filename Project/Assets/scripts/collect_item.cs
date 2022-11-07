using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect_item : MonoBehaviour
{
    public GameObject bone;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            bone.SetActive(false);
        }
    }
}
