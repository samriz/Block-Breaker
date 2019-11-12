using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle1;

    //state
    Vector2 paddleToBallVector;

    // Start is called before the first frame update
    void Start()
    {
        paddleToBallVector = transform.position - paddle1.transform.position; //ball position minus paddle position
    }

    // Update is called once per frame
    void Update()
    {
        LockBallToPaddle();
    }

    void LockBallToPaddle()
    {
        Vector2 paddlePosition = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePosition + paddleToBallVector; //ball's position is the position of the paddle plus the offset
    }
}
