using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float speed;
    private Vector2 _direction;
    private Rigidbody2D _rigidbody;
    private Vector2 pastPosition;
    public Vector2 lastMoveDirection;
    private Transform _transform;

    private void Awake()
    {
        speed = 150.0f;
        _direction = Vector2.zero;
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        _transform = GetComponent<Transform>();
        pastPosition = (Vector2)_transform.position;
        lastMoveDirection = Vector2.zero;
        ResetPosition();
    }

    private void FixedUpdate()
    {
        if((Vector2)_transform.position != pastPosition)
        {
            lastMoveDirection = ((Vector2)_transform.position - pastPosition).normalized;
            pastPosition = (Vector2)_transform.position;
        }
    }

    private void AddStartingForce()
    {
        float x, y;
        x = 1 - Random.Range(0, 2) * 2; // 50/50 chance to get either 1 or -1 
        y = 1 - Random.Range(0, 2) * 2; // 50/50 chance to get either 1 or -1
        _direction = new Vector2(x, y);
        _direction = _direction / _direction.magnitude; // tak da uvijek dobijes jedinicni vektor
                                                        // da brzina uvijek bude ista
        _rigidbody.AddForce(_direction * speed);
    }

    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }

    public void ResetPosition()
    {
        _rigidbody.position = Vector2.zero;
        _rigidbody.velocity = Vector2.zero;

        AddStartingForce();
    }
}
