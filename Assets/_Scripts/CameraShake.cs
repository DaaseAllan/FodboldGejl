using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour {

    
    Vector3 originalCameraPosition;

    float shakeAmt = 0;

    public float shakeAmplifier = 1;

    public Camera mainCamera;

    private void Start()
    {
        originalCameraPosition = mainCamera.transform.position;
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        //Finder retningen der skal shakes
        shakeAmt = coll.relativeVelocity.magnitude * 0.0025f;

        //Starter shake
        InvokeRepeating("CameraObjShake", 0, .01f);

        
        //Slutter shake
        Invoke("StopShaking", 0.3f);

    }

    void CameraObjShake()
    {
        if (shakeAmt > 0)
        {
            //Laver temp direction
            Vector3 pp = mainCamera.transform.position;

            //Value til x
            float quakeAmtX = Random.value * shakeAmt * 2 - shakeAmt;
            pp.x += quakeAmtX;


            //Value til y
            float quakeAmtY = Random.value * shakeAmt * 2 - shakeAmt;
            pp.y += quakeAmtY;


            mainCamera.transform.position = pp;
        }
    }

    void StopShaking()
    {
        //Stopper shake
        CancelInvoke("CameraObjShake");

        //Flytter camera tilbage til startpos
        mainCamera.transform.position = originalCameraPosition;
    }
}
