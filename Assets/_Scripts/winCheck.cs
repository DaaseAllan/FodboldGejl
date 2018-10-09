using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winCheck : MonoBehaviour {

    public GameObject wintext1;
    public GameObject wintext2;

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

                win(wintext1);
            }
            else if(collision.transform.parent.parent.name == "Player2")
            {
                win(wintext2);
            }
        }
    }

    void win(GameObject epicwintext)
    {
        epicwintext.SetActive(true);
    }
}

