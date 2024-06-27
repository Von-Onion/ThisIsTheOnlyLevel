using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public GameManager gm;
    public GameObject player;

    [SerializeField] private Animator animator;

    private float xMovement = 0f;

    public float speed = 40f;

    public KeyCode jumpKey1 = KeyCode.UpArrow;
    public KeyCode jumpKey2 = KeyCode.W;

    private bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxisRaw("Horizontal") * speed;

        animator.SetFloat("Speed", Mathf.Abs(xMovement));

        if ((Input.GetKeyDown(jumpKey1) || Input.GetKeyDown(jumpKey2)) && gm.sceneName != "Level4")
        {
            jump = true;
        } 

        if ((Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) && gm.isUpsideDown && gm.sceneName != "Level9")
        {
            jump = true;
        }


            if (gm.isUpsideDown){
            xMovement = -Input.GetAxisRaw("Horizontal") * speed;
            Debug.Log("Ikea");
        }
    }

    private void FixedUpdate()
    {
        controller.Move(xMovement * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
