using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovements : MonoBehaviour
{
    public CharacterController contrlr;
    public float speed = 12f;
    public float gravity = 10f;

    public Transform groundcheck;
    public float grounddistance = 0.1f;
    public LayerMask groundmask;

    Vector3 velocity;
    bool isgrounded;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        isgrounded = Physics.CheckSphere(groundcheck.position, grounddistance, groundmask);

        if (isgrounded && velocity.y < 0)
        {
            velocity.y = -0.5f;
        }

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * y;
        contrlr.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isgrounded)
        {
            velocity.y += 1.5f;
        }

        velocity.y -= gravity * Time.deltaTime*0.8f;
        contrlr.Move(velocity * speed * Time.deltaTime);



    }
}
