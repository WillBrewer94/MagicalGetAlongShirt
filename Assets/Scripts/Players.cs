using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour {
    public float speed = 10;
    public float rotSpeed = 10;
    public Camera camera1;
    public Camera camera2;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(Input.GetAxis("Player1_X") + " " + Input.GetAxis("Player1_Y"));

        Vector3 player1Move = new Vector3(Input.GetAxis("Player1_Y"), 0, 0);
        Vector3 player1Rot = new Vector3(0, Input.GetAxis("Player1_X"), 0);

        Vector3 player2Move = new Vector3(Input.GetAxis("Player2_Y"), 0, 0);
        Vector3 player2Rot = new Vector3(0, Input.GetAxis("Player2_X"), 0);


        //Transforms
        transform.position = transform.position + camera1.transform.forward * player1Move.x * speed * Time.deltaTime;
        transform.position = transform.position + camera2.transform.forward * player2Move.x * speed * Time.deltaTime;
        //transform.Translate(player1Move * Time.deltaTime * speed);
        transform.Rotate(player1Rot * Time.deltaTime * rotSpeed);
        transform.Rotate(player2Rot * Time.deltaTime * rotSpeed);





        /*
        Vector3 player1Move = new Vector3(Input.GetAxis("Player1_LeftX"), 0, Input.GetAxis("Player1_LeftY"));
        Vector3 player1Rot = new Vector3(0, Input.GetAxis("Player1_RightX"), 0);

        Vector3 player2Move = new Vector3(Input.GetAxis("Player2_LeftX"), 0, Input.GetAxis("Player2_LeftY"));
        Vector3 player2Rot = new Vector3(0, Input.GetAxis("Player2_RightX"), 0);
        */

    }
}
