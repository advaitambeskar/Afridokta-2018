using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
    public GameObject k;
    int temp = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (temp != 0)
            k.transform.Rotate(0, 40 * Time.deltaTime, 0, Space.World);
    }
    public void rotate_it()
    {
        //k.transform.Rotate(0,180,0);
        temp = 1;

    }
    public void rotate_stop()
    {
        temp = 0;
    }
    public void rotate_toggle()
    {
        if (temp == 1)
            temp = 0;
        else temp = 1;
    }
}
