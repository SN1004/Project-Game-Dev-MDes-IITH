using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public  Rigidbody2D rd;

    public float move_speed = 5f;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        rd.MovePosition(rd.position + movement * move_speed * Time.fixedDeltaTime);
        
    }
}
