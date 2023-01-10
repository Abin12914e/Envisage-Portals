using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerdamage : MonoBehaviour
{
    public int currenthealth;
    public Transform player;
    public Transform enemy;
    public healthbar healthbar;
    public float cooldown;

    // Start is called before the first frame update
    void Start()
    {
        currenthealth = 100;
        healthbar.setmaxhealth(100);
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }

        float distance = Vector3.Distance(player.transform.position, enemy.transform.position);
        if (cooldown <= 0)
        {
            cooldown= 0.1f;
            if (distance < 3)
            {
                takedamage(1);

            }
        }
    }

    void takedamage(int amount)
    {
        currenthealth -= amount;
        healthbar.sethealth(currenthealth);
    }    
}
