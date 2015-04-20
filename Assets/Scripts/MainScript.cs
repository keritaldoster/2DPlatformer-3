using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {

	public GameObject platform;


	// Use this for initialization
	void Start ()
	{
		InvokeRepeating ("SpawnPlatform", 1, 2);
		InvokeRepeating ("SpawnPlatform2", 2, 2);
	}

	
	void SpawnPlatform()
	{
		
		float x = Random.Range(0f, -5.0f);
		Instantiate(platform, new Vector3(x, -9, 0), Quaternion.identity);

		
	}

	void SpawnPlatform2()
	{
		
		float x = Random.Range(0f, 5.0f);
		Instantiate(platform, new Vector3(x, -9, 0), Quaternion.identity);
		
		
	}

	// Update is called once per frame
	void Update () {
	

	}
}
