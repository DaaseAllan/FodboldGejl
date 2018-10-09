using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GoalCheck")
        {

            print(collision.transform.parent.parent.name);
            if (collision.transform.parent.parent.name == "Player1")
            {
                print("Player1Win");
            }
        }
    }
}

