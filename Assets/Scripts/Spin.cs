using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour
{
	public float speed = 5f;
	
	
	void Update ()
	{
		transform.Translate(Vector2.up * speed * Time.deltaTime);
	}
}