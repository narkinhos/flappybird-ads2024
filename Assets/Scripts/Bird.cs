using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Animator _animator;

    public float speed = 1f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            _rigidbody.velocity = Vector2.up * speed;
            _animator.SetTrigger("Jump");
        }
    }
}
