using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandling : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;
    public GameObject ball;

    public bool startup = true;

	// Use this for initialization
	void Start () {
        startup = true;
        StartCoroutine(GameStart());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator GameStart()
    {
        yield return new WaitForSeconds(3);
        startup = false;
    }

}
