using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_clamp : MonoBehaviour
{
    [SerializeField] private Transform targetToFollow;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(targetToFollow.position.x,-30f,30f),
            Mathf.Clamp(targetToFollow.position.y, -35f,26f),
            transform.position.z);
            
    }
}
