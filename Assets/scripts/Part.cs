using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part : MonoBehaviour
{
    string selectedPart;
    public Text mytext, mytext1;
    public Light lightUpperHead1, lightUpperHead2, lightUpperHead3, lightUpperHead4;
    public Light lightLowerHead1, lightLowerHead2, lightLowerHead3, lightLowerHead4;
    public Light lightKnee1, lightKnee2;
    public Light lightFoot1, lightFoot2;
    
    public Light[] lightChest, lightBelly;
    public Light[] lightUpperBack, lightLowerBack;
    public Light[] lightUpperLeftLeg, lightUpperRightLeg, lightLowerLeftLeg, lightLowerRightLeg;
    public Light[] lightRightBiceps, lightLeftBiceps, lightRightForearms, lightLeftForearms;

    public Light[] lightUpperHead, lightLowerHead, lightKnees, lightFeet;

    public textbox textManager;
    public symptomManager symManager;
	public Transform SymptomCanvas;
	public Dictionary<string, List<string>> symptomsDictionary;
    public List<string> defaultSymptoms;

    private Color hoverColor = Color.cyan;
    private Color selectColor = Color.yellow;
    private Color hoverselColor = Color.green;

    // Use this for initialization
    void Start()
    {
        textManager = GameObject.Find("LeftBodyPart").GetComponent<textbox>();
        symManager = GameObject.Find("Text1").GetComponent<symptomManager>();

        lightUpperHead1 = GameObject.Find("Point Light head (0)").GetComponent<Light>();
        lightUpperHead2 = GameObject.Find("Point Light head (1)").GetComponent<Light>();
        lightUpperHead3 = GameObject.Find("Point Light head (2)").GetComponent<Light>();
        lightUpperHead4 = GameObject.Find("Point Light head (3)").GetComponent<Light>();

        lightLowerHead1 = GameObject.Find("Point Light head (4)").GetComponent<Light>();
        lightLowerHead2 = GameObject.Find("Point Light head (5)").GetComponent<Light>();
        lightLowerHead3 = GameObject.Find("Point Light head (6)").GetComponent<Light>();
        lightLowerHead4 = GameObject.Find("Point Light head (7)").GetComponent<Light>();

        lightKnee1 = GameObject.Find("Point Light Knee (1)").GetComponent<Light>();
        lightKnee2 = GameObject.Find("Point Light Knee (2)").GetComponent<Light>();

        lightFoot1 = GameObject.Find("Point Light Foot (1)").GetComponent<Light>();
        lightFoot2 = GameObject.Find("Point Light Foot (2)").GetComponent<Light>();

        lightChest = new Light[] { GameObject.Find("Point Light Chest").GetComponent<Light>() };
        lightBelly = new Light[] { GameObject.Find("Point Light Belly").GetComponent<Light>() };
        lightUpperBack = new Light[] { GameObject.Find("Point Light UpperBack").GetComponent<Light>() };
        lightLowerBack = new Light[] { GameObject.Find("Point Light LowerBack").GetComponent<Light>() };
        lightUpperLeftLeg = new Light[] { GameObject.Find("Point Light UpperLeftLeg").GetComponent<Light>() };
        lightUpperRightLeg = new Light[] { GameObject.Find("Point Light UpperRightLeg").GetComponent<Light>() };
        lightLowerLeftLeg = new Light[] { GameObject.Find("Point Light LowerLeftLeg").GetComponent<Light>() };
        lightLowerRightLeg = new Light[] { GameObject.Find("Point Light LowerRightLeg").GetComponent<Light>() };
        lightRightBiceps = new Light[] { GameObject.Find("Point Light RightBiceps").GetComponent<Light>() };
        lightLeftBiceps = new Light[] { GameObject.Find("Point Light LeftBiceps").GetComponent<Light>() };
        lightRightForearms = new Light[] { GameObject.Find("Point Light RightForearms").GetComponent<Light>() };
        lightLeftForearms = new Light[] { GameObject.Find("Point Light LeftForearms").GetComponent<Light>() };

        //Declare lights that should be toggled together
        lightUpperHead = new Light[] { lightUpperHead1, lightUpperHead2, lightUpperHead3, lightUpperHead4 };
        lightLowerHead = new Light[] { lightLowerHead1, lightLowerHead2, lightLowerHead3, lightLowerHead4 };
        lightKnees     = new Light[] { lightKnee1, lightKnee2 };
        lightFeet      = new Light[] { lightFoot1, lightFoot2 };

        selectedPart = "";
	
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onClick()
    {
        //Add selection to textManager
        textManager.toggle(this.gameObject);
        symManager.setPart(this.gameObject);
        
        //Toggle Light Selection
        String temp = (this.ToString()).Substring(0, this.ToString().Length - 7);
        foreach (Light l in getLight(temp))
        {
            lightClick(l);
        }

        //Symptoms
        //Remove all symptomT from symptomToggles gameobject
		GameObject[] symptomToggles;
		symptomToggles = GameObject.FindGameObjectsWithTag ("Symptom");
		foreach (GameObject symptomT in symptomToggles) {
			Destroy (symptomT);
		}

        //Populate symptom canvas with the symptoms
        symManager.setPart(this.gameObject);
    }

    public void onHover()
    {
        String temp = (this.ToString()).Substring(0, this.ToString().Length - 7);

        foreach (Light l in getLight(temp))
        {
            lightHover(l);
        }
    }

    public void leaveHover()
    {
        String temp = (this.ToString()).Substring(0, this.ToString().Length - 7);
        
        foreach (Light l in getLight(temp))
        {
            lightLeaveHover(l);
        }
    }

    //Functions to set the color of lights when selected/hovered
    public void lightHover(Light light)
    {
        if (light.color == selectColor) { light.color = hoverselColor; light.enabled = true; }
        else if (light.color == hoverselColor) { Debug.Log("Error: Hover over light that already has hover color: " + light.ToString()); }
        else { light.color = hoverColor; light.enabled = true; }
    }

    public void lightLeaveHover(Light light)
    {
        if (light.color == hoverselColor) { light.color = selectColor; }
        else { light.enabled = false; }
    }

    public void lightClick(Light light)
    {
        if (light.color == hoverColor) { light.color = hoverselColor; }
        else { light.color = hoverColor; }
    }

    public Light[] getLight(string light)
    {
        switch (light) {
            case "UpperHead":
                return lightUpperHead;
                break;
            case "Chest":
                return lightChest;
                break;
            case "Belly":
                return lightBelly;
                break;
            case "Knees":
                return lightKnees;
                break;
            case "Feet":
                return lightFeet;
                break;
            case "LowerHead":
                return lightLowerHead;
                break;
            case "UpperBack":
                return lightUpperBack;
                break;
            case "Lower Back":
                return lightLowerBack;
                break;
            case "LowerLeftLeg":
                return lightLowerLeftLeg;
                break;
            case "UpperLeftLeg":
                return lightUpperLeftLeg;
                break;
            case "LowerRightLeg":
                return lightLowerRightLeg;
                break;
            case "UpperRightLeg":
                return lightUpperRightLeg;
                break;
            case "Left Biceps":
                return lightLeftBiceps;
                break;
            case "Left Forearms":
                return lightLeftForearms;
                break;
            case "Right Biceps":
                return lightRightBiceps;
                break;
            case "Right Forearms":
                return lightRightForearms;
                break;
            default:
                Debug.Log("Invalid light text: " + light);
                return null;
                break;
        }
    }

    public void closeAllLight() {

        lightUpperHead1.enabled = false;
        lightUpperHead2.enabled = false;
        lightUpperHead3.enabled = false;
        lightUpperHead4.enabled = false;
        lightChest[0].enabled = false;
        lightBelly[0].enabled = false;
        lightKnee1.enabled = false;
        lightKnee2.enabled = false;
        lightFoot1.enabled = false;
        lightFoot2.enabled = false;
        lightLowerHead1.enabled = false;
        lightLowerHead2.enabled = false;
        lightLowerHead3.enabled = false;
        lightLowerHead4.enabled = false;
        lightUpperBack[0].enabled = false;
        lightLowerBack[0].enabled = false;
        lightLowerLeftLeg[0].enabled = false;
        lightUpperLeftLeg[0].enabled = false;
        lightLowerRightLeg[0].enabled = false;
        lightUpperRightLeg[0].enabled = false;
        lightLeftBiceps[0].enabled = false;
        lightLeftForearms[0].enabled = false;
        lightRightBiceps[0].enabled = false;
        lightRightForearms[0].enabled = false;
    }
}
