using UnityEngine;

public class AppleSpawn : MonoBehaviour
{
    public GameObject apple;
    public float start, end, pos_y, pos_z;
    void Start()
    {
        InvokeRepeating("Spawn", 1, 5);
    }

    void Spawn()
    {
        GameObject coin = Instantiate(apple);
        coin.transform.position = new Vector3(Random.Range(start, end), pos_y, pos_z);
    }
}
