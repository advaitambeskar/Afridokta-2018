using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part : MonoBehaviour {
    public Text mytext;
	public Light myLight;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void onClick()
    {
        mytext.text = this.ToString();
        mytext.text = mytext.text.Substring(0, mytext.text.Length - 7);
		switch (mytext.text) {
			case "UpperHead":
				myLight = GameObject.Find("Point light head").GetComponent<Light>();
				myLight.enabled = !myLight.enabled;
				break;
			case "LeftChest":
				myLight = GameObject.Find("Point light chest").GetComponent<Light>();
				myLight.enabled = !myLight.enabled;
				break;
			default:
				break;
		}

    }
}
