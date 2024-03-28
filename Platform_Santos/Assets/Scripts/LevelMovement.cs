using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMovement : MonoBehaviour
{
    public GameObject level;
    [SerializeField] private Rigidbody2D rb;
    public float speed;

    private float xAxis = 0;
    private float yAxis = 0;
    private Vector2 move;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xAxis = Input.GetAxisRaw("Horizontal") * speed;
        yAxis = Input.GetAxisRaw("Vertical") * speed;

        move = new Vector2(xAxis, yAxis);
    }

    private void FixedUpdate()
    {
        rb.AddForce(move, ForceMode2D.Force);
    }
}
