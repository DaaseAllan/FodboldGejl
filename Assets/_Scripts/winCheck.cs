using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winCheck : MonoBehaviour {

    public GameObject wintext1;
    public GameObject wintext2;

    public GameObject Player1;
    public GameObject Player2;
    public GameObject ball;

    public GameObject gameHandler;
    public GameObject scoreCounter;

    public float timerCD;

    private bool checkwin = false;

	// Use this for initialization
	void Start () {

        scoreCounter = GameObject.FindGameObjectWithTag("ScoreCounter");

	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!checkwin)
        {
            if (collision.gameObject.tag == "GoalCheck")
            {
                print(collision.transform.parent.parent.name);
                if (collision.transform.parent.parent.name == "Player1")
                {
                    scoreCounter.GetComponent<ScoreCounter>().player1Score++;
                    win(wintext1);
                }
                else if (collision.transform.parent.parent.name == "Player2")
                {
                    win(wintext2);
                }

                //Gør sådan at den ikke trigger flere gange.
                checkwin = true;
            }
        }
    }

    void win(GameObject epicwintext)
    {
        epicwintext.SetActive(true);
        StartCoroutine(ResetPositions());
    }

    public IEnumerator ResetPositions()
    {
        yield return new WaitForSeconds(timerCD);
        SceneManager.LoadScene("Main");

    }
}

