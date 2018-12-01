using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontrolBola : MonoBehaviour {
	Rigidbody body;
	public float forcemagnitude;
	// Use this for initialization
	void Start () {
		body = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0)) {
			body.AddForce (new Vector3(0,1f,1f) * forcemagnitude);
		}
	}
}
