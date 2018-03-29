using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displaySymptoms : MonoBehaviour {
	public Dictionary<string, List<string>> symptoms;
	public Text symptomText;
	// Use this for initialization
	void Start () {
		List<string> headSymptoms = new List<string>();
		headSymptoms.Add("headache");
		symptoms = new Dictionary<string, List<string>>();
		symptoms.Add("UpperHead", headSymptoms);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void onClick ()
	{	
		string part = gameObject.name;
		List<string> temp = null;
		if (symptoms.TryGetValue (part, out temp)) {
			foreach (string symp in temp)
			{
				symptomText.text = symptomText.text + symp + "\n";
		}

	}
}
}