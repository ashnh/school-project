using UnityEngine;
using System.Collections;

public class SideScroller : MonoBehaviour {
	
	public GameObject player;
	
	public GameObject platforms;
	
	public GameObject risingSediment;
	
	public GameObject ui;
	
	public GameObject finishPlatform;

	public float jumpSpeed;
	public float runSpeed;

	public float climbSpeed;

	bool checkTouch (GameObject z) {
		foreach (Collider2D x in z.GetComponentsInChildren <Collider2D> ()) {
			if (player.GetComponent <Collider2D> ().IsTouching (x)) {
				return true;
			}
		}
		return false;
	}
	
	void Update() {
		if (Input.GetKeyDown (KeyCode.W) && (player.GetComponent <Collider2D> ().IsTouching (platforms.GetComponent <Collider2D> ()) || checkTouch(platforms))) {
			player.GetComponent <Rigidbody2D> ().velocity = new Vector2 (player.GetComponent <Rigidbody2D> ().velocity.x, jumpSpeed);
		}
		
		if (Input.GetKey (KeyCode.A)) {
			player.GetComponent <Rigidbody2D> ().velocity = new Vector2 (-runSpeed, player.GetComponent <Rigidbody2D> ().velocity.y);
		} else if (Input.GetKey (KeyCode.D)) {
			player.GetComponent <Rigidbody2D> ().velocity = new Vector2 (runSpeed, player.GetComponent <Rigidbody2D> ().velocity.y);
		} else {
			player.GetComponent <Rigidbody2D> ().velocity = new Vector2 (0, player.GetComponent <Rigidbody2D> ().velocity.y);
		}
		
		if (checkTouch (risingSediment)) {
			UnityEngine.SceneManagement.SceneManager.LoadScene (UnityEngine.SceneManagement.SceneManager.GetActiveScene ().buildIndex);
		} 
		
		
		if (player.GetComponent <Collider2D> ().IsTouching (finishPlatform.GetComponent<Collider2D> ())){ 
			Time.timeScale = 0F;
			ui.transform.localScale = new Vector3 (1, 1, 1);
		} 
		if (!player.GetComponent <Collider2D> ().IsTouching (finishPlatform.GetComponent<Collider2D> ())) {
			risingSediment.transform.position = new Vector3 (risingSediment.transform.position.x, risingSediment.transform.position.y + climbSpeed, risingSediment.transform.position.z);
		}
		//Debug.Log (player.GetComponent <Collider2D> ().IsTouching (platforms.GetComponentsInChildren <Collider2D> ()));
		
	}
	
}
