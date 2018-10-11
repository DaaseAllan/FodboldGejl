using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    Rigidbody2D rb;
    public float speed;
    public float acceleration;
    public float ballcountdown;

    private Vector3 direction;
    private float x;
    private float y;
    private float velocity;

    public float stuckCheckX;
    public float stuckCheckY;
    public int stuckCheckCounterX;
    public int stuckCheckCounterY;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
        //StartCoroutine(StartBall());
    }

    public IEnumerator StartBall()
    {
        yield return new WaitForSeconds(ballcountdown);
        print("hejhej1234");
        x = Random.Range(-0.2f, 0.2f) * speed;
        y = Random.Range(-0.2f, 0.2f) * speed;
        direction = new Vector3(x, y, 0f);
        rb.AddForce(direction);

    }

    void FixedUpdate()
    {
        //Holder konstant fart, der stiger langsomt
        speed = speed + acceleration * 0.01f;
        rb.velocity = speed * rb.velocity.normalized;


        //Stuck check
        if (stuckCheckCounterX >= 5)
        {
            Debug.Log("XXXXXX");
            rb.AddForce(transform.right * (speed + acceleration),ForceMode2D.Impulse);
            stuckCheckCounterX = 0;
        }
        if (stuckCheckCounterY >= 5)
        {
            Debug.Log("YYYYYY");
 
            rb.AddForce(transform.up * (speed + acceleration), ForceMode2D.Impulse);
            stuckCheckCounterY = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(transform.position.x < stuckCheckX + 1 && transform.position.x > stuckCheckX - 1)
        {
            stuckCheckCounterX++;
        }
        else
        {
            stuckCheckCounterX = 0;
        }
        stuckCheckX = transform.position.x;

        if (transform.position.y < stuckCheckY + 1 && transform.position.y > stuckCheckY - 1)
        {
            stuckCheckCounterY++;
        }
        else
        {
            stuckCheckCounterY = 0;
        }
        stuckCheckY = transform.position.y;
    }
}
