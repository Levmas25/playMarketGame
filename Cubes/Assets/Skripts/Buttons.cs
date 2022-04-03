using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject player;
    public float speed;

    public void Left()
    {
        player.transform.position -= new Vector3(speed, 0 ,0);
    }

    public void Right()
    {
        player.transform.position += new Vector3(speed, 0, 0);
    }
}
