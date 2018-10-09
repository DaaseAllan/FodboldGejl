using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winCheck : MonoBehaviour {

    public GameObject wintext1;
    public GameObject wintext2;

    public GameObject Player1;
    public GameObject Player2;
    public GameObject ball;

    public GameObject gameHandler;

    public float timerCD;

    private bool checkwin = false;

	// Use this for initialization
	void Start () {

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
                    win(wintext1);
                }
                else if (collision.transform.parent.parent.name == "Player2")
                {
                    win(wintext2);
                }
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
        print("hejhej1234");
        gameHandler.GetComponent<GameHandling>().SetPositions();
        checkwin = true;
    }
}

