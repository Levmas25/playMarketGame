using UnityEngine;

public class Player : MonoBehaviour
{
    public int apple, life;
    public float speed;
    public Rigidbody rb;
    public GameObject heart1, heart2, heart3;
    public GameObject apple_perfab, fence_perfab;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, rb.velocity.y, rb.velocity.z);
        if (apple > 50)
        {
            apple_perfab.GetComponent<Move>().speed = 13f;
            fence_perfab.GetComponent<Move>().speed = 11f;
        }
        else
        {
            apple_perfab.GetComponent<Move>().speed = 9f;
            fence_perfab.GetComponent<Move>().speed = 7f;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Apple")
        {
            Destroy(collision.gameObject);
            apple += 1;
        }
        if (collision.gameObject.tag == "Stena" && life == 0)
        {
            Destroy(collision.gameObject);
            life += 1;
            Destroy(heart1);
        }
        else if (collision.gameObject.tag == "Stena" && life == 1)
        {
            Destroy(collision.gameObject);
            life += 1;
            Destroy(heart2);
        }
        else if (collision.gameObject.tag == "Stena" && life == 2)
        {
            Destroy(collision.gameObject);
            life += 1;
            Destroy(heart3);
        }
    }
}
