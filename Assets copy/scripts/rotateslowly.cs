using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateslowly : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position(0, 0, 0);
        transform.Rotate(0, 45 * Time.deltaTime, 0, Space.World);
    }
}
