using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	public Transform ammo;
	public GameObject pointLight;
	public int speedAmmo = 1500;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.G)){  
			Transform g = (Transform)Instantiate (ammo, transform.position, transform.rotation);
			g.GetComponent<Rigidbody>().AddForce (transform.forward * speedAmmo);
			pointLight.GetComponent<Light> ().enabled = true;
            Destroy(ammo, 1);
        }

		if(Input.GetKeyUp(KeyCode.G)){  
			pointLight.GetComponent<Light> ().enabled = false;

	}
		
	}
}

















