using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public GameObject jugador;
   // public Animator animator;
    public Joystick movin;
    

    private float runSpeed = 5f;

    


    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = new Vector3(movin.Horizontal * runSpeed, rigidbody.velocity.y, movin.Vertical * runSpeed);

        //    animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        //    animator.SetFloat("speed", Mathf.Abs(verticalMove));
    }
}
