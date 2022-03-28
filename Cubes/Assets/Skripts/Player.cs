using UnityEngine;

public class Player : MonoBehaviour
{
    public int money, count;
    public float speed = 3f;
    private Rigidbody rb;
    public GameObject heart1, heart2, heart3;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, rb.velocity.y, rb.velocity.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            money += 1;
        }
        if (collision.gameObject.tag == "Stena" && count == 0)
        {
            Destroy(collision.gameObject);
            count += 1;
            Destroy(heart1);
        }
        else if (collision.gameObject.tag == "Stena" && count == 1)
        {
            Destroy(collision.gameObject);
            count += 1;
            Destroy(heart2);
        }
        else if (collision.gameObject.tag == "Stena" && count == 2)
        {
            Destroy(collision.gameObject);
            count += 1;
            Destroy(heart3);
        }
    }

    void Touch()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                   transform.position.x + touch.deltaPosition.x * speed,
                   transform.position.y,
                   transform.position.z);
            }

        }
    }
}
