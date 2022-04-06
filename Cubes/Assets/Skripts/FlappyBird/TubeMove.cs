using UnityEngine;

public class TubeMove : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed * Time.deltaTime);
        if (transform.position.z < 12)
            Destroy(gameObject);
    }
}
