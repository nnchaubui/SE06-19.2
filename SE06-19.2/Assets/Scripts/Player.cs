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

    [SerializeField]
    private float doubleJumpMultiplier=  0.5f;

    private bool _canDoubleJump = false;


    [SerializeField]
    private GameObject _muzzleFlash;

    [SerializeField]
    private GameObject _hitMarker;
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();

        // hide mouse cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        // if left click --> cast ray from center point of main cammera
        if (Input.GetMouseButton(0))
        {
            _muzzleFlash.SetActive(true);

            Ray rayOrigin = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hitInfo;
            if(Physics.Raycast(rayOrigin, out hitInfo))
            {
                Debug.Log("Raycast hit: " + hitInfo.transform.name);

                Instantiate(_hitMarker, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
            }
        }
        else
        {
            _muzzleFlash.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        playerMovement();
    }

    void playerMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);

        if (_controller.isGrounded)
        {
            _canDoubleJump = true;

            if (Input.GetButtonDown("Jump"))
            {
                _directionY = _jumpHeight;
            }
        }
        else
        {
            if (Input.GetButtonDown("Jump") && _canDoubleJump)
            {
                _directionY = _jumpHeight * doubleJumpMultiplier;
                _canDoubleJump = false;
            }
        }
        

        _directionY -= _gravity * Time.deltaTime;

        direction.y = _directionY;
        direction = transform.transform.TransformDirection(direction);
        _controller.Move(direction * _speed * Time.deltaTime);
    }
}
