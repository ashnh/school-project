using UnityEngine;
using System.Collections;

public class LastLevel : MonoBehaviour {

	public AudioSource jhon;

	public GameObject player;

	public GameObject ui;
	public GameObject end;

	public float speed;

	public int toEnd;

	float rotation;

	public GameObject P;

	float y;

	public void startGame () {
		Time.timeScale = 1;
		ui.transform.localScale = new Vector3 (0, 1, 1);
	}

	void endGame () {
		end.transform.localScale = new Vector3 (1, 1, 1);
		jhon.Play ();
	}

	// Use this for initialization
	void Start () {
		y = 0;
		rotation = 0F;
		ui.transform.localScale = new Vector3 (1, 1, 1);
		Time.timeScale = 0;
	}


	
	// Update is called once per frame
	void Update () {
		y++;
		
		if (Input.GetKey (KeyCode.LeftArrow)) {
			player.transform.Rotate (0, 0, rotation + 4F);
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			player.transform.Rotate (0, 0, rotation - 4F);
		}
			
		if (Input.GetKey (KeyCode.W)) {
			//player.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y + speed, -9);
			player.GetComponent <Rigidbody2D> ().velocity = new Vector2 (player.GetComponent <Rigidbody2D> ().velocity.x, speed);
		} else if (Input.GetKey (KeyCode.S)) {
			//player.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y - speed, -9);
			player.GetComponent <Rigidbody2D> ().velocity = new Vector2 (player.GetComponent <Rigidbody2D> ().velocity.x, -speed);
		} else {
			player.GetComponent <Rigidbody2D> ().velocity = new Vector2 (player.GetComponent <Rigidbody2D> ().velocity.x, 0);
		}

		if (Input.GetKey (KeyCode.A)) {
			//player.transform.position = new Vector3 (player.transform.position.x - speed, player.transform.position.y, -9);
			player.GetComponent <Rigidbody2D> ().velocity = new Vector2 (-speed, player.GetComponent <Rigidbody2D> ().velocity.y);
		} else if (Input.GetKey (KeyCode.D)) {
			//player.transform.position = new Vector3 (player.transform.position.x + speed, player.transform.position.y, -9);
			player.GetComponent <Rigidbody2D> ().velocity = new Vector2 (speed, player.GetComponent <Rigidbody2D> ().velocity.y);
		} else {
			player.GetComponent <Rigidbody2D> ().velocity = new Vector2 (0, player.GetComponent <Rigidbody2D> ().velocity.y);
		}
		float z = 0;
		if (Random.value < .5) {
			z = -1;
		} else {
			z = 1;
		}
		if (y % 10 == 0 && Time.timeScale != 0 && !(toEnd <= 0)) {
			GameObject x = (GameObject)Instantiate (P, new Vector3 ((Random.value * 20) * z, 15, -9), P.transform.localRotation);
		}

		if (toEnd <= 0) {
			endGame ();
		}
	}
}
