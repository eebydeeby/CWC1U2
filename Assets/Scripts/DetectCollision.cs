using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{	
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			ScoreManager.lives --;
            Debug.Log(ScoreManager.lives);
			if (ScoreManager.lives < 0){
				Destroy(gameObject);
				Destroy(other.gameObject);
				Debug.Log("Game over!");
			}
        }
		else {
			Destroy(gameObject);
			Destroy(other.gameObject);
			ScoreManager.score ++;
			Debug.Log(ScoreManager.score);
		}
	}
}
