using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part : MonoBehaviour
{
    string selectedPart;
    string text;
    string text1;
    public Text mytext, mytext1;
    public Light lightUpperHead1, lightUpperHead2, lightUpperHead3, lightUpperHead4;
    public Light lightLowerHead1, lightLowerHead2, lightLowerHead3, lightLowerHead4;
    //public Light lightChest, lightBelly;
    public Light lightKnee1, lightKnee2;
    public Light lightFoot1, lightFoot2;
    /*public Light lightUpperBack, lightLowerBack;
    public Light lightUpperLeftLeg, lightUpperRightLeg, lightLowerLeftLeg, lightLowerRightLeg;
    public Light lightRightBiceps, lightLeftBiceps, lightRightForearms, lightLeftForearms;*/
    
    public Light[] lightChest, lightBelly;
    public Light[] lightUpperBack, lightLowerBack;
    public Light[] lightUpperLeftLeg, lightUpperRightLeg, lightLowerLeftLeg, lightLowerRightLeg;
    public Light[] lightRightBiceps, lightLeftBiceps, lightRightForearms, lightLeftForearms;

    public Light[] lightUpperHead, lightLowerHead, lightKnees, lightFeet;

    public textbox textManager;

    private Color hoverColor = Color.cyan;
    private Color selectColor = Color.red;
    private Color hoverselColor = Color.yellow;

    // Use this for initialization
    void Start()
    {
        textManager = GameObject.Find("LeftBodyPart").GetComponent<textbox>();

        lightUpperHead1 = GameObject.Find("Point Light head (0)").GetComponent<Light>();
        lightUpperHead2 = GameObject.Find("Point Light head (1)").GetComponent<Light>();
        lightUpperHead3 = GameObject.Find("Point Light head (2)").GetComponent<Light>();
        lightUpperHead4 = GameObject.Find("Point Light head (3)").GetComponent<Light>();

        lightLowerHead1 = GameObject.Find("Point Light head (4)").GetComponent<Light>();
        lightLowerHead2 = GameObject.Find("Point Light head (5)").GetComponent<Light>();
        lightLowerHead3 = GameObject.Find("Point Light head (6)").GetComponent<Light>();
        lightLowerHead4 = GameObject.Find("Point Light head (7)").GetComponent<Light>();

        /*lightChest = GameObject.Find("Point Light Chest").GetComponent<Light>();
        lightBelly = GameObject.Find("Point Light Belly").GetComponent<Light>();*/

        lightKnee1 = GameObject.Find("Point Light Knee (1)").GetComponent<Light>();
        lightKnee2 = GameObject.Find("Point Light Knee (2)").GetComponent<Light>();

        lightFoot1 = GameObject.Find("Point Light Foot (1)").GetComponent<Light>();
        lightFoot2 = GameObject.Find("Point Light Foot (2)").GetComponent<Light>();

        /*lightUpperBack = GameObject.Find("Point Light UpperBack").GetComponent<Light>();
        lightLowerBack = GameObject.Find("Point Light LowerBack").GetComponent<Light>();

        lightUpperLeftLeg = GameObject.Find("Point Light UpperLeftLeg").GetComponent<Light>();
        lightUpperRightLeg = GameObject.Find("Point Light UpperRightLeg").GetComponent<Light>();
        lightLowerLeftLeg = GameObject.Find("Point Light LowerLeftLeg").GetComponent<Light>();
        lightLowerRightLeg = GameObject.Find("Point Light LowerRightLeg").GetComponent<Light>();

        lightRightBiceps = GameObject.Find("Point Light RightBiceps").GetComponent<Light>();
        lightLeftBiceps = GameObject.Find("Point Light LeftBiceps").GetComponent<Light>();
        lightRightForearms = GameObject.Find("Point Light RightForearms").GetComponent<Light>();
        lightLeftForearms = GameObject.Find("Point Light LeftForearms").GetComponent<Light>();*/

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

        lightUpperHead = new Light[] { lightUpperHead1, lightUpperHead2, lightUpperHead3, lightUpperHead4 };
        lightLowerHead = new Light[] { lightLowerHead1, lightLowerHead2, lightLowerHead3, lightLowerHead4 };
        lightKnees     = new Light[] { lightKnee1, lightKnee2 };
        lightFeet      = new Light[] { lightFoot1, lightFoot2 };

        selectedPart = "";
        text1 = "";
        text = "";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onClick()
    {
        //Add selection to textManager
        textManager.add(this.gameObject);

        mytext.text = String.Copy(this.ToString());
        string temp = String.Copy(mytext.text.Substring(0, mytext.text.Length - 7));
        mytext.text = String.Copy(temp);
        textManager.add(this.gameObject);
        
        GameObject.Find("Male").GetComponent<Public>().selectedPart = temp;
        this.selectedPart = GameObject.Find("Male").GetComponent<Public>().selectedPart;
        
        foreach (Light l in getLight(temp))
        {
            lightClick(l);
        }

        /*
        if (mytext.text.Equals("UpperRightLeg"))
        {
            //lightUpperRightLeg.enabled = true;
            //mytext.text = mytext.text + " / Mguu";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }
        else if (mytext.text.Equals("Knees"))
        {
            //lightKnee1.enabled = true;
            //lightKnee2.enabled = true;
            //mytext.text = mytext.text + " / Magoti";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
           
        }
        else if(mytext.text.Equals("UpperLeftLeg"))
        {
            //lightUpperLeftLeg.enabled = true;
            
            //mytext.text = mytext.text + " / Mguu";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }
        else if(mytext.text.Equals("Belly"))
        {
            //lightBelly.enabled = true;
            //mytext.text = mytext.text + " / Tumbo";
            mytext1.text = "Stomach ache\nVomiting";
           
        }
        else if(mytext.text.Equals("LowerRightLeg"))
        {
            lightLowerRightLeg.enabled = true;
            //mytext.text = mytext.text + " / Mguu";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }
        else if (mytext.text.Equals("LowerHead"))
        {
            lightLowerHead1.enabled = true;
            lightLowerHead2.enabled = true;
            lightLowerHead3.enabled = true;
            lightLowerHead4.enabled = true;
            //mytext.text = mytext.text + " / Shingo";
            mytext1.text = "Sore Throat\nVertigo\n";
        }
        else if (mytext.text.Equals("Lower Back"))
        {
            lightLowerBack.enabled = true;
            //mytext.text = mytext.text + " / Kurudi nyuma";
            mytext1.text = "Back Ache";
        }
        else if (mytext.text.Equals("LowerLeftLeg"))
        {
            lightLowerLeftLeg.enabled = true;
            //mytext.text = mytext.text + " / Mguu";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }
        else if (mytext.text.Equals("Feet"))
        {
            lightFoot1.enabled = true;
            lightFoot2.enabled = true;
            //mytext.text = mytext.text + " / Viganja";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
           
        }
        else if (mytext.text.Equals("UpperHead"))
        {
            lightUpperHead1.enabled = true;
            lightUpperHead2.enabled = true;
            lightUpperHead3.enabled = true;
            lightUpperHead4.enabled = true;
            //mytext.text = mytext.text + " / Kichwa cha juu";
            mytext1.text = "Headache\nEarache\nHearing Loss\nNose Bleed\n";
           

        }
        else if (mytext.text.Equals("UpperBack"))
        {
            lightUpperBack.enabled = true;
            //mytext.text = mytext.text + " / Nyuma ya nyuma";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }
        else if (mytext.text.Equals("Chest"))
        {
            lightChest.enabled = !lightChest.enabled;
            //mytext.text = mytext.text + " / Kifua";
            mytext1.text = "Chest Pain\nHeart palpitations\nCough\nShortness of Breath";
           
        }

        else if (mytext.text.Equals("Right Biceps"))
        {
            lightRightBiceps.enabled = true;
            //mytext.text = mytext.text + " / Mikono";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Right Forearms"))
        {
            lightRightForearms.enabled = true;
            //mytext.text = mytext.text + " / Mikono";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Right Triceps"))
        {
            //mytext.text = mytext.text;
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Right HandPinky"))
        {
            //mytext.text = mytext.text + " / Kidole kidogo";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Right HandRing"))
        {
            //mytext.text = mytext.text + " / Pete kidole";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Right HandMiddle"))
        {
            //mytext.text = mytext.text + " / Kidole cha kati";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Right HandIndex"))
        {
            //mytext.text = mytext.text + " / kidole cha kwanza";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Right HandThumb"))
        {
            //mytext.text = mytext.text + " / Kidole gumba";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Left Biceps"))
        {
            lightLeftBiceps.enabled = true;
            //mytext.text = mytext.text + " / Mikono";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Left Forearms"))
        {
            lightLeftForearms.enabled = true;
            //mytext.text = mytext.text + " / Mikono";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Left Triceps"))
        {
            //mytext.text = mytext.text;
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("LeftHandPinky"))
        {
            //mytext.text = mytext.text + " / kidole kidogo";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("LeftHandring"))
        {
            //mytext.text = mytext.text + " / pete kidole";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("LeftHandMiddle"))
        {
            //mytext.text = mytext.text + " / kidole cha kati";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("LeftHandIndex"))
        {
            //mytext.text = mytext.text + " / kidole cha kwanza";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("LeftHandThumb"))
        {
            //mytext.text = mytext.text + " / Kidole gumba";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else
        {
            Debug.Log("Invalid light text: " + mytext.text);
        }*/

        //GameObject.Find("Male").GetComponent<Public>().text = mytext.text;
        //GameObject.Find("Male").GetComponent<Public>().text1 = mytext1.text;

    }

    public void onHover()
    {
        mytext.text = this.ToString();
        String temp = mytext.text.Substring(0, mytext.text.Length - 7);

        foreach (Light l in getLight(temp))
        {
            lightHover(l);
        }

        /*this.selectedPart = GameObject.Find("Male").GetComponent<Public>().selectedPart;
        if (mytext.text.Equals("UpperRightLeg"))
        {
            mytext1.text = "";
            if (selectedPart.Equals("UpperRightLeg"))
            {
                mytext1.text = text1;
            }
            else
            {
                mytext1.text = "";
            }
        }
        else if (mytext.text.Equals("Knees"))
        {
            mytext1.text = "";
            if (selectedPart.Equals("Knees"))
            {
                mytext1.text = text1;
            }
            else
            {
                mytext1.text = "";
            }
        }
        else if (mytext.text.Equals("UpperLeftLeg"))
        {
            mytext1.text = "";
            if (selectedPart.Equals("UpperLeftLeg"))
            {
                mytext1.text = text1;
            }
            else
            {
                mytext1.text = "";
            }
        }
        else if (mytext.text.Equals("Belly"))
        {
            mytext1.text = "";
            if (selectedPart.Equals("UpperHead"))
            {
                mytext1.text = text1;
            }
            else
            {
                mytext1.text = "";
            }
        }
        else if (mytext.text.Equals("LowerRightLeg"))
        {
            mytext1.text = "";
            if (selectedPart.Equals("LowerRightLeg"))
            {
                mytext1.text = text1;
            }
            else
            {
                mytext1.text = "";
            }
        }
        else if (mytext.text.Equals("LowerHead"))
        {
            mytext1.text = "";
            if (selectedPart.Equals("LowerHead"))
            {
                mytext1.text = text1;
            }
            else
            {
                mytext1.text = "";
            }
        }
        else if (mytext.text.Equals("Lower Back"))
        {
            mytext1.text = "";
            if (selectedPart.Equals("Lower Back"))
            {
                mytext1.text = text1;
            }
            else
            {
                mytext1.text = "";
            }
        }
        else if (mytext.text.Equals("LowerLeftLeg"))
        {
            mytext1.text = "";
            if (selectedPart.Equals("LowerLeftLeg"))
            {
                mytext1.text = text1;
            }
            else
            {
                mytext1.text = "";
            }
        }
        else if (mytext.text.Equals("Feet"))
        {
            mytext1.text = "";
            if (selectedPart.Equals("Feet"))
            {
                mytext1.text = text1;
            }
            else
            {
                mytext1.text = "";
            }
        }
        else if (mytext.text.Equals("UpperHead"))
        {
            mytext1.text = "";
            if (selectedPart.Equals("UpperHead"))
            {
                mytext1.text = text1;
            }
            else {
                mytext1.text = "";
            }
        }

        else if (mytext.text.Equals("UpperBack"))
        {
            mytext1.text = "";
            if (selectedPart.Equals("UpperBack"))
            {
                mytext1.text = text1;
            }
            else
            {
                mytext1.text = "";
            }
        }

        else if (mytext.text.Equals("Chest"))
        {
            mytext1.text = "";
            if (selectedPart.Equals("Chest"))
            {
                mytext1.text = text1;
            }
            else
            {
                mytext1.text = "";
            }
        }

        else if (mytext.text.Equals("Right Biceps"))
        {
            mytext1.text = "";
            if (selectedPart.Equals("Right Biceps"))
            {
                mytext1.text = text1;
            }
            else
            {
                mytext1.text = "";
            }
        }

        else if (mytext.text.Equals("Right Forearms"))
        {
            mytext1.text = "";
            if (selectedPart.Equals("Right Forearms"))
            {
                mytext1.text = text1;
            }
            else
            {
                mytext1.text = "";
            }
        }

        else if (mytext.text.Equals("Right Triceps"))
        {
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Right HandPinky"))
        {
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Right HandRing"))
        {
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Right HandMiddle"))
        {
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Right HandIndex"))
        {
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Right HandThumb"))
        {
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Left Biceps"))
        {
            mytext1.text = "";
            if (selectedPart.Equals("Left Biceps"))
            {
                mytext1.text = text1;
            }
            else
            {
                mytext1.text = "";
            }
        }

        else if (mytext.text.Equals("Left Forearms"))
        {
            mytext1.text = "";
            if (selectedPart.Equals("Left Forearms"))
            {
                mytext1.text = text1;
            }
            else
            {
                mytext1.text = "";
            }
        }

        else if (mytext.text.Equals("Left Triceps"))
        {
            mytext1.text = "";
        }

        else if (mytext.text.Equals("LeftHandPinky"))
        {
            mytext1.text = "";
        }

        else if (mytext.text.Equals("LeftHandring"))
        {
            mytext1.text = "";
        }

        else if (mytext.text.Equals("LeftHandMiddle"))
        {
            mytext1.text = "";
        }

        else if (mytext.text.Equals("LeftHandIndex"))
        {
            mytext1.text = "";
        }

        else if (mytext.text.Equals("LeftHandThumb"))
        {
            mytext1.text = "";
        }*/


    }

    public void leaveHover() {
        mytext.text = this.ToString();
        String temp = mytext.text.Substring(0, mytext.text.Length - 7);
        
        foreach (Light l in getLight(temp))
        {
            lightLeaveHover(l);
        }
        //mytext.text = "";
        mytext1.text = "";
        //text = GameObject.Find("Male").GetComponent<Public>().text;
        text1 = GameObject.Find("Male").GetComponent<Public>().text1;
        //mytext.text = text;
        //mytext1.text = text1;
    }
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
