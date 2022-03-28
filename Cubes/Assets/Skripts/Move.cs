using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 7f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed * Time.deltaTime);
    }
}
