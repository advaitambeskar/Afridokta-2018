using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part : MonoBehaviour {
    public Text mytext;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void onClick()
    {
        mytext.text = this.ToString();
        mytext.text = mytext.text.Substring(0, mytext.text.Length - 6);

    }
}
