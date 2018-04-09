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

    public enum bodyPart {
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

    private string[,] translations = new string[language.GetNames(typeof(language)).Length, bodyPart.GetNames(typeof(bodyPart)).Length];

    // Use this for initialization
    void Start ()
    {
        //TODO Reduce amount of duplicate declaration. 
        translations[(int) language.English,      (int) bodyPart.UpperHead]         = "Upper Head";
        translations[(int) language.English,      (int) bodyPart.LowerHead]         = "Lower Head";
        translations[(int) language.English,      (int) bodyPart.UpperBack]         = "Upper Back";
        translations[(int) language.English,      (int) bodyPart.LowerBack]         = "Lower Back";
        translations[(int) language.English,      (int) bodyPart.Feet]              = "Feet";
        translations[(int) language.English,      (int) bodyPart.UpperRightLeg]     = "Upper Right Leg";
        translations[(int) language.English,      (int) bodyPart.LowerRightLeg]     = "Lower Right Leg";
        translations[(int) language.English,      (int) bodyPart.Knees]             = "Knees";
        translations[(int) language.English,      (int) bodyPart.UpperLeftLeg]      = "Upper Left Leg";
        translations[(int) language.English,      (int) bodyPart.LowerLeftLeg]      = "Lower Left Leg";
        translations[(int) language.English,      (int) bodyPart.Chest]             = "Chest";
        translations[(int) language.English,      (int) bodyPart.Belly]             = "Belly";
        translations[(int) language.English,      (int) bodyPart.LeftHandThumb]     = "Thumb (Left)";
        translations[(int) language.English,      (int) bodyPart.LeftHandIndex]     = "Index Finger (Left)";
        translations[(int) language.English,      (int) bodyPart.LeftHandMiddle]    = "Middle Finger (Left)";
        translations[(int) language.English,      (int) bodyPart.LeftHandRing]      = "Ring Finger (Left)";
        translations[(int) language.English,      (int) bodyPart.LeftHandPinky]     = "Pinky Finger (Left)";
        translations[(int) language.English,      (int) bodyPart.LeftHand]          = "Left Hand";
        translations[(int) language.English,      (int) bodyPart.LeftForearms]      = "Forearms (Left)";
        translations[(int) language.English,      (int) bodyPart.LeftBiceps]        = "Biceps (Left)";
        translations[(int) language.English,      (int) bodyPart.LeftTriceps]       = "Triceps (Left)";
        translations[(int) language.English,      (int) bodyPart.RightHandThumb]    = "Thumb (Right)";
        translations[(int) language.English,      (int) bodyPart.RightHandIndex]    = "Index Finger (Right)";
        translations[(int) language.English,      (int) bodyPart.RightHandMiddle]   = "Middle Finger (Right)";
        translations[(int) language.English,      (int) bodyPart.RightHandRing]     = "Ring Finger (Right)";
        translations[(int) language.English,      (int) bodyPart.RightHandPinky]    = "Pinky Finger (Right)";
        translations[(int) language.English,      (int) bodyPart.RightHand]         = "Right Hand";
        translations[(int) language.English,      (int) bodyPart.RightForearms]     = "Forearms (Right)";
        translations[(int) language.English,      (int) bodyPart.RightBiceps]       = "Biceps (Right)";
        translations[(int) language.English,      (int) bodyPart.RightTriceps]      = "Triceps (Right)";
        
        //TODO: Make sure translations are correct
        translations[(int) language.Swahili,      (int) bodyPart.UpperHead]         = "Kichwa cha juu";
        translations[(int) language.Swahili,      (int) bodyPart.LowerHead]         = "Shingo";
        translations[(int) language.Swahili,      (int) bodyPart.UpperBack]         = "Nyuma ya nyuma";
        translations[(int) language.Swahili,      (int) bodyPart.LowerBack]         = "Kurudi nyuma";
        translations[(int) language.Swahili,      (int) bodyPart.Feet]              = "Viganja";
        translations[(int) language.Swahili,      (int) bodyPart.UpperRightLeg]     = "Mguu";
        translations[(int) language.Swahili,      (int) bodyPart.LowerRightLeg]     = "Mguu";
        translations[(int) language.Swahili,      (int) bodyPart.Knees]             = "Magoti";
        translations[(int) language.Swahili,      (int) bodyPart.UpperLeftLeg]      = "Mguu";
        translations[(int) language.Swahili,      (int) bodyPart.LowerLeftLeg]      = "Mguu";
        translations[(int) language.Swahili,      (int) bodyPart.Chest]             = "Kifua";
        translations[(int) language.Swahili,      (int) bodyPart.Belly]             = "Tumbo";
        translations[(int) language.Swahili,      (int) bodyPart.LeftHandThumb]     = "Kidole gumba";
        translations[(int) language.Swahili,      (int) bodyPart.LeftHandIndex]     = "Kidole cha kwanza";
        translations[(int) language.Swahili,      (int) bodyPart.LeftHandMiddle]    = "Kidole cha kati";
        translations[(int) language.Swahili,      (int) bodyPart.LeftHandRing]      = "Pete kidole";
        translations[(int) language.Swahili,      (int) bodyPart.LeftHandPinky]     = "Kidole kidogo";
        translations[(int) language.Swahili,      (int) bodyPart.LeftHand]          = "";
        translations[(int) language.Swahili,      (int) bodyPart.LeftForearms]      = "Mikono";
        translations[(int) language.Swahili,      (int) bodyPart.LeftBiceps]        = "Mikono";
        translations[(int) language.Swahili,      (int) bodyPart.LeftTriceps]       = "";
        translations[(int) language.Swahili,      (int) bodyPart.RightHandThumb]    = "Kidole gumba";
        translations[(int) language.Swahili,      (int) bodyPart.RightHandIndex]    = "Kidole cha kwanza";
        translations[(int) language.Swahili,      (int) bodyPart.RightHandMiddle]   = "Kidole cha kati";
        translations[(int) language.Swahili,      (int) bodyPart.RightHandRing]     = "Pete Kidole";
        translations[(int) language.Swahili,      (int) bodyPart.RightHandPinky]    = "Kidole kidogo";
        translations[(int) language.Swahili,      (int) bodyPart.RightHand]         = "";
        translations[(int) language.Swahili,      (int) bodyPart.RightForearms]     = "Mikono";
        translations[(int) language.Swahili,      (int) bodyPart.RightBiceps]       = "Mikono";
        translations[(int) language.Swahili,      (int) bodyPart.RightTriceps]      = "";

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
        return translations[(int) currentLanguage, (int) part];
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
