// Destroys objects that travek out of bounds

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

	// Sets the square frame for objects - they get destroyed past this point
	private float topBound = 20;
	private float lowerBound = -20;
	
    // Checks if the object is out of frame
    void Update()
    {
	if (transform.position.z > topBound || transform.position.x > topBound) {
		Destroy(gameObject);
		}
	else if (transform.position.z < lowerBound || transform.position.x < lowerBound) {
		Destroy(gameObject);
		}		
	}
}