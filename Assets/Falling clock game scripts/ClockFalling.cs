using UnityEngine;

public class ClockFalling : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float fallSpeed = 7;
    public float ydeadzone = -15;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.linearVelocity = Vector2.down * fallSpeed;
        
        if (transform.position.y < ydeadzone) {
            Destroy(gameObject);
        }
    }
}
