using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Welcome : MonoBehaviour {

	public int secondsToWait;
	public RawImage logo;
	public Text text;

	private bool show;

	// Use this for initialization
	void Start () {
		logo = logo.GetComponent<RawImage>();
		text = text.GetComponent<Text>();

		show = true;

	}
	
	// Update is called once per frame
	void Update () {
		if (!show) {
			logo.CrossFadeAlpha(0.0f, 1.0f, false);
			text.CrossFadeAlpha(0.0f, 1.0f, false);
		} else {
			StartCoroutine(ShowCoroutine());
		}
	}

	IEnumerator ShowCoroutine() {
		Debug.Log("Before waiting " + secondsToWait + " seconds");
		yield return new WaitForSeconds(secondsToWait);
		Debug.Log("After Waiting " + secondsToWait + " seconds");
		show = false;
	}
}
