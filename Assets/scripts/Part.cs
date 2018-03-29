using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part : MonoBehaviour {
    public Text mytext;
	public GameObject button;
	public GameObject button2;
	public GameObject button3;
	// Use this for initialization
	void Start () {
		button.SetActive (false);
		button2.SetActive (false);
		button3.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void onClick()
    {
        mytext.text = this.ToString();
        mytext.text = mytext.text.Substring(0, mytext.text.Length - 6);
		button.SetActive (true);
		button2.SetActive (true);
		button3.SetActive (true);

    }
}
