using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class symptomCheck : MonoBehaviour {
    
    public symptomManager symManager;
	// Use this for initialization
	void Start () {
        symManager = GameObject.Find("Text1").GetComponent<symptomManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void onValueChanged()
    {
        symManager.toggleSymptoms(this.GetComponent<Identifier>());
    }
}
