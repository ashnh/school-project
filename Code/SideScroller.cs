using UnityEngine;
using System.Collections;

public class SideScroller : MonoBehaviour {
	
	public GameObject player;
	
	public GameObject platforms;
	
	public GameObject risingSediment;
	
	public float jumpSpeed;
	public float runSpeed;
	
	void Start() {
		
	}
	
	void Update() {
		if (Input.GetKeyDown (KeyCode.W) && player.GetComponent <Collider2D> ().isTouching (platforms.GetComponent <Collider2D> ())) {
			player.GetComponent <Rigidbody2D> ().velocity = new Vector2 (player.GetComponent <Rigidbody2D> ().velocity.x, jumpSpeed          );
		}
		
		if (Input.GetKeyDown (KeyCode.A)) {
			player.GetComponent <Rigidbody2D> ().velocity = new Vector2 (-runSpeed, player.GetComponent <Rigidbody2D> ().velocity.y          );
		} else if (Input.GetKeyDown (KeyCode.D)) {
			player.GetComponent <Rigidbody2D> ().velocity = new Vector2 (runSpeed, player.GetComponent <Rigidbody2D> ().velocity.y          );
		}
		
		
		
	}
	
}
