using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part : MonoBehaviour
{
    public Text mytext, mytext1;
    // Use this for initialization
    void Start()
    {
        //headlight = GameObject.Find("Point Light head").GetComponent<Light>();


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onClick()
    {
        mytext.text = this.ToString();
        Debug.Log(mytext.text);
        mytext.text = mytext.text.Substring(0, mytext.text.Length - 7);
        Debug.Log(mytext.text);



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
            mytext.text = mytext.text + " / Tumbo";
            mytext1.text = "Stomach ache\nVomiting";
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
            mytext.text = mytext.text + " / Kichwa cha juu";
            mytext1.text = "Headache\nEarache\nHearing Loss\nNose Bleed\n";
        }
        else if (mytext.text.Equals("UpperBack"))
        {
            mytext.text = mytext.text + " / Nyuma ya nyuma";
            mytext1.text = "Symptom1\nSymptom2\nSymptom3\nSymptom4\nSymptom5\n";
        }
        else if (mytext.text.Equals("Chest"))
        {
            mytext.text = mytext.text + " / Kifua";
            mytext1.text = "Chest Pain\nHeart palpitations\nCough\nShortness of Breath";
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

}
