using UnityEngine;

public class Player : MonoBehaviour
{
    public int apple, life;
    public float normal_speed, speed;
    public Rigidbody rb;
    public GameObject heart1, heart2, heart3;
    public GameObject apple_perfab, fence_perfab;
    private AudioSource sound;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        sound = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(rb.velocity.x + speed, rb.velocity.y, rb.velocity.z);
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
            sound.Play();
        }
        else if (collision.gameObject.tag == "Stena" && life == 1)
        {
            Destroy(collision.gameObject);
            life += 1;
            Destroy(heart2);
            sound.Play();
        }
        else if (collision.gameObject.tag == "Stena" && life == 2)
        {
            Destroy(collision.gameObject);
            life += 1;
            Destroy(heart3);
            sound.Play();
        }
    }

    public void OnRightButtonDown()
    {
        speed = normal_speed;
    }

    public void OnLeftButtonDown()
    {
        speed = -normal_speed;
    }

    public void ButtonUp()
    {
        speed = 0f;
    }
}
