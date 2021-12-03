using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private CharacterController _controller;
    [SerializeField]
    private float _speed = 3.5f;
    [SerializeField]
    private float _gravity = 9.81f;
    [SerializeField]
    private float _jumpHeight = 3.5f;

    private float _directionY;
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();
    }

    void playerMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        if (Input.GetButtonDown("Jump"))
        {
            _directionY = _jumpHeight;
        }

        _directionY -= _gravity * Time.deltaTime;

        direction.y = _directionY;
        direction = transform.transform.TransformDirection(direction);
        _controller.Move(direction * _speed * Time.deltaTime);
    }
}
