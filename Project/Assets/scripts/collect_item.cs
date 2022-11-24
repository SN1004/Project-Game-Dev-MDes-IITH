using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect_item : MonoBehaviour
{
    public GameObject bone;

    private void Start()
    {
        bone = this.gameObject;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            bone.SetActive(false);
        }
    }
}
