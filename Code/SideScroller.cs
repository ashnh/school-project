using UnityEngine;
using System.Collections;

public class SideScroller : MonoBehaviour {
	
	public GameObject player;
	
	public GameObject platforms;
	
	public GameObject risingSediment;
	
	public GameObejct ui;
	
	public GameObject finishPlatform;
	
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
		
		if (player.GetComponent <Collider2D> ().isTouching (risingSediment.GetComponent <Collider2D> ())) {
			UnityEngine.SceneManagement.SceneManager.LoadScene (UnityEngine.SceneManagement.SceneManager.sceneLoaded);
		} 
		
		
		if (player.GetComponent <Collider2D> ().isTouching (finishPlatform.GetComponent<Collider2D> ())){ 
			Time.scale = 0;
			ui.transform.localScale = new Vector3 (1, 1, 1);
		} 
		risingSediment.transform.position = new Vector3 (risingSediment.transform.position.x, risingSediment.transform.position
								 y+0.3F, risingSediment.transform.position.z);
		
		
		
	}
	
}
