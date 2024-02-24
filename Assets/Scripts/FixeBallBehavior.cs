using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FixeBallBehavior : MonoBehaviour
{
    GameObject ball;
    GameObject ballSpawnPoint;
    Vector3 spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectsWithTag("ball")[0];
        ballSpawnPoint = GameObject.Find("BallSpawnPoint");

        spawnPos = ballSpawnPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {


            ResetBall();
        }
    }


    void ResetBall()
    {
        ball.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        ball.transform.position = spawnPos;

        Variables.Scene(this).Set("isFollowing", true);
    }
}
