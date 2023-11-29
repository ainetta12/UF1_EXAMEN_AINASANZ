using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField] private float _speedPlayer = 6;

    private  Collider2D _collider;

    //private  RigidBody2D _rBody2D;

   // private Animator _anim;
    
    private float _playerInputHorizontal;
    

    void Awake()
    {
        // _rBody2D = gameObject.GetComponent<Rigidbody2D>();
        // _anim = gameObject.GetComponent<Animator>();
         
    }

    
    void Update()
    {
        //PlayerMovement;
    }

    void FixedMovment()
    {
        
    }

     void PlayerMovement()
    {
           if (_playerInputHorizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            // _animator.SetBool("IsRunning",true);

        }

        else if (_playerInputHorizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            // _animator.SetBool("IsRunning",true);

        }

    }

    void Jump()
    {

    }

}
