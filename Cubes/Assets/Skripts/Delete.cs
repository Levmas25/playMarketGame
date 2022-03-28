using UnityEngine;

public class Delete : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Fake")
            Destroy(collision.gameObject);
    }
}
