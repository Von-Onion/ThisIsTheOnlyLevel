using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject door;
    [SerializeField] private GameObject target;
    [SerializeField] private GameObject doorTarget;

    private bool isPressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.position = target.transform.position;
        door.transform.position = doorTarget.transform.position;
    }
}
