using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Welcome : MonoBehaviour {

	public int secondsToWait;
	public RawImage logo;
	public Text text;
	public CanvasGroup primarySelection;

	private bool showLogo;

	// Use this for initialization
	void Start () {
		logo = logo.GetComponent<RawImage>();
		text = text.GetComponent<Text>();
		primarySelection = primarySelection.GetComponent<CanvasGroup>();

		showLogo = true;
		primarySelection.alpha = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (!showLogo) {
			logo.CrossFadeAlpha(0.0f, 1.0f, false);
			text.CrossFadeAlpha(0.0f, 1.0f, false);
			StartCoroutine (FadeInSelection ());
		} else {
			StartCoroutine(ShowCoroutine());
		}
	}

	IEnumerator ShowCoroutine() {
		//Debug.Log("Before waiting " + secondsToWait + " seconds");
		yield return new WaitForSeconds(secondsToWait);
		//Debug.Log("After Waiting " + secondsToWait + " seconds");
		showLogo = false;
	}

	IEnumerator FadeInSelection (){
		while (primarySelection.alpha < 1) {
			//Debug.Log ("Fading In primary Selection");
			primarySelection.alpha += Time.deltaTime / 25; //Fades-in over 1 second
			yield return null;
		}
	}
}
