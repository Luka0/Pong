using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidbody; //referenca na rigidbody objekta koji sadrzi ovu skriptu
    protected float speed = 15.0f;

    private void Awake() //ovo je nest slicno ko konstruktor - izvodi se pri inicijalizaciji objekta valjd
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
}
