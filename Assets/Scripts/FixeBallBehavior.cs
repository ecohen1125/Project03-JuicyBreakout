using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FixeBallBehavior : MonoBehaviour
{
    GameObject ball;
    public float idleTime = 2f;
    Vector2 curPos;

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
        idleTime -= Time.deltaTime;

        if (idleTime <= 0.0f)
        {
            if (curPos.x == ball.transform.position.x || curPos.y == ball.transform.position.y)
            {
                ball.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
                ball.transform.position = spawnPos;

                //ball.GetComponent<ScriptMachine>().graph.variables = true;

                idleTime = 2.0f;
            }
                           
        }
        curPos = ball.transform.position;

    }
}
