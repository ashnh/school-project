using UnityEngine;
using System.Collections;

public class LastP : MonoBehaviour {

	public LastLevel handler;

	public GameObject player;

	void OnTriggerEnter2D () {
		handler.toEnd--;
		Destroy (gameObject);
	}

	//bool checkIfIn () {
	//	if (transform.position.x < player.transform.position.x + 1 && transform.position.x > player.transform.position.x - 1) {
	//		if (transform.position.y < player.transform.position.y + 3 && transform.position.y > player.transform.position.y - 3) {
	//			return true;
	//		}
	//	}
		//return false;
	//}

	//void  () {
		//handler.toEnd--;
		//Destroy (gameObject);
	//}

	void Update () {
		GetComponent <Rigidbody2D> ().velocity = new Vector2 (GetComponent <Rigidbody2D> ().velocity.x, -10);
	}

}
