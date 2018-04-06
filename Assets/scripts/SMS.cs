using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SMS : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // sends an SMS to the number provided with the message
    public void Click()
    {
        TextAsset txt = (TextAsset)Resources.Load("Symptoms", typeof(TextAsset));
        string message = txt.text;

        string mobile_num = "1000000000";

        //string message = "This is a test from Unity *^#$#$((*&& Test Symbols";

       


    //Android SMS URL - doesn't require encoding for sms call to work
    string URL = string.Format("sms:{0}?body={1}", mobile_num, System.Uri.EscapeDataString(message));

        Application.OpenURL(URL);
    }
}
