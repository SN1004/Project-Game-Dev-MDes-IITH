using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMove : MonoBehaviour
{

    [SerializeField] private Transform emptySpace = null;
    [SerializeField] private int dist = 20;
    [SerializeField] Transform[] CurrentTilePos;
    [SerializeField] private int Num_Swaps = 21;
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

    private void Swap(Transform p1, Transform p2)
    {
        Vector2 posp1 = p1.position;
        Vector2 posp2 = p2.position;
        p1.position = posp2;
        p2.position = posp1;
    }

    public void Play()
    {
        //randomize tiles
        int n = Random.Range(0, Num_Swaps);
        for(int i = 0; i < n; i++)
        {
            Transform p1 = CurrentTilePos[Random.Range(0, 9)];
            Transform p2 = CurrentTilePos[Random.Range(0, 9)];
            Swap(p1,p2);
        }
    }
}
