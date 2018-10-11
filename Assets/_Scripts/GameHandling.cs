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
        SoundHandler s = SoundHandler.soundHandler;
        CD3.SetActive(true);
        s.playSound(2);
        yield return new WaitForSeconds(1);

        CD2.SetActive(true);
        s.playSound(3);
        yield return new WaitForSeconds(1);

        CD1.SetActive(true);
        s.playSound(4);
        yield return new WaitForSeconds(1);

        CDEpic.SetActive(true);
        s.playSound(5);
        yield return new WaitForSeconds(1);
        startup = false;
    }

}
