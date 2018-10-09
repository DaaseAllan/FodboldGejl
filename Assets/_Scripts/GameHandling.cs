using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandling : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;
    public GameObject ball;

	// Use this for initialization
	void Start () {
        SetPositions();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetPositions()
    {
        print("hejGAY");
        print(player1.transform.position);
        player1.transform.position = new Vector3(7,0,0);
        print(player1.transform.position);

        //player2.transform.position = new Vector3(-7,0,0)

        ball.transform.position = new Vector3(0, 0, -2);
    }
}
