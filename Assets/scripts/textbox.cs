using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textbox : MonoBehaviour
{
    public Text mytext;
    public Dictionary<bodyPart, List<symptom>> symptomsList;
    public translationManager tManag;

    // Use this for initialization
    void Start () {
        mytext.text = "";
		tManag = GameObject.Find("GvrEventSystem").GetComponent<translationManager>();
        symptomsList = new Dictionary<bodyPart, List<symptom>>() { };

    }
	
	// Update is called once per frame
	void Update () {
        
	}

    // Redraw TextBox
    void refresh()
    {
        mytext.text = "";

        for (int i = 0; i < language.GetNames(typeof(bodyPart)).Length; i++)
        {
		    List<symptom> tempList = new List<symptom> ();
            if (symptomsList.TryGetValue((bodyPart) i, out tempList))
            {
                mytext.text += (tManag.getName((bodyPart) i) + "\n");
                for (int j = 0; j < tempList.Count; j++)
                {
                    mytext.text += ("    " + tManag.getName(tempList[j]) + "\n");
                }
            }
        }
    }
    public void add(bodyPart part, symptom sym)
    {
		List<symptom> tempList = new List<symptom> ();
        if(symptomsList.TryGetValue(part, out tempList))
        {
            if (!tempList.Contains(sym))
            {
                symptomsList.Remove(part);
                tempList.Add(sym);
                symptomsList.Add(part, tempList);
            }
        }
        else
        {
            tempList = new List<symptom>() { sym };
            symptomsList.Add(part, tempList);
        }
        refresh();
    }

    public void remove(bodyPart part, symptom sym)
    {
		List<symptom> tempList = new List<symptom> ();
        if(symptomsList.TryGetValue(part, out tempList))
        {
            if (tempList.Contains(sym))
            {
                symptomsList.Remove(part);
                tempList.Remove(sym);
                if (tempList.Count != 0)
                {
                    symptomsList.Add(part, tempList);
                }
            }
        }
        //else should be an error
        refresh();
    }
}
