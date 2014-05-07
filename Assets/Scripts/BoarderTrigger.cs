using UnityEngine;
using System.Collections;

public class BoarderTrigger : MonoBehaviour {

	public GameObject ball_pref;

	void OnCollisionEnter(Collision col)
	{

		//only for randomisation
		float posxvalue;
		float posyvalue;
		float poszvalue;
		float posx;
		float posy;
		float posz;
		float negpos;
		int nepo;

		negpos = Random.value;

		if (negpos <= 0.5f) {
						nepo = -1;
				} else
						nepo = 1;

		posxvalue = Random.value;
		posyvalue = Random.value;
		poszvalue = Random.value;

		posx = nepo * posxvalue * 4;
		posy = nepo * posyvalue * 4;
		posz = nepo * poszvalue * 4;
		//yup

		BallMovement ball;
		ball = col.gameObject.GetComponent<BallMovement> ();
		if (ball != null) 
		{
			ball.Dying();
		}
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
