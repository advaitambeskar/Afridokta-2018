using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class symptomCheck : MonoBehaviour {
    
    public symptomManager symManager;
    public symptom mySymptom;
	// Use this for initialization
	void Start () {
        symManager = GameObject.Find("Text1").GetComponent<symptomManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ToggleValue()
    {
        symManager.toggleSymptom(mySymptom);
    }
}
