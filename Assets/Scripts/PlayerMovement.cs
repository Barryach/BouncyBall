using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f;        
    public float jumpForce = 5f;    
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            if (GameManager.instance != null)
            {
                GameManager.instance.PlayerDied();
            }
        }
    }
}
