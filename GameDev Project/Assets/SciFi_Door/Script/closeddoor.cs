using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeddoor : MonoBehaviour
{
    private bool once = true;

    [SerializeField] private GameObject indicator1;

    void OnTriggerEnter(Collider obj)
    {
        if (once)
        {

            once = false;
            
            Destroy(indicator1);
        }
    }
}
