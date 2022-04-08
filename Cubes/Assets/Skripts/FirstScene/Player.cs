using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int apple;
    public float normal_speed, speed;
    public Rigidbody rb;
    public GameObject heart1, heart2, heart3;
    public GameObject apple_perfab, fence_perfab;
    private AudioSource sound;
    public AudioSource delFence;
    public AudioSource delHeart;
    public AudioSource delApple;
    public AudioSource touch;
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
            apple_perfab.GetComponent<Move>().speed = 17f;
            fence_perfab.GetComponent<Move>().speed = 15f;
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
        touch.Play();
        speed = normal_speed;
    }

    public void OnLeftButtonDown()
    {
        touch.Play();
        speed = -normal_speed;
    }

    public void ButtonUp()
    {
        touch.Play();
        speed = 0f;
    }
}
