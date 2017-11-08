using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour {

	public Button theButton;
	private Text[] text;

	// Use this for initialization
	void Start () {
		Button btn = theButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}
	
	//TaskOnClick called for each click on button
	void TaskOnClick()
	{
		Debug.Log ("you clicked the ... button!");
		text = theButton.GetComponentsInChildren<Text> ();
		Debug.Log ("Text=" + text[0]);
	}
}
