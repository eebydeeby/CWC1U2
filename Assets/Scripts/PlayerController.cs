// Handles player input, checks if player is in bounds and moves accordingly

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	
	public float horizontalInput;
	public float verticalInput; // Handles input API
	public float speed = 10.0f; // Sets player speed
	public float xRange = 10; // Sets the range for player bounds
	public float zRange = 10;
	public GameObject projectilePrefab; // Gets the game object to spawn if player fires
	
	void Update()
    {	
		if (Input.GetKeyDown(KeyCode.Space)){ // Checks if space key is pressed and spawns projectile
			Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
		}
		
		// Handles player movement each frame by checking bounds and updating player transform
		if (transform.position.x < -xRange) {
			transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
		}
		
		if (transform.position.x > xRange){
			transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
		}
		
		if (transform.position.z < -zRange) {
			transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
		}
		
		if (transform.position.z > zRange){
			transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
		}
		
		// Applies player transform on the frame
		transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
		horizontalInput = Input.GetAxis("Horizontal");
		
		transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
		verticalInput = Input.GetAxis("Vertical");
    }
}
