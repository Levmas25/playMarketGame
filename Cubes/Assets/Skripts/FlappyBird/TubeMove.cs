using UnityEngine;
using UnityEngine.SceneManagement;

public class TubeMove : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed * Time.deltaTime);
        if (transform.position.z < 12)
            Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.tag == "Player")
            //SceneManager.LoadScene("First");
    }
}
