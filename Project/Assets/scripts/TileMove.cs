using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMove : MonoBehaviour
{
    [SerializeField] private Transform emptySpace = null;
    [SerializeField] private int dist = 20;
    private Camera Maincamera;
    private void Start()
    {
        Maincamera = Camera.main;
        
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Maincamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D Hit = Physics2D.Raycast(ray.origin, ray.direction);
            if (Hit)
            {
                if(Vector2.Distance(emptySpace.position, Hit.transform.position) < dist)
                {
                    Vector2 EmptySpacePosition = emptySpace.position;
                    emptySpace.position = Hit.transform.position;
                    Hit.transform.position = EmptySpacePosition;
                }
            }
        }
    }
}
