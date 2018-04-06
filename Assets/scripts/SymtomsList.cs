using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class SymptomsList : MonoBehaviour
{
    public Text symptomButton;
    public Text mytext;

    // Use this for initialization
    void Start()
    {
        string path = "Assets/scripts/Symptoms.txt";
        if (File.Exists(path))
        {
            File.Delete(path);
        }
        File.CreateText(path).Close();
    }

    // Update is called once per frame
    public void addSymptom()
    {
        //add body part and symptom to text file from button
        string path = "Assets/Symptoms.txt";
        StreamWriter writer = new StreamWriter(path, true);
        string body = mytext.text;
        string symptom = symptomButton.text;
        writer.WriteLine(body + ": " + symptom + "\n");
        writer.Close();
    }
}
