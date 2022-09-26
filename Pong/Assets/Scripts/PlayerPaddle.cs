using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;

    private void Update() //Called every frame -> depends on the game framerate so dont put physics here
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            _direction = Vector2.up;
        }else if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            _direction = Vector2.down;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }

    private void FixedUpdate() //Colled every fixed time interval -> put physics here
    {
        if(_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * speed);
        }
    }
}
