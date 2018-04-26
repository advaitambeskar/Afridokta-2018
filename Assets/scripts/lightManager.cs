using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightManager : MonoBehaviour {
    public Dictionary<bodyPart, Light[]> lightDictionary;
    public Light lightUpperHead1, lightUpperHead2, lightUpperHead3, lightUpperHead4;
    public Light lightLowerHead1, lightLowerHead2, lightLowerHead3, lightLowerHead4;
    public Light lightKnee1, lightKnee2;
    public Light lightFoot1, lightFoot2;
    
    public Light[] lightChest, lightBelly;
    public Light[] lightUpperBack, lightLowerBack;
    public Light[] lightUpperLeftLeg, lightUpperRightLeg, lightLowerLeftLeg, lightLowerRightLeg;
    public Light[] lightRightBiceps, lightLeftBiceps, lightRightForearms, lightLeftForearms;

    public Light[] lightUpperHead, lightLowerHead, lightKnees, lightFeet;

    private Color hoverColor = Color.cyan;
    private Color selectColor = Color.yellow;
    private Color hoverSelColor = Color.green;
    private Color activeColor = Color.grey;
    private Color hoverActColor = Color.blue;
    private Color hoverSelActColor = new Color(0.2F, 0.3F, 0.4F, 1F);
    private Color selectActColor = Color.magenta;

	// Use this for initialization
	void Start () {
		
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

        lightDictionary = new Dictionary<bodyPart, Light[]>()
        {
            {bodyPart.UpperRightLeg,  lightUpperRightLeg},
            {bodyPart.Knees,          lightKnees},
            {bodyPart.UpperLeftLeg,   lightUpperLeftLeg},
            {bodyPart.Belly,          lightBelly},
            {bodyPart.LowerRightLeg,  lightLowerRightLeg},
            {bodyPart.LowerHead,      lightLowerHead},
            {bodyPart.LowerBack,      lightLowerBack},
            {bodyPart.LowerLeftLeg,   lightLowerLeftLeg},
            {bodyPart.Feet,           lightFeet},
            {bodyPart.UpperHead,      lightUpperHead},
            {bodyPart.UpperBack,      lightUpperBack},
            {bodyPart.Chest,          lightChest},
            {bodyPart.RightBiceps,    lightRightBiceps},
            {bodyPart.RightForearms,  lightLeftForearms},
            //{bodyPart.RightTriceps,   },
            {bodyPart.LeftBiceps,     lightLeftBiceps},
            {bodyPart.LeftForearms,   lightRightForearms},
            //{bodyPart.LeftTriceps,    }
        };
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Functions to set the color of lights when selected/hovered
    public void lightHover(string light)
    {
        foreach (Light l in getLight(light))
        {
            lightHover(l);
        }
    }

    public void lightLeaveHover(string light)
    {
        foreach (Light l in getLight(light))
        {
            lightLeaveHover(l);
        }
    }

    public void lightSelect(bodyPart part)
    {
        Light[] light = new Light[] { };
        if(lightDictionary.TryGetValue (part, out light))
        {
            lightSelect(light);
        }
    }

    public void lightUnselect(bodyPart part)
    {
        Light[] light = new Light[] { };
        if(lightDictionary.TryGetValue (part, out light))
        {
            lightUnselect(light);
        }
    }

    public void lightActivate(bodyPart part)
    {
        Light[] light = new Light[] { };
        if(lightDictionary.TryGetValue (part, out light))
        {
            lightActivate(light);
        }
    }

    public void lightDeactivate(bodyPart part)
    {
        Light[] light = new Light[] { };
        if(lightDictionary.TryGetValue (part, out light))
        {
            lightDeactivate(light);
        }
    }

    public void lightSelect(string light)
    {
        lightSelect(getLight(light));
    }

    public void lightSelect(Light[] light)
    {
        foreach (Light l in light)
        {
            lightSelect(l);
        }
    }
    
    public void lightUnselect(string light)
    {
        lightUnselect(getLight(light));
    }

    public void lightUnselect(Light[] light)
    {
        foreach (Light l in light)
        {
            lightUnselect(l);
        }
    }
    
    public void lightActivate(string light)
    {
        lightActivate(getLight(light));
    }

    public void lightActivate(Light[] light)
    {
        foreach (Light l in light)
        {
            lightActivate(l);
        }
    }
    
    public void lightDeactivate(string light)
    {
        lightDeactivate(getLight(light));
    }

    public void lightDeactivate(Light[] light)
    {
        foreach (Light l in light)
        {
            lightDeactivate(l);
        }
    }

    public void lightHover(Light light)
    {
        if (!light.enabled) { light.color = hoverColor; }
        else if (light.color == activeColor){ light.color = hoverActColor; }
        else if (light.color == selectColor){ light.color = hoverSelColor; }
        else if (light.color == selectActColor) { light.color = hoverSelActColor; }
        light.enabled = true; 
    }

    public void lightLeaveHover(Light light)
    {
        if (light.color == hoverColor) { light.enabled = false; }
        else if(light.color == hoverActColor) { light.color = activeColor; }
        else if(light.color == hoverSelColor) { light.color = selectColor; }
        else if(light.color == hoverSelActColor) { light.color = selectActColor; }
    }

    public void lightSelect(Light light)
    {
        if (light.color == hoverColor) { light.color = hoverSelColor; }
        else if(light.color == hoverActColor) { light.color = hoverSelActColor; }
    }

    public void lightUnselect(Light light)
    {
        if (light.color == selectColor) { light.color = hoverColor; light.enabled = false; }
        else if(light.color == selectActColor) { light.color = activeColor; }
    }

    public void lightActivate(Light light)
    {
        if (light.color == selectColor) { light.color = selectActColor; }
    }

    public void lightDeactivate(Light light)
    {
        if (light.color == selectActColor) { light.color = selectColor; }
        else if (light.color == activeColor)
        {
            light.color = hoverColor;
            light.enabled = false;
        }
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
