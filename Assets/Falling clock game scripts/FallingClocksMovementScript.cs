using Unity.VisualScripting;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float strafeScalar = 5;
    public float jumpStrength = 5;
    public Rigidbody2D myRigidbody;
    private bool hasLanded = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) {
            myRigidbody.linearVelocityX = 1 * strafeScalar;
        }
        if (Input.GetKey(KeyCode.A)) {
            myRigidbody.linearVelocityX = -1 * strafeScalar;
        }
        if ((Input.GetKey(KeyCode.Space) && hasLanded) || (Input.GetKey(KeyCode.W) && hasLanded)) {
            myRigidbody.linearVelocityY = 1 * jumpStrength;
            hasLanded = false;
        }


    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.layer == 3) {
            hasLanded = true;
        }
    }


}
