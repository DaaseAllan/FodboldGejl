using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

    public int player1Score = 0;
    public int player2Score = 0;

    private static bool created =  false;


    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);
        }
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update () {
		
	}
}
