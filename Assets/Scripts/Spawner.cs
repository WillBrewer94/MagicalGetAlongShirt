using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject enemy;
    public GameObject player;
    public float spawnRadius = 10;
    float spawnTimer = 10;
    public float currTimer = 9;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        if(spawnTimer <= currTimer) {
            currTimer = 0;
            Spawn();
        } else {
            currTimer += Time.deltaTime;
        }
    }

    //Spawn enemy at a random point in a circle around player of radius spawnRadius
    void Spawn() {
        float angle = Random.value / 360;
        float x = player.transform.position.x + Mathf.Cos(angle) * spawnRadius;
        float y = player.transform.position.y + Mathf.Sin(angle) * spawnRadius;

        //Random.on
        Vector2 ran = Random.insideUnitCircle * 50 + new Vector2(player.transform.position.x, player.transform.position.y);

        Object.Instantiate(enemy, ran, Quaternion.identity);
    }
}
