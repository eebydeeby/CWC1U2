using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogStart = 0f;
    private float dogCooldown = 1f;
    void Update()
    {
        // On spacebar press, send dog if cooldown is over
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > dogCooldown + dogStart)
        {
            dogStart = Time.time; // Sets cooldown
	 	    Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation); // Spawns dog
        }
    }
} 
