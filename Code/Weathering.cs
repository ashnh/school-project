using UnityEngine;
using System.Collections;

public class Weathering : MonoBehaviour {

	public GameObject progressBar;
	
	public Material firstColor;
	public Material secondColor;
	public Material thirdColor;

	public SpriteRenderer rock;
	
	public Sprite oneOfThree;
	public Sprite twoOfThree;
	public Sprite threeOfThree;

	public GameObject popup;

	bool finished;

	// Use this for initialization
	void Start () {
		finished = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (progressBar.transform.localScale.x <= 1 && !finished) {
			progressBar.transform.localScale = new Vector3 (progressBar.transform.localScale.x + 0.001F, progressBar.transform.localScale.y, progressBar.transform.localScale.z);
		}

		if (Input.GetKeyDown (KeyCode.F) && !finished) {
			progressBar.transform.localScale = new Vector3 (progressBar.transform.localScale.x - 0.03F, progressBar.transform.localScale.y, progressBar.transform.localScale.z);
		}
		
		if (progressBar.transform.localScale.x >= .66F) {
			rock.sprite = oneOfThree;
			progressBar.GetComponentInChildren <Renderer> ().material = firstColor;
		} else if (progressBar.transform.localScale.x >= .33F) {
			rock.sprite = twoOfThree;
			progressBar.GetComponentInChildren <Renderer> ().material = secondColor;
		} else {
			rock.sprite = threeOfThree;
			progressBar.GetComponentInChildren <Renderer> ().material = thirdColor;
		}

		if (progressBar.transform.localScale.x <= 0) {
			finished = true;
		}

		Debug.Log (finished);

		if (finished) {
			popup.transform.localScale = new Vector3 (1, 1, 1);
			Time.timeScale = 0;
		}

	}
}
