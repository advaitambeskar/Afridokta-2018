using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomin : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void zoominview()
    {
        Camera.main.orthographicSize = Mathf.MoveTowards(Camera.main.orthographicSize, 2, 2 * Time.deltaTime);

    }
}
