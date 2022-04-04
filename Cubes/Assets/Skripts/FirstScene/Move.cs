using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Apple")
        {
            Destroy(collision.gameObject);
        }
    }
}
