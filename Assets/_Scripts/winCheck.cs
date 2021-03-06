﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class winCheck : MonoBehaviour {

    public GameObject wintext1;
    public GameObject wintext2;

    public GameObject Player1;
    public GameObject Player2;
    public GameObject ball;

    public GameObject gameHandler;
    public GameObject scoreCounter;

    //UI Gejl
    public GameObject p2score;
    public GameObject p1score;
    public GameObject restartText;

    public float timerCD;

    private bool checkwin = false;

    private bool canRestartgame = false;

	// Use this for initialization
	void Start () {

        canRestartgame = false;
            
        scoreCounter = GameObject.FindGameObjectWithTag("ScoreCounter");

        Text p1text = p1score.GetComponent<Text>();
        Text p2text = p2score.GetComponent<Text>();

        p1text.text = "Score: " + scoreCounter.GetComponent<ScoreCounter>().player2Score;
        p2text.text = "Score: " + scoreCounter.GetComponent<ScoreCounter>().player1Score;
    }
	
	// Update is called once per frame
	void Update () {
		if(canRestartgame && Input.GetButtonUp("Fire1"))
        {
            SceneManager.LoadScene("Main");
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int number = (int)Random.Range(6,9);

        SoundHandler.soundHandler.playSound(number);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!checkwin)
        {
            
            if (collision.gameObject.tag == "GoalCheck")
            {
                print(collision.transform.parent.parent.name);
                if (collision.transform.parent.parent.name == "Player1")
                {
                    scoreCounter.GetComponent<ScoreCounter>().player1Score++;

                    win(wintext1, p2score, 1);
                    ScoreUpdate();
                }
                else if (collision.transform.parent.parent.name == "Player2")
                {
                    scoreCounter.GetComponent<ScoreCounter>().player2Score++;
                    ScoreUpdate();
                    win(wintext2, p1score, 0);
                }
                

                //Gør sådan at den ikke trigger flere gange.
                checkwin = true;
            }
        }
    }

    void win(GameObject epicwintext, GameObject score, int soundClip)
    {
        epicwintext.SetActive(true);

        //Udkommenteret da det ikke virkede, fordi at begge scores blev hentet fra P1.
        //Text scoreText = score.GetComponent<Text>();
        //scoreText.text = "Score: " + scoreCounter.GetComponent<ScoreCounter>().player1Score;
        SoundHandler.soundHandler.playSound(soundClip);
        StartCoroutine(ResetPositions());

    }

    void ScoreUpdate()
    {
        //Steven please en dag forklar mig hvorfor at de her fungerer modsat
        p1score.GetComponent<Text>().text = "Score: " + scoreCounter.GetComponent<ScoreCounter>().player2Score;
        p2score.GetComponent<Text>().text = "Score: " + scoreCounter.GetComponent<ScoreCounter>().player1Score;
    }

    public IEnumerator ResetPositions()
    {
        yield return new WaitForSeconds(timerCD);
        restartText.SetActive(true);
        canRestartgame = true;


    }
}

