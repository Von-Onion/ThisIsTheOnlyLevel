using UnityEngine;

public class GravityFlip : MonoBehaviour
{
    public Transform from;
    public Transform to;
    private bool isGravityFlipped = false;
    private float timeCount = 0.0f;
    [SerializeField] private float speed = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            if(!isGravityFlipped){
             timeCount = 0f;
            isGravityFlipped = true;
            Physics2D.gravity *= -1;
        } else {
            timeCount = 0f;
            isGravityFlipped = false;
            Physics2D.gravity *= -1;
        }
        }
        timeCount = Mathf.Clamp(timeCount, 0, speed); 

        
        

        
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        Physics2D.gravity *= -1;
        
        if(!isGravityFlipped){
            isGravityFlipped = true;
        } else {
            isGravityFlipped = false;
        }
        if(!isGravityFlipped){
            transform.rotation = Quaternion.Slerp(from.rotation, to.rotation, timeCount + Time.deltaTime);
        } else{
            transform.rotation = Quaternion.Slerp(to.rotation, from.rotation, timeCount - Time.deltaTime);
        }
    }
}
