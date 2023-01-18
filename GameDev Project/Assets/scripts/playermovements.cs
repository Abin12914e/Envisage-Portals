using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class playermovements : MonoBehaviour
{
    public CharacterController contrlr;
    public float speed = 12f;
    public float gravity = 10f;

    public Transform groundcheck;
    public float grounddistance = 0.1f;
    public LayerMask groundmask;
    public static int keys = 0;
    public string ini = "KEYS - ";
    public string fin = "/36";

    public float timer=3f;
    public bool sou=true;

    public Text score;

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
        if (Input.GetKey(KeyCode.W ) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            timer += Time.deltaTime;
            if (timer > 0.4f && sou)
            {

                FindObjectOfType<audiomanager>().play("walka1");
                FindObjectOfType<audiomanager>().play("walka2");
                FindObjectOfType<audiomanager>().play("walka3");
                FindObjectOfType<audiomanager>().play("walka4");
                FindObjectOfType<audiomanager>().play("walka5");
                FindObjectOfType<audiomanager>().play("walka6");
                sou = false;
                
            }
            if (timer > 0.8f)
            {

                FindObjectOfType<audiomanager>().play("walk1");
                FindObjectOfType<audiomanager>().play("walk2");
                FindObjectOfType<audiomanager>().play("walk3");
                FindObjectOfType<audiomanager>().play("walk4");
                FindObjectOfType<audiomanager>().play("walk5");
                FindObjectOfType<audiomanager>().play("walk6");

                sou = true;
                timer= 0;
            }
        }


            if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 18f;
        }
        else
        {
            speed = 12f;
        }

            


        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            FindObjectOfType<audiomanager>().play("obtain");
            Destroy(other.gameObject);
            keys += 1;
            
            score.text = ini + keys.ToString() + fin;
        }
    }
}
