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
        Vector3 player1Move = new Vector3(Input.GetAxis("Player1_Y"), 0, 0);
        Vector3 player1Rot = new Vector3(0, Input.GetAxis("Player1_X"), 0);

        Vector3 player2Move = new Vector3(Input.GetAxis("Player2_Y"), 0, 0);
        Vector3 player2Rot = new Vector3(0, Input.GetAxis("Player2_X"), 0);

        //Transforms
        transform.position = transform.position + camera1.transform.forward * player1Move.x * speed * Time.deltaTime;
        transform.position = transform.position + camera2.transform.forward * player2Move.x * speed * Time.deltaTime;
        transform.Rotate(player1Rot * Time.deltaTime * rotSpeed);
        transform.Rotate(player2Rot * Time.deltaTime * rotSpeed);

        //Swing weapon
        if(Input.GetKeyDown("space")) {
            Swing();
        }
    }

    //If spacebar is pressed, shoot ray from camera 1. If hit, destroy enemy
    void Swing() {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, camera1.transform.forward, out hit, 15)) {
            if(hit.collider.isTrigger && hit.collider.tag == "Enemy") {
                Destroy(hit.transform.gameObject);
                Debug.Log("Hit");
            }
        }
    }

    private void OnTriggerEnter(Collider other) {

        //This code runs when enemy collides with player. Enemy is destroyed on collison
        if(other.tag == "Enemy") {
            Debug.Log("Enemy Hit");
            Destroy(other.gameObject);
        }
    }
}
