// Collision handler that runs on each animal instance

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{	
	// Runs checks upon collision
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") { // Checks if object touching animal is player
			ScoreManager.lives --;
            Debug.Log(ScoreManager.lives);
			if (ScoreManager.lives < 0){ // Checks if the player has ran out of lives and runs game over if so
				Destroy(gameObject);
				Destroy(other.gameObject);
				Debug.Log("Game over!");
			}
        }
		else { // Handles bullet collision and updates score
			Destroy(gameObject);
			Destroy(other.gameObject);
			ScoreManager.score ++;
			Debug.Log(ScoreManager.score);
		}
	}
}
