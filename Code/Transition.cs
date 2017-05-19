using UnityEngine;
using System.Collections;

public class Transition : MonoBehaviour {

	public GameObject ui;

	void Update () {

		if (PlayerPrefs.GetInt ("level done") >= 2) {
			ui.transform.localScale = new Vector3 (1, 1, 1);
		} else {
			ui.transform.localScale = new Vector3 (0, 1, 1);
		}

		if (Input.GetKey (KeyCode.R)) {
			PlayerPrefs.SetInt ("level done", 0);
		}

		if (Input.GetKey (KeyCode.Q)) {
			PlayerPrefs.SetInt ("level done", 2);
		}

	}
}
