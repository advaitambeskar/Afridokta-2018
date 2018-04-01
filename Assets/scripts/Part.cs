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
    public Light lightChest, lightBelly;
    // Use this for initialization
    void Start()
    {
        lightUpperHead1 = GameObject.Find("Point Light head (0)").GetComponent<Light>();
        lightUpperHead2 = GameObject.Find("Point Light head (1)").GetComponent<Light>();
        lightUpperHead3 = GameObject.Find("Point Light head (2)").GetComponent<Light>();
        lightUpperHead4 = GameObject.Find("Point Light head (3)").GetComponent<Light>();

        lightChest = GameObject.Find("Point Light Chest").GetComponent<Light>();
        lightBelly = GameObject.Find("Point Light Belly").GetComponent<Light>();
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
        mytext.text = String.Copy(this.ToString());
        string temp = String.Copy(mytext.text.Substring(0, mytext.text.Length - 7));
        mytext.text = String.Copy(temp);
        closeAllLight();
        GameObject.Find("Male").GetComponent<Public>().selectedPart = temp;
        this.selectedPart = GameObject.Find("Male").GetComponent<Public>().selectedPart;
        if (mytext.text.Equals("UpperRightLeg"))
        {
            mytext.text = mytext.text + " / Mguu";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }
        else if (mytext.text.Equals("Knees"))
        {
            mytext.text = mytext.text + " / Magoti";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }
        else if(mytext.text.Equals("UpperLeftLeg"))
        {
            mytext.text = mytext.text + " / Mguu";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }
        else if(mytext.text.Equals("Belly"))
        {
            lightBelly.enabled = true;
            mytext.text = mytext.text + " / Tumbo";
            mytext1.text = "Stomach ache\nVomiting";
            string temp1 = mytext.text;
            string temp2 = mytext1.text;
            GameObject.Find("Male").GetComponent<Public>().text = temp1;
            GameObject.Find("Male").GetComponent<Public>().text1 = temp2;
        }
        else if(mytext.text.Equals("LowerRightLeg"))
        {
            mytext.text = mytext.text + " / Mguu";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }
        else if (mytext.text.Equals("LowerHead"))
        {
            mytext.text = mytext.text + " / Shingo";
            mytext1.text = "Sore Throat\nVertigo\n";
        }
        else if (mytext.text.Equals("Lower Back"))
        {
            mytext.text = mytext.text + " / Kurudi nyuma";
            mytext1.text = "Back Ache";
        }
        else if (mytext.text.Equals("LowerLeftLeg"))
        {
            mytext.text = mytext.text + " / Mguu";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }
        else if (mytext.text.Equals("Feet"))
        {
            mytext.text = mytext.text + " / Viganja";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }
        else if (mytext.text.Equals("UpperHead"))
        {
            lightUpperHead1.enabled = true;
            lightUpperHead2.enabled = true;
            lightUpperHead3.enabled = true;
            lightUpperHead4.enabled = true;
            mytext.text = mytext.text + " / Kichwa cha juu";
            mytext1.text = "Headache\nEarache\nHearing Loss\nNose Bleed\n";
            string temp1 = mytext.text;
            string temp2 = mytext1.text;
            GameObject.Find("Male").GetComponent<Public>().text = temp1;
            GameObject.Find("Male").GetComponent<Public>().text1 = temp2;

        }
        else if (mytext.text.Equals("UpperBack"))
        {
            mytext.text = mytext.text + " / Nyuma ya nyuma";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }
        else if (mytext.text.Equals("Chest"))
        {
            lightChest.enabled = true;
            mytext.text = mytext.text + " / Kifua";
            mytext1.text = "Chest Pain\nHeart palpitations\nCough\nShortness of Breath";
            string temp1 = mytext.text;
            string temp2 = mytext1.text;
            GameObject.Find("Male").GetComponent<Public>().text = temp1;
            GameObject.Find("Male").GetComponent<Public>().text1 = temp2;
        }

        else if (mytext.text.Equals("Right Biceps"))
        {
            mytext.text = mytext.text + " / Mikono";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Right Forearms"))
        {
            mytext.text = mytext.text + " / Mikono";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Right Triceps"))
        {
            mytext.text = mytext.text;
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Right HandPinky"))
        {
            mytext.text = mytext.text + " / Kidole kidogo";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Right HandRing"))
        {
            mytext.text = mytext.text + " / Pete kidole";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Right HandMiddle"))
        {
            mytext.text = mytext.text + " / Kidole cha kati";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Right HandIndex"))
        {
            mytext.text = mytext.text + " / kidole cha kwanza";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Right HandThumb"))
        {
            mytext.text = mytext.text + " / Kidole gumba";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Left Biceps"))
        {
            mytext.text = mytext.text + " / Mikono";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Left Forearms"))
        {
            mytext.text = mytext.text + " / Mikono";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("Left Triceps"))
        {
            mytext.text = mytext.text;
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("LeftHandPinky"))
        {
            mytext.text = mytext.text + " / kidole kidogo";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("LeftHandring"))
        {
            mytext.text = mytext.text + " / pete kidole";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("LeftHandMiddle"))
        {
            mytext.text = mytext.text + " / kidole cha kati";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("LeftHandIndex"))
        {
            mytext.text = mytext.text + " / kidole cha kwanza";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }

        else if (mytext.text.Equals("LeftHandThumb"))
        {
            mytext.text = mytext.text + " / Kidole gumba";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }


    }

    public void onHover()
    {
        closeAllLight();
        mytext.text = this.ToString();
        mytext.text = mytext.text.Substring(0, mytext.text.Length - 7);
        this.selectedPart = GameObject.Find("Male").GetComponent<Public>().selectedPart;
        if (mytext.text.Equals("UpperRightLeg"))
        {
            mytext.text = mytext.text + " / Mguu";
            mytext1.text = "";
        }
        else if (mytext.text.Equals("Knees"))
        {
            mytext.text = mytext.text + " / Magoti";
            mytext1.text = "";
        }
        else if (mytext.text.Equals("UpperLeftLeg"))
        {
            mytext.text = mytext.text + " / Mguu";
            mytext1.text = "";
        }
        else if (mytext.text.Equals("Belly"))
        {
            lightBelly.enabled = true;
            mytext.text = mytext.text + " / Tumbo";
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
            mytext.text = mytext.text + " / Mguu";
            mytext1.text = "";
        }
        else if (mytext.text.Equals("LowerHead"))
        {
            mytext.text = mytext.text + " / Shingo";
            mytext1.text = "";
        }
        else if (mytext.text.Equals("Lower Back"))
        {
            mytext.text = mytext.text + " / Kurudi nyuma";
            mytext1.text = "";
        }
        else if (mytext.text.Equals("LowerLeftLeg"))
        {
            mytext.text = mytext.text + " / Mguu";
            mytext1.text = "";
        }
        else if (mytext.text.Equals("Feet"))
        {
            mytext.text = mytext.text + " / Viganja";
            mytext1.text = "";
        }
        else if (mytext.text.Equals("UpperHead"))
        {
            lightUpperHead1.enabled = true;
            lightUpperHead2.enabled = true;
            lightUpperHead3.enabled = true;
            lightUpperHead4.enabled = true;
            mytext.text = mytext.text + " / Kichwa cha juu";
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
            mytext.text = mytext.text + " / Nyuma ya nyuma";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Chest"))
        {
            lightChest.enabled = true;
            mytext.text = mytext.text + " / Kifua";
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
            mytext.text = mytext.text + " / Mikono";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Right Forearms"))
        {
            mytext.text = mytext.text + " / Mikono";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Right Triceps"))
        {
            mytext.text = mytext.text;
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Right HandPinky"))
        {
            mytext.text = mytext.text + " / Kidole kidogo";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Right HandRing"))
        {
            mytext.text = mytext.text + " / Pete kidole";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Right HandMiddle"))
        {
            mytext.text = mytext.text + " / Kidole cha kati";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Right HandIndex"))
        {
            mytext.text = mytext.text + " / kidole cha kwanza";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Right HandThumb"))
        {
            mytext.text = mytext.text + " / Kidole gumba";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Left Biceps"))
        {
            mytext.text = mytext.text + " / Mikono";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Left Forearms"))
        {
            mytext.text = mytext.text + " / Mikono";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("Left Triceps"))
        {
            mytext.text = mytext.text;
            mytext1.text = "";
        }

        else if (mytext.text.Equals("LeftHandPinky"))
        {
            mytext.text = mytext.text + " / kidole kidogo";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("LeftHandring"))
        {
            mytext.text = mytext.text + " / pete kidole";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("LeftHandMiddle"))
        {
            mytext.text = mytext.text + " / kidole cha kati";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("LeftHandIndex"))
        {
            mytext.text = mytext.text + " / kidole cha kwanza";
            mytext1.text = "";
        }

        else if (mytext.text.Equals("LeftHandThumb"))
        {
            mytext.text = mytext.text + " / Kidole gumba";
            mytext1.text = "";
        }


    }

    public void leaveHover() {
        closeAllLight();
        mytext.text = "";
        mytext1.text = "";
        Debug.Log(this.selectedPart);
        text = GameObject.Find("Male").GetComponent<Public>().text;
        text1 = GameObject.Find("Male").GetComponent<Public>().text1;
        switch (selectedPart) {
            case "UpperHead":
                mytext.text = text;
                mytext1.text = text1;
                lightUpperHead1.enabled = true;
                lightUpperHead2.enabled = true;
                lightUpperHead3.enabled = true;
                lightUpperHead4.enabled = true;
                break;
            case "Chest":
                mytext.text = text;
                mytext1.text = text1;
                lightChest.enabled = true;
                break;
            case "Belly":
                mytext.text = text;
                mytext1.text = text1;
                lightBelly.enabled = true;
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
    }
}
