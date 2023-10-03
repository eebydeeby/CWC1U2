using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public GameObject[] animalPrefabs;
	private float spawnRangeX = 10;
	private float spawnRangeZ = 10;
	private float spawnPosX = 20;
	private float spawnPosZ = 20;
	private float startDelay = 2;
	private float spawnInterval = 1.5f;
	private int animalSide;
	private Vector3 spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
		
    }
	
	void SpawnRandomAnimal(){
		animalSide = Random.Range(0,2);
		switch (animalSide)
		{
			case 0:
    			spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
				break;
			case 1:
				spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
				break;
			case 2:
				spawnPos = new Vector3(spawnPosX, 0, Random.Range(spawnRangeZ, -spawnRangeZ));
				break;
		}
		int animalIndex = Random.Range(0, animalPrefabs.Length);
		Instantiate(animalPrefabs[animalIndex], spawnPos,
			animalPrefabs[animalIndex].transform.rotation);
	}
}
