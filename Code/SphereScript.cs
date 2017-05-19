using UnityEngine;
using System.Collections;

public class SphereScript : MonoBehaviour {

	public shootyBois handler;

	void OnTriggerEnter2D () {
		handler.reduce ();
		Destroy (gameObject);
	}
}
