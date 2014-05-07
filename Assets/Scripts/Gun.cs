using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public int mouseSensivity;

	// Use this for initialization
	void Start () 
	{
		Screen.lockCursor = true;
	}
	
	// Update is called once per frame
	void Update () 
	{

		//Rotation
		//float maxRot = 60f;
		float rotLeftRight = 0f;
		float rotUpDown = 0f;

		rotLeftRight = Input.GetAxis ("Mouse X") * mouseSensivity;
	    rotUpDown = Input.GetAxis ("Mouse Y") * mouseSensivity;

		transform.Rotate(0, 0, rotLeftRight);
		transform.Rotate (rotUpDown, 0, 0);


	}
}
