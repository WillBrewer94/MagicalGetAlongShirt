using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public Camera elf;
    public Camera dwarf;

    public GameObject shirt;

    public int health = 20;

    public GameObject[] enemies;

    public int keyCount = 10;

    [HideInInspector]
    public static LevelManager instance;

    void Start()
    {
        instance = this;
    }

    void Update()
    {
        //lose state
        if (health <= 0)
        {
            Debug.Log("you lost, gg scrub");
        }

        //win
        if (keyCount == 0)
        {
            Debug.Log("winner winner chicken dinner bitches");
        }
    }
}
