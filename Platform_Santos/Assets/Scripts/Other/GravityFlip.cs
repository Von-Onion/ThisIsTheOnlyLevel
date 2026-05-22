using UnityEngine;

public class GravityFlip : MonoBehaviour
{
    public float smoothing = 1.0f;

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Physics2D.gravity *= -1;
        this.transform.Rotate = (0f, 0f, 90f);
    }
}
