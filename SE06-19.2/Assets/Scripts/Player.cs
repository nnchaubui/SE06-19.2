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
    private float doubleJumpMultiplier = 0.5f;

    private bool _canDoubleJump = false;


    [SerializeField]
    private GameObject _muzzleFlash;

    [SerializeField]
    private GameObject _hitMarker;

    [SerializeField]
    private int currentAmmo;
    private int maxAmmo = 100;

    private bool canReload = false;


    private UIManager _uiManager;
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();

        // hide mouse cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        currentAmmo = maxAmmo;

        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {

        // if left click --> cast ray from center point of main cammera
        if (Input.GetMouseButton(0) && currentAmmo > 0) 
        {
            Shoot();
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


        if (Input.GetKeyDown(KeyCode.R) && canReload == false)
        {
            canReload = true;
            StartCoroutine(Reload());
        }

        playerMovement();
    }

    void Shoot()
    {
        _muzzleFlash.SetActive(true);
        currentAmmo--;
        _uiManager.UpdateAmmo(currentAmmo);
        Ray rayOrigin = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hitInfo;
        if (Physics.Raycast(rayOrigin, out hitInfo))
        {
            Debug.Log("Raycast hit: " + hitInfo.transform.name);

            GameObject hitMarker = (GameObject)Instantiate(_hitMarker, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
            Destroy(hitMarker, 1f);
        }
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


    IEnumerator Reload()
    {
        yield return new WaitForSeconds(2f);
        currentAmmo = maxAmmo;
        _uiManager.UpdateAmmo(currentAmmo);
        canReload = false;
    }
}
