using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Vector3 Max = Vector3.zero;
    [SerializeField] Vector3 Min = Vector3.zero;

    void Start()
    {
         transform.GetComponent<Camera>().ResetAspect();
    }

    void FixedUpdate()
    {
        Vector3 CamPos = this.transform.position;
        if (this.transform.position.x > Max.x)
        {
            CamPos.x = Max.x;
        }
        if (this.transform.position.y > Max.y)
        {
            CamPos.y = Max.y;
        }
        /*if (this.transform.position.z > Max.z)
        {
            CamPos.z = Max.z;
        }*/
        if (this.transform.position.x < Min.x)
        {
            CamPos.x = Min.x;
        }
        if (this.transform.position.y < Min.y)
        {
            CamPos.y = Min.y;
        }
        /*if (this.transform.position.z < Min.z)
        {
            CamPos.z = Min.z;
        }*/
        this.transform.position = CamPos;
    }
}
