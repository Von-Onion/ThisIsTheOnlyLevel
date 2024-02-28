using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [Header("Objects")]

    [SerializeField] private GameObject door;
    [SerializeField] private GameObject target;
    [SerializeField] private GameObject doorTarget;

    [Header("Values")]
    [SerializeField] private float buttonTime = 1f;
    [SerializeField] private float doorTime = 1f;

    private bool isPressed;

    // Start is called before the first frame update
    void Start()
    {
        isPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isPressed){
            transform.position = Vector2.Lerp(transform.position, target.transform.position, Time.deltaTime * buttonTime);
            door.transform.position = Vector2.Lerp(door.transform.position, doorTarget.transform.position, Time.deltaTime * doorTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       isPressed = true;
    }
}
