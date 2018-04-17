using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textbox : MonoBehaviour
{
    public Text mytext;
    List<GameObject> list = new List<GameObject>();
    public translationManager tManag;

    // Use this for initialization
    void Start () {
        mytext.text = "";
		tManag = GameObject.Find("GvrEventSystem").GetComponent<translationManager>();

    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void refresh()
    {
        mytext.text = "";
        for (int i = 0; i < list.Count; i++)
        {
            if (i != 0)
            {
                mytext.text += "\n";
            }
            mytext.text += tManag.getName(list[i]);
        }
    }

    public void add(GameObject bPart)
    {
        if (!list.Contains(bPart))
        {
            list.Add(bPart);
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
