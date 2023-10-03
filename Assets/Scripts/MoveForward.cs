// Moves animal objects

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
	public float speed = 40.0f; // Sets animal speed

    void Update()
    {
		transform.Translate(Vector3.forward * Time.deltaTime * speed); // Moves animals each frame
    }
}
