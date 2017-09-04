using System.Collections;
using UnityEngine;

public class RotateLimit : MonoBehaviour {

	public float rotateLimitXpos;
	public float rotateLimitZpos;
	public float rotateLimitXneg;
	public float rotateLimitZneg;
	//GameObject boat;

	// Use this for initialization
	void Start () {
		rotateLimitXpos = 2f;
		rotateLimitZpos = 10f;
		rotateLimitXneg = -2f;
		rotateLimitZneg = -10f;
	}
	
	// Update is called once per frame
	void Update () {
		
		float xRotation = transform.eulerAngles.x;
		float zRotation = transform.eulerAngles.z;

//		transform.Rotate (new Vector3 ( transform.eulerAngles.x,  transform.eulerAngles.y, rotateLimitZpos++));


	if ( transform.eulerAngles.x > rotateLimitXpos ){
		
		transform.Rotate (new Vector3 ( rotateLimitXpos, transform.eulerAngles.y,  transform.eulerAngles.z));
	}
			
	if ( transform.eulerAngles.z > rotateLimitZpos ){
		
		transform.Rotate (new Vector3 ( transform.eulerAngles.x,  transform.eulerAngles.y, rotateLimitZpos));
	}

	if ( xRotation < rotateLimitXneg ){
		
		transform.Rotate (new Vector3 ( rotateLimitXneg, transform.eulerAngles.y,  transform.eulerAngles.z));
	}

	if (transform.eulerAngles.z < rotateLimitZneg) {
		
		transform.Rotate (new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y, rotateLimitZneg));
	}
	
	}
}
