using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public  Rigidbody rd;

    public float move_speed = 5f;
    public float MoveZ = 1.0f; 

    [SerializeField] private Vector3 movement;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("horizontal", movement.x);
        animator.SetFloat("vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);

    }

    private void FixedUpdate()
    {
        if(movement.x != 0 &&  movement.y != 0)
        {
            movement.z += MoveZ;
            rd.MovePosition(rd.position + movement * move_speed * Time.fixedDeltaTime);
        }
    }
}
