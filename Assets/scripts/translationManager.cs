using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum language
{
    English,
    Swahili,
    Afrikans,
    French
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
    YellowingOfEyes,
    Cough,
    ShortOfBreath,
    Chills,
    Sweating
}

public class translationManager : MonoBehaviour {
    public language currentLanguage;


    private string[,] bodyTranslations = new string[language.GetNames(typeof(language)).Length, bodyPart.GetNames(typeof(bodyPart)).Length];
    private string[,] symptomTrans = new string[language.GetNames(typeof(language)).Length, symptom.GetNames(typeof(symptom)).Length];
    private string[] bodyTemp = new string[bodyPart.GetName(typeof(bodyPart)).Length];
    private string[] symTemp = new string[symptom.GetName(typeof(symptom)).Length];

    // Use this for initialization
    void Start ()
    {
        //English Body Part Translations
        bodyTemp[(int) bodyPart.UpperHead]         = "Upper Head";
        bodyTemp[(int) bodyPart.LowerHead]         = "Lower Head";
        bodyTemp[(int) bodyPart.UpperBack]         = "Upper Back";
        bodyTemp[(int) bodyPart.LowerBack]         = "Lower Back";
        bodyTemp[(int) bodyPart.Feet]              = "Feet";
        bodyTemp[(int) bodyPart.UpperRightLeg]     = "Upper Right Leg";
        bodyTemp[(int) bodyPart.LowerRightLeg]     = "Lower Right Leg";
        bodyTemp[(int) bodyPart.Knees]             = "Knees";
        bodyTemp[(int) bodyPart.UpperLeftLeg]      = "Upper Left Leg";
        bodyTemp[(int) bodyPart.LowerLeftLeg]      = "Lower Left Leg";
        bodyTemp[(int) bodyPart.Chest]             = "Chest";
        bodyTemp[(int) bodyPart.Belly]             = "Belly";
        bodyTemp[(int) bodyPart.LeftHandThumb]     = "Thumb (Left)";
        bodyTemp[(int) bodyPart.LeftHandIndex]     = "Index Finger (Left)";
        bodyTemp[(int) bodyPart.LeftHandMiddle]    = "Middle Finger (Left)";
        bodyTemp[(int) bodyPart.LeftHandRing]      = "Ring Finger (Left)";
        bodyTemp[(int) bodyPart.LeftHandPinky]     = "Pinky Finger (Left)";
        bodyTemp[(int) bodyPart.LeftHand]          = "Left Hand";
        bodyTemp[(int) bodyPart.LeftForearms]      = "Forearms (Left)";
        bodyTemp[(int) bodyPart.LeftBiceps]        = "Biceps (Left)";
        bodyTemp[(int) bodyPart.LeftTriceps]       = "Triceps (Left)";
        bodyTemp[(int) bodyPart.RightHandThumb]    = "Thumb (Right)";
        bodyTemp[(int) bodyPart.RightHandIndex]    = "Index Finger (Right)";
        bodyTemp[(int) bodyPart.RightHandMiddle]   = "Middle Finger (Right)";
        bodyTemp[(int) bodyPart.RightHandRing]     = "Ring Finger (Right)";
        bodyTemp[(int) bodyPart.RightHandPinky]    = "Pinky Finger (Right)";
        bodyTemp[(int) bodyPart.RightHand]         = "Right Hand";
        bodyTemp[(int) bodyPart.RightForearms]     = "Forearms (Right)";
        bodyTemp[(int) bodyPart.RightBiceps]       = "Biceps (Right)";
        bodyTemp[(int) bodyPart.RightTriceps]      = "Triceps (Right)";

        bodyTranslations[(int)language.English] = bodyTemp;
        
        //English Symptom Translations
        symTemp[(int) symptom.Pain]            = "Pain";
        symTemp[(int) symptom.Swelling]        = "Swelling";
        symTemp[(int) symptom.Weakness]        = "Weakness";
        symTemp[(int) symptom.Redness]         = "Redness";
        symTemp[(int) symptom.Itching]         = "Itching";
        symTemp[(int) symptom.Other]           = "Other";
        symTemp[(int) symptom.Diarrhea]        = "Diarrhea";
        symTemp[(int) symptom.Constipation]    = "Constipation";
        symTemp[(int) symptom.LossOfAppetite]  = "Loss of Appetite";
        symTemp[(int) symptom.WeightLoss]      = "Weight Loss";
        symTemp[(int) symptom.Vomiting]        = "Vomiting";
        symTemp[(int) symptom.BleedingGums]    = "Bleeding Gums";
        symTemp[(int) symptom.DryMouth]        = "Dry Mouth";
        symTemp[(int) symptom.StiffNeck]       = "Stiff Neck";
        symTemp[(int) symptom.Thirsty]         = "Thirsty";
        symTemp[(int) symptom.Headache]        = "Headache";
        symTemp[(int) symptom.Dizziness]       = "Dizziness";
        symTemp[(int) symptom.EyePain]         = "Eye Pain";
        symTemp[(int) symptom.Fever]           = "Fever";
        symTemp[(int) symptom.YellowingOfEyes] = "Yellowing of Eyes";
        symTemp[(int) symptom.Cough]           = "Cough";
        symTemp[(int) symptom.ShortOfBreath]   = "Short of Breath";
        symTemp[(int) symptom.Chills]          = "Chills";
        symTemp[(int) symptom.Sweating]        = "Sweating";

        symptomTrans[(int)language.English] = symTemp;
        
        //Swahili Body Part Translations
        //TODO: Make sure translations are correct
        bodyTemp[(int) bodyPart.UpperHead]         = "Kichwa cha juu";
        bodyTemp[(int) bodyPart.LowerHead]         = "Shingo";
        bodyTemp[(int) bodyPart.UpperBack]         = "Nyuma ya nyuma";
        bodyTemp[(int) bodyPart.LowerBack]         = "Kurudi nyuma";
        bodyTemp[(int) bodyPart.Feet]              = "Viganja";
        bodyTemp[(int) bodyPart.UpperRightLeg]     = "Mguu";
        bodyTemp[(int) bodyPart.LowerRightLeg]     = "Mguu";
        bodyTemp[(int) bodyPart.Knees]             = "Magoti";
        bodyTemp[(int) bodyPart.UpperLeftLeg]      = "Mguu";
        bodyTemp[(int) bodyPart.LowerLeftLeg]      = "Mguu";
        bodyTemp[(int) bodyPart.Chest]             = "Kifua";
        bodyTemp[(int) bodyPart.Belly]             = "Tumbo";
        bodyTemp[(int) bodyPart.LeftHandThumb]     = "Kidole gumba";
        bodyTemp[(int) bodyPart.LeftHandIndex]     = "Kidole cha kwanza";
        bodyTemp[(int) bodyPart.LeftHandMiddle]    = "Kidole cha kati";
        bodyTemp[(int) bodyPart.LeftHandRing]      = "Pete kidole";
        bodyTemp[(int) bodyPart.LeftHandPinky]     = "Kidole kidogo";
        bodyTemp[(int) bodyPart.LeftHand]          = "";
        bodyTemp[(int) bodyPart.LeftForearms]      = "Mikono";
        bodyTemp[(int) bodyPart.LeftBiceps]        = "Mikono";
        bodyTemp[(int) bodyPart.LeftTriceps]       = "";
        bodyTemp[(int) bodyPart.RightHandThumb]    = "Kidole gumba";
        bodyTemp[(int) bodyPart.RightHandIndex]    = "Kidole cha kwanza";
        bodyTemp[(int) bodyPart.RightHandMiddle]   = "Kidole cha kati";
        bodyTemp[(int) bodyPart.RightHandRing]     = "Pete Kidole";
        bodyTemp[(int) bodyPart.RightHandPinky]    = "Kidole kidogo";
        bodyTemp[(int) bodyPart.RightHand]         = "";
        bodyTemp[(int) bodyPart.RightForearms]     = "Mikono";
        bodyTemp[(int) bodyPart.RightBiceps]       = "Mikono";
        bodyTemp[(int) bodyPart.RightTriceps]      = "";

        bodyTranslations[(int)language.Swahili] = bodyTemp;

        //Swahili Symptom Translations
        //TODO: Make sure translations are correct
        symTemp[(int) symptom.Pain]            = "Maumivu";
        symTemp[(int) symptom.Swelling]        = "Kuvimba";
        symTemp[(int) symptom.Weakness]        = "Ukosefu";
        symTemp[(int) symptom.Redness]         = "Ukombozi";
        symTemp[(int) symptom.Itching]         = "Kuvuta";
        symTemp[(int) symptom.Other]           = "Nyingine";
        symTemp[(int) symptom.Diarrhea]        = "Kuhara";
        symTemp[(int) symptom.Constipation]    = "Kudumu";
        symTemp[(int) symptom.LossOfAppetite]  = "Kupoteza hamu ya kula";
        symTemp[(int) symptom.WeightLoss]      = "Kupungua uzito";
        symTemp[(int) symptom.Vomiting]        = "Kupiga kura";
        symTemp[(int) symptom.BleedingGums]    = "Utumbo wa kuvuta";
        symTemp[(int) symptom.DryMouth]        = "Mkavu Kavu";
        symTemp[(int) symptom.StiffNeck]       = "Shingo Ngumu";
        symTemp[(int) symptom.Thirsty]         = "Kiu";
        symTemp[(int) symptom.Headache]        = "Kichwa cha kichwa";
        symTemp[(int) symptom.Dizziness]       = "Kizunguzungu";
        symTemp[(int) symptom.EyePain]         = "Maumivu ya Jicho";
        symTemp[(int) symptom.Fever]           = "Homa";
        symTemp[(int) symptom.YellowingOfEyes] = "Kupalika kwa Macho";
        symTemp[(int) symptom.Cough]           = "Kukata";
        symTemp[(int) symptom.ShortOfBreath]   = "Pumzi fupi";
        symTemp[(int) symptom.Chills]          = "Kukua";
        symTemp[(int) symptom.Sweating]        = "Kutapika";

        symptomTrans[(int)language.Swahili] = symTemp;
        
        //Afrikans Body Part Translations
        //TODO: Make sure translations are correct
        bodyTemp[(int) bodyPart.UpperHead]         = "Boonkop";
        bodyTemp[(int) bodyPart.LowerHead]         = "Onderkop";
        bodyTemp[(int) bodyPart.UpperBack]         = "Boonste rug";
        bodyTemp[(int) bodyPart.LowerBack]         = "Laerug";
        bodyTemp[(int) bodyPart.Feet]              = "Voete";
        bodyTemp[(int) bodyPart.UpperRightLeg]     = "Boonste regterbeen";
        bodyTemp[(int) bodyPart.LowerRightLeg]     = "onderste regterbeen";
        bodyTemp[(int) bodyPart.Knees]             = "knieë";
        bodyTemp[(int) bodyPart.UpperLeftLeg]      = "";
        bodyTemp[(int) bodyPart.LowerLeftLeg]      = "";
        bodyTemp[(int) bodyPart.Chest]             = "";
        bodyTemp[(int) bodyPart.Belly]             = "";
        bodyTemp[(int) bodyPart.LeftHandThumb]     = "";
        bodyTemp[(int) bodyPart.LeftHandIndex]     = "";
        bodyTemp[(int) bodyPart.LeftHandMiddle]    = "";
        bodyTemp[(int) bodyPart.LeftHandRing]      = "";
        bodyTemp[(int) bodyPart.LeftHandPinky]     = "";
        bodyTemp[(int) bodyPart.LeftHand]          = "";
        bodyTemp[(int) bodyPart.LeftForearms]      = "";
        bodyTemp[(int) bodyPart.LeftBiceps]        = "";
        bodyTemp[(int) bodyPart.LeftTriceps]       = "";
        bodyTemp[(int) bodyPart.RightHandThumb]    = "";
        bodyTemp[(int) bodyPart.RightHandIndex]    = "";
        bodyTemp[(int) bodyPart.RightHandMiddle]   = "";
        bodyTemp[(int) bodyPart.RightHandRing]     = "";
        bodyTemp[(int) bodyPart.RightHandPinky]    = "";
        bodyTemp[(int) bodyPart.RightHand]         = "";
        bodyTemp[(int) bodyPart.RightForearms]     = "";
        bodyTemp[(int) bodyPart.RightBiceps]       = "";
        bodyTemp[(int) bodyPart.RightTriceps]      = "";

        bodyTranslations[(int)language.Afrikans] = bodyTemp;

        //Afrikans Symptom Translations
        //TODO: Make sure translations are correct
        symTemp[(int) symptom.Pain]            = "";
        symTemp[(int) symptom.Swelling]        = "";
        symTemp[(int) symptom.Weakness]        = "";
        symTemp[(int) symptom.Redness]         = "";
        symTemp[(int) symptom.Itching]         = "";
        symTemp[(int) symptom.Other]           = "";
        symTemp[(int) symptom.Diarrhea]        = "";
        symTemp[(int) symptom.Constipation]    = "";
        symTemp[(int) symptom.LossOfAppetite]  = "";
        symTemp[(int) symptom.WeightLoss]      = "";
        symTemp[(int) symptom.Vomiting]        = "";
        symTemp[(int) symptom.BleedingGums]    = "";
        symTemp[(int) symptom.DryMouth]        = "";
        symTemp[(int) symptom.StiffNeck]       = "";
        symTemp[(int) symptom.Thirsty]         = "";
        symTemp[(int) symptom.Headache]        = "";
        symTemp[(int) symptom.Dizziness]       = "";
        symTemp[(int) symptom.EyePain]         = "";
        symTemp[(int) symptom.Fever]           = "";
        symTemp[(int) symptom.YellowingOfEyes] = "";
        symTemp[(int) symptom.Cough]           = "";
        symTemp[(int) symptom.ShortOfBreath]   = "";
        symTemp[(int) symptom.Chills]          = "";
        symTemp[(int) symptom.Sweating]        = "";

        symptomTrans[(int)language.Afrikans] = symTemp;
        
        //French Body Part Translations
        //TODO: Make sure translations are correct
        bodyTemp[(int) bodyPart.UpperHead]         = "";
        bodyTemp[(int) bodyPart.LowerHead]         = "";
        bodyTemp[(int) bodyPart.UpperBack]         = "";
        bodyTemp[(int) bodyPart.LowerBack]         = "";
        bodyTemp[(int) bodyPart.Feet]              = "";
        bodyTemp[(int) bodyPart.UpperRightLeg]     = "";
        bodyTemp[(int) bodyPart.LowerRightLeg]     = "";
        bodyTemp[(int) bodyPart.Knees]             = "";
        bodyTemp[(int) bodyPart.UpperLeftLeg]      = "";
        bodyTemp[(int) bodyPart.LowerLeftLeg]      = "";
        bodyTemp[(int) bodyPart.Chest]             = "";
        bodyTemp[(int) bodyPart.Belly]             = "";
        bodyTemp[(int) bodyPart.LeftHandThumb]     = "";
        bodyTemp[(int) bodyPart.LeftHandIndex]     = "";
        bodyTemp[(int) bodyPart.LeftHandMiddle]    = "";
        bodyTemp[(int) bodyPart.LeftHandRing]      = "";
        bodyTemp[(int) bodyPart.LeftHandPinky]     = "";
        bodyTemp[(int) bodyPart.LeftHand]          = "";
        bodyTemp[(int) bodyPart.LeftForearms]      = "";
        bodyTemp[(int) bodyPart.LeftBiceps]        = "";
        bodyTemp[(int) bodyPart.LeftTriceps]       = "";
        bodyTemp[(int) bodyPart.RightHandThumb]    = "";
        bodyTemp[(int) bodyPart.RightHandIndex]    = "";
        bodyTemp[(int) bodyPart.RightHandMiddle]   = "";
        bodyTemp[(int) bodyPart.RightHandRing]     = "";
        bodyTemp[(int) bodyPart.RightHandPinky]    = "";
        bodyTemp[(int) bodyPart.RightHand]         = "";
        bodyTemp[(int) bodyPart.RightForearms]     = "";
        bodyTemp[(int) bodyPart.RightBiceps]       = "";
        bodyTemp[(int) bodyPart.RightTriceps]      = "";

        bodyTranslations[(int)language.French] = bodyTemp;

        //French Symptom Translations
        //TODO: Make sure translations are correct
        symTemp[(int) symptom.Pain]            = "";
        symTemp[(int) symptom.Swelling]        = "";
        symTemp[(int) symptom.Weakness]        = "";
        symTemp[(int) symptom.Redness]         = "";
        symTemp[(int) symptom.Itching]         = "";
        symTemp[(int) symptom.Other]           = "";
        symTemp[(int) symptom.Diarrhea]        = "";
        symTemp[(int) symptom.Constipation]    = "";
        symTemp[(int) symptom.LossOfAppetite]  = "";
        symTemp[(int) symptom.WeightLoss]      = "";
        symTemp[(int) symptom.Vomiting]        = "";
        symTemp[(int) symptom.BleedingGums]    = "";
        symTemp[(int) symptom.DryMouth]        = "";
        symTemp[(int) symptom.StiffNeck]       = "";
        symTemp[(int) symptom.Thirsty]         = "";
        symTemp[(int) symptom.Headache]        = "";
        symTemp[(int) symptom.Dizziness]       = "";
        symTemp[(int) symptom.EyePain]         = "";
        symTemp[(int) symptom.Fever]           = "";
        symTemp[(int) symptom.YellowingOfEyes] = "";
        symTemp[(int) symptom.Cough]           = "";
        symTemp[(int) symptom.ShortOfBreath]   = "";
        symTemp[(int) symptom.Chills]          = "";
        symTemp[(int) symptom.Sweating]        = "";

        symptomTrans[(int)language.French] = symTemp;

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
                Debug.Log("Error Name does not match any cases: " + bodyTempName);
                return bodyPart.UpperHead;
                break;
        }
    }

}
