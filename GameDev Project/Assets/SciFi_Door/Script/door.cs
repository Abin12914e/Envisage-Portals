using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
	GameObject thedoor;
	private bool once = true;
    [SerializeField] private GameObject thedoor1;

    [SerializeField] private GameObject indicator1;

    void OnTriggerEnter ( Collider obj  ){
        if (once)
        {
            
            thedoor1.GetComponent<Animation>().Play("open");
            once= false;
            FindObjectOfType<audiomanager>().play("door");

            Destroy(indicator1);
        }
}


}