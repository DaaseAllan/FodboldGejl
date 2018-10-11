using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public enum PlayerNumber
    {
        P1,
        P2
    };

    public PlayerNumber playerNumber;

    public GameObject rightPlayers;
    public GameObject leftPlayers;
    public GameObject rightSprite;
    public GameObject leftSprite;

    public GameObject GameHandler;

    Rigidbody2D rightRB;
    Rigidbody2D leftRB;

    float horizontalR;
    float verticalR;
    float verticalL;
    float horizontalL;

    float moveLimiter = 0.7f;
    public float runSpeed = 20;

    public string test;



    void Start()
    {
        rightRB = rightPlayers.GetComponent<Rigidbody2D>();
        leftRB = leftPlayers.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        test = Input.GetAxisRaw(playerNumber + "HorizontalR").ToString();

        horizontalR = Input.GetAxisRaw(playerNumber + "HorizontalR");
        verticalR = Input.GetAxisRaw(playerNumber + "VerticalR") * -1;

        horizontalL = Input.GetAxisRaw(playerNumber + "HorizontalL");
        verticalL = Input.GetAxisRaw(playerNumber + "VerticalL") * -1;


        //Rotate spriteS
        float angleR = Mathf.Atan2(horizontalR, verticalR) * Mathf.Rad2Deg;
        if(angleR != 180)
        {
            rightSprite.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -angleR));
        }

        float angleL = Mathf.Atan2(horizontalL, verticalL) * Mathf.Rad2Deg;
        if (angleL != 180)
        {
            leftSprite.transform.rotation = Quaternion.Euler(new Vector3(0, 0, -angleL));
        }


    }

    void FixedUpdate()
    {

        //Tjekker om spillet er startet
        if (!GameHandler.GetComponent<GameHandling>().startup)
        {
            //Højre
            if (horizontalR != 0 && verticalR != 0)
                rightRB.velocity = new Vector2((horizontalR * runSpeed) * moveLimiter, (verticalR * runSpeed) * moveLimiter);
            else
                rightRB.velocity = new Vector2(horizontalR * runSpeed, verticalR * runSpeed);

            //Venstre
            if (horizontalL != 0 && verticalL != 0)
                leftRB.velocity = new Vector2((horizontalL * runSpeed) * moveLimiter, (verticalL * runSpeed) * moveLimiter);
            else
                leftRB.velocity = new Vector2(horizontalL * runSpeed, verticalL * runSpeed);
        }

    }
}
