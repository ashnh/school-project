using UnityEngine;
using System.Collections;

public class shootyBois : MonoBehaviour {

	public GameObject player;

	public GameObject spheres;

	public GameObject bullet;

	public float bulletSpeed;

	// "My name is Jeff" - Cara

	public float playerSpeed;

	public float leftConstraint;
	public float rightConstraint;

	public GameObject ui;

	int toGo;

	public void reduce () {
		toGo--;
	}

	// Use this for initialization
	void Start () {
		player.GetComponent <Rigidbody2D> ().velocity = new Vector2 (playerSpeed, 0);
		toGo = 5;
	}
	
	// Update is called once per frame
	void Update () {
		if (player.transform.position.x >= rightConstraint) {
			player.GetComponent <Rigidbody2D> ().velocity = new Vector2 (-playerSpeed, 0);
		} else if(player.transform.position.x <= leftConstraint) {
			player.GetComponent <Rigidbody2D> ().velocity = new Vector2 (playerSpeed, 0);
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject x = (GameObject) Instantiate (bullet, player.transform.position, bullet.transform.rotation);
			x.GetComponent <Rigidbody2D> ().velocity = new Vector3 (0, bulletSpeed);
		}

		if (toGo <= 0) {
			Time.timeScale = 0;
			PlayerPrefs.SetInt ("level done", PlayerPrefs.GetInt ("level done") + 1);
			ui.transform.localScale = new Vector2 (1, 1);
		}

	}
}
