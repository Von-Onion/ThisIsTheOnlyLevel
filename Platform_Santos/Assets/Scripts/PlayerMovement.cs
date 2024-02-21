using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    private float xMovement = 0f;

    public float speed = 40f;

    private bool jump = false;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxisRaw("Horizontal") * speed;

        if (Input.GetButtonDown("Jump")) 
        {
            jump = true;
        }
    }

    private void FixedUpdate()
    {
        controller.Move(xMovement * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
