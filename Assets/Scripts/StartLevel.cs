using UnityEngine;
using System.Collections;

public class StartLevel : MonoBehaviour {

	public void Test()
	{
		Debug.Log("Button was pressed");

		Application.LoadLevel("FinalGame");
	}
}
