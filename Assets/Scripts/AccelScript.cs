using UnityEngine;
using System.Collections;

public class AccelScript : MonoBehaviour {


	
	// Update is called once per frame
	void FixedUpdate () {
	
		transform.Translate (Input.acceleration.x * 10 * Time.deltaTime, 0,
		                    Input.acceleration.y * Time.deltaTime);
	}
}
