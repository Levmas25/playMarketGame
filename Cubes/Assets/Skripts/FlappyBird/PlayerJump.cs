using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody player;
    public float force;
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            player.AddForce(Vector3.up * force, ForceMode.Impulse);
    }
}
