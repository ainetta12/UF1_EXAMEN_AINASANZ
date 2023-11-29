using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField] private float _SpeedPlayer = 6;
    [SerializeField] private float _jumpForce = 5;

    private  Collider2D _collider;

    private  Rigidbody2D _rBody2D;

   // private Animator _anim;
    
    public bool _isGrounded;

    private float _playerInputHorizontal;
    

    void Awake()
    {
        _rBody2D = gameObject.GetComponent<Rigidbody2D>();
        // _anim = gameObject.GetComponent<Animator>();
         
    }

    
    void Update()
    {
        PlayerMovement();

        if (Input.GetButtonDown("Jump") && GroundSensor._isGrounded)
        {
            Jump();
        }
        // _anim.SetBool("IsJumping",true);
    }

    void FixedMovment()
    {
         _rBody2D.velocity = new Vector2(_playerInputHorizontal * _SpeedPlayer, _rBody2D.velocity.y);
    }

     void PlayerMovement()
    {
           if (_playerInputHorizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            // _anim.SetBool("IsRunning",true);

        }

        else if (_playerInputHorizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            // _anim.SetBool("IsRunning",true);

        }
        /*else 
        {
            _anim.SetBool("IsRunning",false);
        }*/

    }

    void Jump()
    {
        _rBody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }

}
