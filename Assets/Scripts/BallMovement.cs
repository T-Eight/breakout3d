using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

	public int ballspeed = 10;
	public GameObject spawn;
	public static bool ballig = false;
	//public GameObject ball_prefab;



	public void Dying()
	{
		Destroy (this.gameObject);
		ballig = false;
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown ("Fire1") && ballig == false) 
		{
			GameObject ball = (GameObject)Instantiate(gameObject, spawn.transform.position, spawn.transform.rotation);
			ball.name = "newBall";
			ball.rigidbody.AddRelativeForce(transform.forward * ballspeed, ForceMode.Impulse);
			ballig = true;
		}
	}
}
