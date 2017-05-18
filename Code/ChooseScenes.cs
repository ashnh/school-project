using UnityEngine;
using System.Collections;

public class ChooseScenes : MonoBehaviour {

	public void chooseScene (int sceneNumber) {
		UnityEngine.SceneManagement.SceneManager.LoadScene (sceneNumber);
	}
}
