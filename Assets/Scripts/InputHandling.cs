using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandling : MonoBehaviour {
    private Transform theTransform;

	// Use this for initialization
	void Start () {
        theTransform = this.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("space"))
        {
            switchCamDir();
        }
		
	}

    //Switches camera 180 degrees around y axis
    void switchCamDir()
    {
        theTransform.rotation *= Quaternion.Euler(0, 180, 0);
    }

    //moves player around the x/z plane
    void move()
    {

    }

    //Does each player's allowed action (Collecting for dwarf, fighting for elf)
    void action()
    {

    }
}
