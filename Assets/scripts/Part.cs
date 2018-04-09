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
    public Light lightChest, lightBelly;
    public Light lightKnee1, lightKnee2;
    public Light lightFoot1, lightFoot2;
    public Light lightUpperBack, lightLowerBack;
    public Light lightUpperLeftLeg, lightUpperRightLeg, lightLowerLeftLeg, lightLowerRightLeg;
    public Light lightRightBiceps, lightLeftBiceps, lightRightForearms, lightLeftForearms;
    
    public textbox textManager;

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

        lightChest = GameObject.Find("Point Light Chest").GetComponent<Light>();
        lightBelly = GameObject.Find("Point Light Belly").GetComponent<Light>();

        lightKnee1 = GameObject.Find("Point Light Knee (1)").GetComponent<Light>();
        lightKnee2 = GameObject.Find("Point Light Knee (2)").GetComponent<Light>();

        lightFoot1 = GameObject.Find("Point Light Foot (1)").GetComponent<Light>();
        lightFoot2 = GameObject.Find("Point Light Foot (2)").GetComponent<Light>();

        lightUpperBack = GameObject.Find("Point Light UpperBack").GetComponent<Light>();
        lightLowerBack = GameObject.Find("Point Light LowerBack").GetComponent<Light>();

        lightUpperLeftLeg = GameObject.Find("Point Light UpperLeftLeg").GetComponent<Light>();
        lightUpperRightLeg = GameObject.Find("Point Light UpperRightLeg").GetComponent<Light>();
        lightLowerLeftLeg = GameObject.Find("Point Light LowerLeftLeg").GetComponent<Light>();
        lightLowerRightLeg = GameObject.Find("Point Light LowerRightLeg").GetComponent<Light>();

        lightRightBiceps = GameObject.Find("Point Light RightBiceps").GetComponent<Light>();
        lightLeftBiceps = GameObject.Find("Point Light LeftBiceps").GetComponent<Light>();
        lightRightForearms = GameObject.Find("Point Light RightForearms").GetComponent<Light>();
        lightLeftForearms = GameObject.Find("Point Light LeftForearms").GetComponent<Light>();


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
        closeAllLight();
        GameObject.Find("Male").GetComponent<Public>().selectedPart = temp;
        this.selectedPart = GameObject.Find("Male").GetComponent<Public>().selectedPart;
        if (mytext.text.Equals("UpperRightLeg"))
        {
            lightUpperRightLeg.enabled = true;
            //mytext.text = mytext.text + " / Mguu";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }
        else if (mytext.text.Equals("Knees"))
        {
            lightKnee1.enabled = true;
            lightKnee2.enabled = true;
            //mytext.text = mytext.text + " / Magoti";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
           
        }
        else if(mytext.text.Equals("UpperLeftLeg"))
        {
            lightUpperLeftLeg.enabled = true;
            
            //mytext.text = mytext.text + " / Mguu";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }
        else if(mytext.text.Equals("Belly"))
        {
            lightBelly.enabled = true;
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
            lightChest.enabled = true;
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

        //GameObject.Find("Male").GetComponent<Public>().text = mytext.text;
        GameObject.Find("Male").GetComponent<Public>().text1 = mytext1.text;

    }

    public void onHover()
    {
        closeAllLight();
        //mytext.text = this.ToString();
        //mytext.text = mytext.text.Substring(0, mytext.text.Length - 7);
        this.selectedPart = GameObject.Find("Male").GetComponent<Public>().selectedPart;
        if (mytext.text.Equals("UpperRightLeg"))
        {
            lightUpperRightLeg.enabled = true;
            //mytext.text = mytext.text + " / Mguu";
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
            lightKnee1.enabled = true;
            lightKnee2.enabled = true;
            //mytext.text = mytext.text + " / Magoti";
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
            lightUpperLeftLeg.enabled = true;
            
            //mytext.text = mytext.text + " / Mguu";
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
            lightBelly.enabled = true;
            //mytext.text = mytext.text + " / Tumbo";
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
            lightLowerRightLeg.enabled = true;
            //mytext.text = mytext.text + " / Mguu";
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
            lightLowerHead1.enabled = true;
            lightLowerHead2.enabled = true;
            lightLowerHead3.enabled = true;
            lightLowerHead4.enabled = true;
            //mytext.text = mytext.text + " / Shingo";
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
            lightLowerBack.enabled = true;
            //mytext.text = mytext.text + " / Kurudi nyuma";
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
            lightLowerLeftLeg.enabled = true;
            //mytext.text = mytext.text + " / Mguu";
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
            lightFoot1.enabled = true;
            lightFoot2.enabled = true;
            //mytext.text = mytext.text + " / Viganja";
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
            lightUpperHead1.enabled = true;
            lightUpperHead2.enabled = true;
            lightUpperHead3.enabled = true;
            lightUpperHead4.enabled = true;
            //mytext.text = mytext.text + " / Kichwa cha juu";
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
            lightUpperBack.enabled = true;
            //mytext.text = mytext.text + " / Nyuma ya nyuma";
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
            lightChest.enabled = true;
            //mytext.text = mytext.text + " / Kifua";
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
            lightRightBiceps.enabled = true;
            //mytext.text = mytext.text + " / Mikono";
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
            lightRightForearms.enabled = true;
            //mytext.text = mytext.text + " / Mikono";
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
            //mytext.text = mytext.text;
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Right HandPinky"))
        {
            //mytext.text = mytext.text + " / Kidole kidogo";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Right HandRing"))
        {
            //mytext.text = mytext.text + " / Pete kidole";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Right HandMiddle"))
        {
            //mytext.text = mytext.text + " / Kidole cha kati";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Right HandIndex"))
        {
            //mytext.text = mytext.text + " / kidole cha kwanza";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Right HandThumb"))
        {
            //mytext.text = mytext.text + " / Kidole gumba";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Left Biceps"))
        {
            lightLeftBiceps.enabled = true;
            //mytext.text = mytext.text + " / Mikono";
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
            lightLeftForearms.enabled = true;
            //mytext.text = mytext.text + " / Mikono";
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
            //mytext.text = mytext.text;
            mytext1.text = "";
        }

        else if (mytext.text.Equals("LeftHandPinky"))
        {
            //mytext.text = mytext.text + " / kidole kidogo";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("LeftHandring"))
        {
            //mytext.text = mytext.text + " / pete kidole";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("LeftHandMiddle"))
        {
            //mytext.text = mytext.text + " / kidole cha kati";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("LeftHandIndex"))
        {
            //mytext.text = mytext.text + " / kidole cha kwanza";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("LeftHandThumb"))
        {
            //mytext.text = mytext.text + " / Kidole gumba";
            mytext1.text = "";
        }


    }

    public void leaveHover() {
        closeAllLight();
        //mytext.text = "";
        mytext1.text = "";
        Debug.Log(this.selectedPart);
        //text = GameObject.Find("Male").GetComponent<Public>().text;
        text1 = GameObject.Find("Male").GetComponent<Public>().text1;
        //mytext.text = text;
        mytext1.text = text1;
        switch (selectedPart) {
            case "UpperHead":
                
                lightUpperHead1.enabled = true;
                lightUpperHead2.enabled = true;
                lightUpperHead3.enabled = true;
                lightUpperHead4.enabled = true;
                break;
            case "Chest":
                
                lightChest.enabled = true;
                break;
            case "Belly":
                //mytext.text = text;
                mytext1.text = text1;
                lightBelly.enabled = true;
                break;
            case "Knees":
                
                lightKnee1.enabled = true;
                lightKnee2.enabled = true;
                break;
            case "Feet":
                lightFoot1.enabled = true;
                lightFoot2.enabled = true;
                break;
            case "LowerHead":
                lightLowerHead1.enabled = true;
                lightLowerHead2.enabled = true;
                lightLowerHead3.enabled = true;
                lightLowerHead4.enabled = true;
                break;
            case "UpperBack":
                lightUpperBack.enabled = true;
                break;
            case "Lower Back":
                lightLowerBack.enabled = true;
                break;
            case "LowerLeftLeg":
                lightLowerLeftLeg.enabled = true;
                break;
            case "UpperLeftLeg":
                lightUpperLeftLeg.enabled = true;
                break;
            case "LowerRightLeg":
                lightLowerRightLeg.enabled = true;
                break;
            case "UpperRightLeg":
                lightUpperRightLeg.enabled = true;
                break;
            case "Left Biceps":
                lightLeftBiceps.enabled = true;
                break;
            case "Left Forearms":
                lightLeftForearms.enabled = true;
                break;
            case "Right Biceps":
                lightRightBiceps.enabled = true;
                break;
            case "Right Forearms":
                lightRightForearms.enabled = true;
                break;

        }
        
    }

    public void closeAllLight() {

        lightUpperHead1.enabled = false;
        lightUpperHead2.enabled = false;
        lightUpperHead3.enabled = false;
        lightUpperHead4.enabled = false;
        lightChest.enabled = false;
        lightBelly.enabled = false;
        lightKnee1.enabled = false;
        lightKnee2.enabled = false;
        lightFoot1.enabled = false;
        lightFoot2.enabled = false;
        lightLowerHead1.enabled = false;
        lightLowerHead2.enabled = false;
        lightLowerHead3.enabled = false;
        lightLowerHead4.enabled = false;
        lightUpperBack.enabled = false;
        lightLowerBack.enabled = false;
        lightLowerLeftLeg.enabled = false;
        lightUpperLeftLeg.enabled = false;
        lightLowerRightLeg.enabled = false;
        lightUpperRightLeg.enabled = false;
        lightLeftBiceps.enabled = false;
        lightLeftForearms.enabled = false;
        lightRightBiceps.enabled = false;
        lightRightForearms.enabled = false;
    }
}
