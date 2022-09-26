using UnityEngine;

public class ComputerPaddle : Paddle
{
    private Vector2 _direction;
    public GameObject ball;
    private Transform paddlePosition;
    private Transform ballPosition;
    private Transform midLinePosition;

    private void Start()
    {
        //ball = GameObject.Find("Ball");
        paddlePosition = GetComponent<Transform>();
        ballPosition = ball.GetComponent<Transform>();
        midLinePosition = GameObject.Find("MidLine").GetComponent<Transform>();
    }

    private void Update()
    {
        if(ballPosition.position.y > paddlePosition.position.y) { _direction = Vector2.up; }
        else if(ballPosition.position.y < paddlePosition.position.y) { _direction = Vector2.down; }
        else { _direction = Vector2.zero; }
    }

    private void FixedUpdate()
    {
        if (ballPosition.position.x > midLinePosition.position.x && ball.GetComponent<Ball>().lastMoveDirection.x > 0.0f)
            _rigidbody.AddForce(_direction * speed);
    }
}
