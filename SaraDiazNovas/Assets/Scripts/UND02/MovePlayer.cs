using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    //Zona de propiedades
    private float _speed = 2f;

    private float _horizontal;
    private float _vertical;

    private Animator _anim;
    private Rigidbody _rb;
    //Capa donde quiero que actue el "raycast"
    public LayerMask GroundMask;
    //Longitud del "raycast"
    public float RayLenght;
    public float JumpForce;

    private Ray _ray;
    private RaycastHit _hit;
    private bool _isGrounded;
    private bool _canPlayerJump;

    private void Awake()
    {

        _anim = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();

    }

    //Metodos
    void Update()
    {

        InputPlayer();
        Move();
        CanJump();
        Animating();

    }

    private void FixedUpdate()
    {

        LauchRaycast();
        if (_canPlayerJump)
        {

            _canPlayerJump = false;
            //Lamar al método "Jump()"
            Jump();
        }

    }

    private void LauchRaycast()
    {

        //Punto de pivote
        _ray.origin = transform.position;
        //Hacia abajo
        _ray.direction = -transform.up;

        if (Physics.Raycast(_ray, out _hit, RayLenght))
        {

            //Puedo saltar
            Debug.Log("Estoy tocando suelo");
            _isGrounded = true;

        }
        else
        {

            _isGrounded = false;

        }
        Debug.DrawRay(_ray.origin, _ray.direction * RayLenght, Color.red);
    }

    private void CanJump()
    {

        //Si quiero y puedo saltar
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {

            _canPlayerJump = true;


        }

        _anim.SetBool("Jump", false);

    }


    private void Jump()
    {
        _anim.SetBool("Jump", true);
        _rb.AddForce(Vector3.up * JumpForce);

    }
    //Movimiento 
    private void InputPlayer()
    {

        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

    }

    // 
    private void Move()
    {

        transform.Translate(Vector3.forward * _speed * _vertical * Time.deltaTime);
        transform.Translate(Vector3.right * _speed * _horizontal * Time.deltaTime);
    }

    private void Animating()
    {

        if (_vertical != 0) //El personaje se está moviendo
        {

            _anim.SetBool("Walk", true);

        }
        else //El personaje está parado
        {

            _anim.SetBool("Walk", false);
        }



    }
}
