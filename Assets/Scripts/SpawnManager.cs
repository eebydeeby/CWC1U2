using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public GameObject[] animalPrefabs;
	private float spawnRangeX = 10;
	private float spawnRangeZ = 10; // Sets the bounds within which animals are to be spawned
	private float spawnPosZ = 20; 
	private float startDelay = 2;
	private float spawnInterval = 1.5f;
	private int animalSide; // Variable for picking which side of the window to spawn animals
	private Vector3 spawnPos;
	private float spawnRotation;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval); // Starts spawning animals
    }

	// Function for randomly deciding where to spawn animals and adjusting their rotation accordingly
	void SpawnRandomAnimal()
	{
		animalSide = Random.Range(0,3);
		switch (animalSide)
		{
		case 0:
   			spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
			spawnRotation = 180f;
		break;
		case 1:
			spawnPos = new Vector3(20, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
			spawnRotation = 270f;
		break;
		case 2:
			spawnPos = new Vector3(-20, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
			spawnRotation = 90f;
		break;
		}
	int animalIndex = Random.Range(0, animalPrefabs.Length);
	Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, spawnRotation, 0));
	}
}
