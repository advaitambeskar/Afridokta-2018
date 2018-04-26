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
    public lightManager lManag;
    public translationManager tManag;
	public Dictionary<bodyPart, List<symptom>> symptomsDictionary;
    public List<symptom> defaultSymptoms;
    public List<symptom> selectedSymptoms;

    private string[,] bodyTranslations = new string[language.GetNames(typeof(language)).Length, bodyPart.GetNames(typeof(bodyPart)).Length];
    public Dictionary<bodyPart, List<symptom>> symptomToggles;

    // Use this for initialization
    void Start()
    {
		tManag = GameObject.Find("GvrEventSystem").GetComponent<translationManager>();
        textManager = GameObject.Find("LeftBodyPart").GetComponent<textbox>();
        lManag = GameObject.Find("Text1").GetComponent<lightManager>();

        selectedPart = "";

        symptomToggles = new Dictionary<bodyPart, List<symptom>>() { };
		selectedSymptoms = new List<symptom>() { };

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
        // Set current part to unselected
        // Set new part to selected
        lManag.lightSelect(part);
        lManag.lightUnselect(currentPart);

        // Store current selection list if part != currentPart
        // Load new selected Symptoms
        if( part != currentPart)
        {
            symptomToggles.Remove(currentPart);
            symptomToggles.Add(currentPart, selectedSymptoms);
            if(!symptomToggles.TryGetValue(part, out selectedSymptoms))
            {
                selectedSymptoms = new List<symptom>() { };
            }
            currentPart = part;
        }
        createList();
    }

    public void toggleSymptom(symptom sym)
    {
        //Toggle symptom in symptom list
        if (!selectedSymptoms.Contains(sym))
        {
            selectedSymptoms.Add(sym);
            lManag.lightActivate(currentPart);
            textManager.add(currentPart, sym);
        }
        else
        {
            selectedSymptoms.Remove(sym);
            if(selectedSymptoms.Count == 0)
            {
                lManag.lightDeactivate(currentPart);
            }
            textManager.remove(currentPart, sym);
        }
    }

    public void createList()
    {
        //Populate symptom canvas with the symptoms
		SymptomCanvas = GameObject.FindGameObjectWithTag ("SympCanvas").GetComponent<Transform>();
		List<symptom> tempList = new List<symptom> ();
		if (symptomsDictionary.TryGetValue (currentPart, out tempList)) { 
			for (int i = 0; i < tempList.Count; i++) {
				GameObject newToggle = GameObject.Instantiate(Resources.Load("SymptomToggle")) as GameObject;
				newToggle.transform.position = new Vector3 (0f, (i * -0.2f) + 0.5f, 0f);
				newToggle.transform.SetParent(SymptomCanvas.transform, false);
				newToggle.transform.Find ("Label").GetComponent<Text> ().text = tManag.getName(tempList[i]);
				newToggle.GetComponent<symptomCheck>().mySymptom = tempList[i];
                if (selectedSymptoms.Count != 0)
                {
                    newToggle.transform.GetComponent<Toggle>().isOn = selectedSymptoms.Contains(tempList[i]);
                }
				newToggle.SetActive(true);
			}
		}
    }  
}
