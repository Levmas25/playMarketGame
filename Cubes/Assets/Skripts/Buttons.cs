using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject player;
    public float speed;

    public void Left()
    {
        player.transform.position += Vector3.left * speed * Time.deltaTime;
    }

    public void Right()
    {
        player.transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
