using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Transform start_trans;
    public int apple;
    public float normal_speed, speed;
    public Rigidbody rb;
    public GameObject heart1, heart2, heart3;
    public GameObject apple_perfab, fence_perfab;
    public AudioSource sound;
    public AudioSource delFence;
    public AudioSource delHeart;
    public AudioSource delApple;
    public AudioSource touch;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        start_trans = transform;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(rb.velocity.x + speed, rb.velocity.y, rb.velocity.z);
        if (apple > 50)
        {
            apple_perfab.GetComponent<Move>().speed = 25f;
            fence_perfab.GetComponent<Move>().speed = 20f;
        }
        else
        {
            apple_perfab.GetComponent<Move>().speed = 15f;
            fence_perfab.GetComponent<Move>().speed = 13f;
        }

        if (apple == 100)
            SceneManager.LoadScene(2);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Apple")
        {
            delApple.Play();
            Destroy(collision.gameObject);
            apple += 1;
        }
        if (collision.gameObject.tag == "Stena" && heart1 != null)
        {
            Destroy(collision.gameObject);
            Destroy(heart1);
            sound.Play();
            delFence.Play();
            delHeart.Play();
        }
        else if (collision.gameObject.tag == "Stena" && heart1 == null && heart2 != null)
        {
            Destroy(collision.gameObject);
            Destroy(heart2);
            sound.Play();
            delFence.Play();
            delHeart.Play();
        }
        else if (collision.gameObject.tag == "Stena" && heart1 == null && heart2 == null)
        {
            Destroy(collision.gameObject);
            sound.Play();
            delFence.Play();
            delHeart.Play();
            SceneManager.LoadScene("First");
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
