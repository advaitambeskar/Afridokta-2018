using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part : MonoBehaviour
{
    string selectedPart;
    public Text mytext, mytext1;

    public textbox textManager;
    public symptomManager symManager;
    public lightManager lManager;
	public Transform SymptomCanvas;
	public Dictionary<string, List<string>> symptomsDictionary;
    public List<string> defaultSymptoms;

    // Use this for initialization
    void Start()
    {
        textManager = GameObject.Find("LeftBodyPart").GetComponent<textbox>();
        symManager = GameObject.Find("Text1").GetComponent<symptomManager>();
        lManager = GameObject.Find("Text1").GetComponent<lightManager>();

        selectedPart = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onClick()
    {
        //Symptoms
        //Remove all symptomT from symptomToggles gameobject
		GameObject[] symptomToggles;
		symptomToggles = GameObject.FindGameObjectsWithTag ("Symptom");
		foreach (GameObject symptomT in symptomToggles) {
			Destroy (symptomT);
		}

        //Set symptom canvas with the selected part
        symManager.setPart(this.gameObject);
    }

    public void onHover()
    {
        String temp = (this.ToString()).Substring(0, this.ToString().Length - 7);

        lManager.lightHover(temp);
    }

    public void leaveHover()
    {
        String temp = (this.ToString()).Substring(0, this.ToString().Length - 7);

        lManager.lightLeaveHover(temp);
    }
}
