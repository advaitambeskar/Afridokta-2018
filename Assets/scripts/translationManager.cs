using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translationManager : MonoBehaviour {
    public language currentLanguage;

    public enum language
    {
        English,
        Swahili
    }

    public enum bodyPart
    {
        UpperHead,
        LowerHead,
        UpperBack,
        LowerBack,
        Feet,
        UpperRightLeg,
        LowerRightLeg,
        Knees,
        LowerLeftLeg,
        UpperLeftLeg,
        Chest,
        Belly,
        LeftHandThumb,
        LeftHandIndex,
        LeftHandMiddle,
        LeftHandRing,
        LeftHandPinky,
        LeftTriceps,
        LeftForearms,
        LeftBiceps,
        LeftHand,
        RightHandThumb,
        RightHandIndex,
        RightHandMiddle,
        RightHandRing,
        RightHandPinky,
        RightTriceps,
        RightForearms,
        RightBiceps,
        RightHand
    }

    public enum symptom
    {
        Pain,
        Swelling,
        Weakness,
        Redness,
        Itching,
        Other,
        Diarrhea,
        Constipation,
        LossOfAppetite,
        WeightLoss,
        Vomiting,
        BleedingGums,
        DryMouth,
        StiffNeck,
        Thirsty,
        Headache,
        Dizziness,
        EyePain,
        Fever,
        YellowingOfEyes
    }

    private string[,] bodyTranslations = new string[language.GetNames(typeof(language)).Length, bodyPart.GetNames(typeof(bodyPart)).Length];
    private string[,] symptomTrans = new string[language.GetNames(typeof(language)).Length, symptom.GetNames(typeof(symptom)).Length];

    // Use this for initialization
    void Start ()
    {
        //TODO Reduce amount of duplicate declaration. 
        bodyTranslations[(int) language.English,      (int) bodyPart.UpperHead]         = "Upper Head";
        bodyTranslations[(int) language.English,      (int) bodyPart.LowerHead]         = "Lower Head";
        bodyTranslations[(int) language.English,      (int) bodyPart.UpperBack]         = "Upper Back";
        bodyTranslations[(int) language.English,      (int) bodyPart.LowerBack]         = "Lower Back";
        bodyTranslations[(int) language.English,      (int) bodyPart.Feet]              = "Feet";
        bodyTranslations[(int) language.English,      (int) bodyPart.UpperRightLeg]     = "Upper Right Leg";
        bodyTranslations[(int) language.English,      (int) bodyPart.LowerRightLeg]     = "Lower Right Leg";
        bodyTranslations[(int) language.English,      (int) bodyPart.Knees]             = "Knees";
        bodyTranslations[(int) language.English,      (int) bodyPart.UpperLeftLeg]      = "Upper Left Leg";
        bodyTranslations[(int) language.English,      (int) bodyPart.LowerLeftLeg]      = "Lower Left Leg";
        bodyTranslations[(int) language.English,      (int) bodyPart.Chest]             = "Chest";
        bodyTranslations[(int) language.English,      (int) bodyPart.Belly]             = "Belly";
        bodyTranslations[(int) language.English,      (int) bodyPart.LeftHandThumb]     = "Thumb (Left)";
        bodyTranslations[(int) language.English,      (int) bodyPart.LeftHandIndex]     = "Index Finger (Left)";
        bodyTranslations[(int) language.English,      (int) bodyPart.LeftHandMiddle]    = "Middle Finger (Left)";
        bodyTranslations[(int) language.English,      (int) bodyPart.LeftHandRing]      = "Ring Finger (Left)";
        bodyTranslations[(int) language.English,      (int) bodyPart.LeftHandPinky]     = "Pinky Finger (Left)";
        bodyTranslations[(int) language.English,      (int) bodyPart.LeftHand]          = "Left Hand";
        bodyTranslations[(int) language.English,      (int) bodyPart.LeftForearms]      = "Forearms (Left)";
        bodyTranslations[(int) language.English,      (int) bodyPart.LeftBiceps]        = "Biceps (Left)";
        bodyTranslations[(int) language.English,      (int) bodyPart.LeftTriceps]       = "Triceps (Left)";
        bodyTranslations[(int) language.English,      (int) bodyPart.RightHandThumb]    = "Thumb (Right)";
        bodyTranslations[(int) language.English,      (int) bodyPart.RightHandIndex]    = "Index Finger (Right)";
        bodyTranslations[(int) language.English,      (int) bodyPart.RightHandMiddle]   = "Middle Finger (Right)";
        bodyTranslations[(int) language.English,      (int) bodyPart.RightHandRing]     = "Ring Finger (Right)";
        bodyTranslations[(int) language.English,      (int) bodyPart.RightHandPinky]    = "Pinky Finger (Right)";
        bodyTranslations[(int) language.English,      (int) bodyPart.RightHand]         = "Right Hand";
        bodyTranslations[(int) language.English,      (int) bodyPart.RightForearms]     = "Forearms (Right)";
        bodyTranslations[(int) language.English,      (int) bodyPart.RightBiceps]       = "Biceps (Right)";
        bodyTranslations[(int) language.English,      (int) bodyPart.RightTriceps]      = "Triceps (Right)";

        //TODO: Make sure translations are correct
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.UpperHead]         = "Kichwa cha juu";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.LowerHead]         = "Shingo";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.UpperBack]         = "Nyuma ya nyuma";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.LowerBack]         = "Kurudi nyuma";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.Feet]              = "Viganja";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.UpperRightLeg]     = "Mguu";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.LowerRightLeg]     = "Mguu";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.Knees]             = "Magoti";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.UpperLeftLeg]      = "Mguu";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.LowerLeftLeg]      = "Mguu";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.Chest]             = "Kifua";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.Belly]             = "Tumbo";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.LeftHandThumb]     = "Kidole gumba";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.LeftHandIndex]     = "Kidole cha kwanza";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.LeftHandMiddle]    = "Kidole cha kati";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.LeftHandRing]      = "Pete kidole";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.LeftHandPinky]     = "Kidole kidogo";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.LeftHand]          = "";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.LeftForearms]      = "Mikono";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.LeftBiceps]        = "Mikono";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.LeftTriceps]       = "";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.RightHandThumb]    = "Kidole gumba";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.RightHandIndex]    = "Kidole cha kwanza";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.RightHandMiddle]   = "Kidole cha kati";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.RightHandRing]     = "Pete Kidole";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.RightHandPinky]    = "Kidole kidogo";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.RightHand]         = "";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.RightForearms]     = "Mikono";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.RightBiceps]       = "Mikono";
        bodyTranslations[(int) language.Swahili,      (int) bodyPart.RightTriceps]      = "";
        
        //English Symptom Translations
        symptomTrans[(int) language.English,      (int) symptom.Pain]            = "Pain";
        symptomTrans[(int) language.English,      (int) symptom.Swelling]        = "Swelling";
        symptomTrans[(int) language.English,      (int) symptom.Redness]         = "Redness";
        symptomTrans[(int) language.English,      (int) symptom.Itching]         = "Itching";
        symptomTrans[(int) language.English,      (int) symptom.Other]           = "Other";
        symptomTrans[(int) language.English,      (int) symptom.Diarrhea]        = "Diarrhea";
        symptomTrans[(int) language.English,      (int) symptom.Constipation]    = "Constipation";
        symptomTrans[(int) language.English,      (int) symptom.LossOfAppetite]  = "Loss of Appetite";
        symptomTrans[(int) language.English,      (int) symptom.WeightLoss]      = "Weight Loss";
        symptomTrans[(int) language.English,      (int) symptom.Vomiting]        = "Vomiting";
        symptomTrans[(int) language.English,      (int) symptom.BleedingGums]    = "Bleeding Gums";
        symptomTrans[(int) language.English,      (int) symptom.DryMouth]        = "Dry Mouth";
        symptomTrans[(int) language.English,      (int) symptom.StiffNeck]       = "Stiff Neck";
        symptomTrans[(int) language.English,      (int) symptom.Thirsty]         = "Thirsty";
        symptomTrans[(int) language.English,      (int) symptom.Headache]        = "Headache";
        symptomTrans[(int) language.English,      (int) symptom.Dizziness]       = "Dizziness";
        symptomTrans[(int) language.English,      (int) symptom.EyePain]         = "Eye Pain";
        symptomTrans[(int) language.English,      (int) symptom.Fever]           = "Fever";
        symptomTrans[(int) language.English,      (int) symptom.YellowingOfEyes] = "Yellowing of Eyes";
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setLanguage(language language)
    {
        currentLanguage = language;
    }

    public string getName(bodyPart part)
    {
        //TODO: Check for missing translation
        return bodyTranslations[(int) currentLanguage, (int) part];
    }

    public string getName(symptom part)
    {
        //TODO: Check for missing translation
        return symptomTrans[(int)currentLanguage, (int)part];
    }
    
    public string getName(string part)
    {
        return getName(getIdentifier(part));
    }

    public string getName(GameObject part)
    {
        return getName(getIdentifier(part));
    }

    public bodyPart getIdentifier(GameObject part)
    {
        return getIdentifier(part.ToString());
    }

    public bodyPart getIdentifier(string name)
    {
        //Name of body part gameObject
        string tempName = name.Substring(0, name.Length - 25); //Remove (UnityEngine.GameObject)
        switch (tempName)
        {
            case "UpperHead":
                return bodyPart.UpperHead;
                break;
            case "LowerHead":
                return bodyPart.LowerHead;
                break;
            case "UpperBack":
                return bodyPart.UpperBack;
                break;
            case "Lower Back":
                return bodyPart.LowerBack;
                break;
            case "Feet":
                return bodyPart.Feet;
                break;
            case "UpperRightLeg":
                return bodyPart.UpperRightLeg;
                break;
            case "LowerRightLeg":
                return bodyPart.LowerRightLeg;
                break;
            case "Knees":
                return bodyPart.Knees;
                break;
            case "UpperLeftLeg":
                return bodyPart.UpperLeftLeg;
                break;
            case "LowerLeftLeg":
                return bodyPart.LowerLeftLeg;
                break;
            case "Chest":
                return bodyPart.Chest;
                break;
            case "Belly":
                return bodyPart.Belly;
                break;
            case "LeftHandThumb":
                return bodyPart.LeftHandThumb;
                break;
            case "LeftHandIndex":
                return bodyPart.LeftHandIndex;
                break;
            case "LeftHandMiddle":
                return bodyPart.LeftHandMiddle;
                break;
            case "LeftHandRing":
                return bodyPart.LeftHandRing;
                break;
            case "LeftHandPinky":
                return bodyPart.LeftHandPinky;
                break;
            case "Left Triceps":
                return bodyPart.LeftTriceps;
                break;
            case "Left Forearms":
                return bodyPart.LeftForearms;
                break;
            case "Left Biceps":
                return bodyPart.LeftBiceps;
                break;
            case "LeftHandMale":
                return bodyPart.LeftHand;
                break;
            case "Right HandThumb":
                return bodyPart.RightHandThumb;
                break;
            case "Right HandIndex":
                return bodyPart.RightHandIndex;
                break;
            case "Right HandMiddle":
                return bodyPart.RightHandMiddle;
                break;
            case "Right HandRing":
                return bodyPart.RightHandRing;
                break;
            case "Right HandPinky":
                return bodyPart.RightHandPinky;
                break;
            case "RightHandMale":
                return bodyPart.RightHand;
                break;
            case "Right Triceps":
                return bodyPart.RightTriceps;
                break;
            case "Right Forearms":
                return bodyPart.RightForearms;
                break;
            case "Right Biceps":
                return bodyPart.RightBiceps;
                break;
        default:
                Debug.Log("Error Name does not match any cases: " + tempName);
                return bodyPart.UpperHead;
                break;
        }
    }

}
