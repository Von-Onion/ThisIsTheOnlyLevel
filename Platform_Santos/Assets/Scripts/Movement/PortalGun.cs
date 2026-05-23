using UnityEngine;

public class PortalGun : MonoBehaviour
{
    Camera cam;
    public GameObject portal1;
    public GameObject portal2;
    public Transform pivot;
    [SerializeField] private float oofset = 1.0f; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 screenPoint = cam.WorldToScreenPoint(transform.localPosition) * oofset;

        Vector2 offset = new Vector2(mousePos.x - screenPoint.x, mousePos.y - screenPoint.y);
        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
        pivot.rotation = Quaternion.Euler(0, 0, angle);


        if(Input.GetMouseButtonDown(0)){
            Vector2 cursorPos = cam.ScreenToWorldPoint(Input.mousePosition);
            GameObject redPortal = GameObject.FindGameObjectWithTag("RedPortal");

            if (redPortal != null){
                Destroy(redPortal);
            }

            Instantiate(portal1, new Vector3(cursorPos.x, cursorPos.y, 0), Quaternion.identity);

            redPortal = this.gameObject;
        } else if(Input.GetMouseButtonDown(1)){

            Vector2 cursorPos = cam.ScreenToWorldPoint(Input.mousePosition);
            GameObject bluePortal = GameObject.FindGameObjectWithTag("BluePortal");

            if (bluePortal != null){
                Destroy(bluePortal);
            }

            Instantiate(portal2, new Vector3(cursorPos.x, cursorPos.y, 0), Quaternion.identity);

            bluePortal = this.gameObject;
        }


    }
}
