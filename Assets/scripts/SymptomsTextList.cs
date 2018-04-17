using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class SymptomsTextList : MonoBehaviour {
	public Text symptomToggleText;
	public textbox textManager;

	void Start() {
		string path = Application.persistentDataPath + "/Assets/Resources/Symptom.txt";
		if(File.Exists(path))
		{
			File.Delete (path);
		}
		File.CreateText (path).Close ();
	}

	public void addSymptom() {
		string path = Application.persistentDataPath + "/Assets/Resources/Symptom.txt";
		Toggle tempToggle = this.GetComponent<Toggle> ();
		if (tempToggle.isOn) {
			StreamWriter writer = new StreamWriter (path, true);
			textManager = GameObject.Find ("LeftBodyPart").GetComponent<textbox> ();
			symptomToggleText = this.GetComponentInChildren<Text> ();
			string part = textManager.GetComponentInChildren<Text> ().text;
			string symptom = symptomToggleText.text;
			writer.WriteLine (part + ": " + symptom + "\n");
			writer.Close ();
		}
	}
}
