using UnityEngine;
using System.Collections;

public class SediSphere : MonoBehaviour {

	public shootyBois handler;

	public GameObject bar;

	void OnTriggerEnter2D () {
		handler.reduce ();
		bar.SetActive (true);
		Destroy (gameObject);
	}
}
