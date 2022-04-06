using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerJump : MonoBehaviour
{
    Rigidbody player;
    public float force;
    public int speed;
    public int points;
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            player.AddForce(new Vector3(0, force, 0));
        foreach(var touch in Input.touches)
        {
            if(touch.phase == TouchPhase.Began)
            {
                player.AddForce(new Vector3(0, force, 0));
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            points++;
        }
        //if (collision.gameObject.tag == "Tube")
        //SceneManager.LoadScene("FlappyBird");
    }
}
