using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogStart = 0f;
    private float dogCooldown = 1f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > dogCooldown + dogStart)
        {
            dogStart = Time.time;
	 	    Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
} 
