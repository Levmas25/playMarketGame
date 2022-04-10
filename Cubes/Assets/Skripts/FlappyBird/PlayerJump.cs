using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerJump : MonoBehaviour
{
    Rigidbody player;
    public float force;
    public int speed;
    public int points;
    private Animation anim;
    public AudioSource fly;
    public AudioSource money;
    void Start()
    {
        player = GetComponent<Rigidbody>();
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.AddForce(new Vector3(0, force, 0));
            anim.Play();
            fly.Play();
        }

        foreach(var touch in Input.touches)
        {
            if(touch.phase == TouchPhase.Began && EventSystem.current.IsPointerOverGameObject(touch.fingerId) == false)
            {
                player.AddForce(new Vector3(0, force, 0));
                anim.Play();
                fly.Play();
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            money.Play();
            points++;
        }
        if (collision.gameObject.tag == "Tube")
            SceneManager.LoadScene("FlappyBird");
        if (collision.gameObject.tag == "Ground")
            SceneManager.LoadScene("FlappyBird");
    }
}
