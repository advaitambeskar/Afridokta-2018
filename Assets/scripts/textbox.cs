using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textbox : MonoBehaviour
{
    public Text mytext;
    List<GameObject> list = new List<GameObject>();
    public Dictionary<bodyPart, List<symptom>> symptomsList;
    public translationManager tManag;

    // Use this for initialization
    void Start () {
        mytext.text = "";
		tManag = GameObject.Find("GvrEventSystem").GetComponent<translationManager>();

    }
	
	// Update is called once per frame
	void Update () {
        
	}

    // Redraw TextBox
    void refresh()
    {
        //List<symptom> tempList = new List<symptom> ();
        //mytext.text = "";
        //for (int i = 0; i < list.Count; i++)
        //{
        //    mytext.text += (tManag.getName(list[i]) + "\n");
        //    if (symptomsList.TryGetValue(tManag.getIdentifier(list[i]), out tempList))
        //    {
        //        for (int j = 0; j < tempList.Count; j++)
        //        {
        //            mytext.text += ("    " + tManag.getName(tempList[j]) + "\n");
        //        }
        //    }
        //}

        for (int i = 0; i < language.GetNames(typeof(language)).Length; i++)
        {
            mytext.text += (tManag.getName((bodyPart) i) + "\n");
            
		    List<symptom> tempList = new List<symptom> ();
            if (symptomsList.TryGetValue((bodyPart) i, out tempList))
            {
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
            symptomsList.Remove(part);
            tempList.Add(sym);
            symptomsList.Add(part, tempList);
        }
        refresh();
    }

    public void remove(bodyPart part, symptom sym)
    {
		List<symptom> tempList = new List<symptom> ();
        if(symptomsList.TryGetValue(part, out tempList))
        {
            symptomsList.Remove(part);
            tempList.Remove(sym);
            symptomsList.Add(part, tempList);
        }
        refresh();
    }

    public void add(GameObject bPart)
    {
        if (!list.Contains(bPart))
        {
            list.Add(bPart);
        }
        refresh();
    }

    public void toggle(GameObject bPart)
    {
        if (!list.Contains(bPart))
        {
            list.Add(bPart);
        }
        else
        {
            list.Remove(bPart);
        }
        refresh();
    }

    public void remove(GameObject bPart)
    {
        list.Remove(bPart);
    }

    public void clear()
    {
        list.Clear();
    }
}
