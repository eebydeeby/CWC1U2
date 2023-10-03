using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

	private float topBound = 20;
	private float lowerBound = -20;
	
    // Update is called once per frame
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