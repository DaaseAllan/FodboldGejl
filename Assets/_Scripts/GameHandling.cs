using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandling : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;
    public GameObject ball;

    //Countdown objekter
    public GameObject CD3;
    public GameObject CD2;
    public GameObject CD1;
    public GameObject CDEpic;

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
        CD3.SetActive(true);
        yield return new WaitForSeconds(1);

        CD2.SetActive(true);
        yield return new WaitForSeconds(1);

        CD1.SetActive(true);
        yield return new WaitForSeconds(1);

        CDEpic.SetActive(true);
        yield return new WaitForSeconds(1);
        startup = false;
    }

}
