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
        Vector3 player1Move = new Vector3(Input.GetAxis("Vertical 1"), 0, 0);
        Vector3 player2Move = new Vector3(Input.GetAxis("Vertical 2"), 0, 0);

        Vector3 player1Rot = new Vector3(0, Input.GetAxis("Horizontal 1"), 0);
        Vector3 player2Rot = new Vector3(0, Input.GetAxis("Horizontal 2"), 0);

        player1Move += player2Move;
        player1Rot += player2Rot;

        transform.position = transform.position + camera1.transform.forward * player1Move.x * Time.deltaTime * speed;
        transform.Rotate(player1Rot * Time.deltaTime * rotSpeed);
	}
}
