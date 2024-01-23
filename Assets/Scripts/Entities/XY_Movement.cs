using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XY_Movement : MonoBehaviour
{

    private XY_CharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;//�ʱ�ȭ
    private Rigidbody2D _rigidbody;

    

    private void Awake()
    {
        _controller = GetComponent<XY_CharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.MoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        _rigidbody.velocity = direction;
    }
}
