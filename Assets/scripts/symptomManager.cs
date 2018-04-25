using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class symptomManager : MonoBehaviour
{
    string selectedPart;
    bodyPart currentPart;
    public Text mytext, mytext1;

    public textbox textManager;
	public Transform SymptomCanvas;
    public translationManager tManag;
	public Dictionary<bodyPart, List<symptom>> symptomsDictionary;
    public List<symptom> defaultSymptoms;

    private string[,] bodyTranslations = new string[language.GetNames(typeof(language)).Length, bodyPart.GetNames(typeof(bodyPart)).Length];
    public Dictionary<bodyPart, List<Boolean>> symptomToggles;

    // Use this for initialization
    void Start()
    {
		tManag = GameObject.Find("GvrEventSystem").GetComponent<translationManager>();
        textManager = GameObject.Find("LeftBodyPart").GetComponent<textbox>();

        selectedPart = "";

        symptomToggles = new Dictionary<bodyPart, List<Boolean>>() { };

        defaultSymptoms = new List<symptom> { symptom.Pain, symptom.Swelling, symptom.Weakness, symptom.Redness, symptom.Itching, symptom.Other };
        symptomsDictionary = new Dictionary<bodyPart, List<symptom>>()
        {
            {bodyPart.UpperRightLeg, defaultSymptoms},
            {bodyPart.Knees, defaultSymptoms},
            {bodyPart.UpperLeftLeg, defaultSymptoms},
            {bodyPart.Belly, new List<symptom> {symptom.Diarrhea, symptom.Constipation, symptom.LossOfAppetite, symptom.Swelling, symptom.WeightLoss, symptom.Other}},
            {bodyPart.LowerRightLeg, defaultSymptoms},
            {bodyPart.LowerHead, new List<symptom> {symptom.Vomiting, symptom.BleedingGums, symptom.DryMouth, symptom.StiffNeck, symptom.Thirsty, symptom.Other}},
            {bodyPart.LowerBack,  defaultSymptoms},
            {bodyPart.LowerLeftLeg, defaultSymptoms},
            {bodyPart.Feet, defaultSymptoms},
            {bodyPart.UpperHead, new List<symptom> {symptom.Headache, symptom.Dizziness, symptom.EyePain, symptom.Fever, symptom.YellowingOfEyes, symptom.Other}},
            {bodyPart.UpperBack, defaultSymptoms},
            {bodyPart.Chest, new List<symptom> {symptom.Cough, symptom.ShortOfBreath, symptom.Chills, symptom.Sweating, symptom.Pain, symptom.Other}},
            {bodyPart.RightBiceps, defaultSymptoms},
            {bodyPart.RightForearms, defaultSymptoms},
            {bodyPart.RightTriceps, defaultSymptoms},
            {bodyPart.RightHandPinky, defaultSymptoms},
            {bodyPart.RightHandRing, defaultSymptoms},
            {bodyPart.RightHandMiddle, defaultSymptoms},
            {bodyPart.RightHandIndex, defaultSymptoms},
            {bodyPart.RightHandThumb, defaultSymptoms},
            {bodyPart.LeftBiceps, defaultSymptoms},
            {bodyPart.LeftForearms, defaultSymptoms},
            {bodyPart.LeftTriceps, defaultSymptoms},
            {bodyPart.LeftHandPinky, defaultSymptoms},
            {bodyPart.LeftHandRing, defaultSymptoms},
            {bodyPart.LeftHandMiddle, defaultSymptoms},
            {bodyPart.LeftHandIndex, defaultSymptoms},
            {bodyPart.LeftHandThumb, defaultSymptoms},
        };

    }

    // Update is called once per frame
    void Update()
    {

    }

    // Update symptomBox
    void refresh()
    {

    }

    public void setPart(GameObject part)
    {
        setPart(tManag.getIdentifier(part));
    }

    public void setPart(bodyPart part)
    {
        currentPart = part;
        createList();
    }

    public void toggleSymptom(symptom sym)
    {
        //Toggle symptom in symptom list


        //Add to preview window
        textManager.add(currentPart, sym);
    }

    public void createList()
    {
        //Populate symptom canvas with the symptoms
		SymptomCanvas = GameObject.FindGameObjectWithTag ("SympCanvas").GetComponent<Transform>();
		List<symptom> tempList = new List<symptom> ();
		List<Boolean> boolList = new List<Boolean> ();
		if (symptomsDictionary.TryGetValue (currentPart, out tempList)) { 
			for (int i = 0; i < tempList.Count; i++) {
				GameObject newToggle = GameObject.Instantiate(Resources.Load("SymptomToggle")) as GameObject;
				newToggle.transform.position = new Vector3 (0f, (i * -0.2f) + 0.5f, 0f);
				newToggle.transform.SetParent(SymptomCanvas.transform, false);
				newToggle.transform.Find ("Label").GetComponent<Text> ().text = tManag.getName(tempList[i]);
                if (symptomToggles.TryGetValue(currentPart, out boolList))
                {
                    newToggle.transform.GetComponent<Toggle>().isOn = boolList[i];
                }
				newToggle.SetActive(true);
			}
		}
    }  
}
