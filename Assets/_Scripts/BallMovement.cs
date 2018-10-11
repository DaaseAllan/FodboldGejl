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
        speed = speed + acceleration * 0.01f;
        rb.velocity = speed * rb.velocity.normalized;
    }
}
