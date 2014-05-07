using UnityEngine;
using System.Collections;

public class BoxOne : MonoBehaviour {

	public int health = 1;

	void OnCollisionEnter(Collision coll)
	{
		health--;
		if (health == 0) 
		{
			Destroy (gameObject);
		}
	}

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
