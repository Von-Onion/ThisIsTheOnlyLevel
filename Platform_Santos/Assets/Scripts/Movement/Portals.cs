using UnityEngine;

public class Portals : MonoBehaviour
{
    private Transform destination;

    public bool isRed;
    public float distance = 0.2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(!isRed){
            destination = GameObject.FindGameObjectWithTag("RedPortal").GetComponent<Transform>();
        } else {
            destination = GameObject.FindGameObjectWithTag("BluePortal").GetComponent<Transform>();
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (Vector2.Distance(transform.position, other.transform.position) > distance && other.tag != "PortalProof"){
            other.transform.position = new Vector2 (destination.position.x, destination.position.y);
        }
    }
}
