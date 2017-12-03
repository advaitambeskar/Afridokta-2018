using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotofemaleselect : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
    public void gotofemale()
    {
        SceneManager.LoadScene("FemaleSelect");

    }
}
