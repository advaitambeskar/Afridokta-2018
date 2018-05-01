using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class languageButton : MonoBehaviour {
    public Text mytext;
    public translationManager tManag;

	// Use this for initialization
	void Start () {
        mytext.text = "";
		tManag = GameObject.Find("GvrEventSystem").GetComponent<translationManager>();
        refresh();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void refresh()
    {
        mytext.text = "Language" + "\n" + tManag.getLanguage();
    }

    public void toggleLanguage()
    {
        tManag.toggleLanguage();
        refresh();
    }
}
