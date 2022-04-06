using UnityEngine;

public class FenceSpawn : MonoBehaviour
{
    public GameObject fence_perfab;
    public GameObject player;
    public float seconds;
    public float start, end, pos_y, pos_z;

    void Start()
    {
        InvokeRepeating("Spawn", 1, seconds);
    }

    void Spawn()
    {
        GameObject gameObject = Instantiate(fence_perfab);
        gameObject.transform.position = new Vector3(Random.Range(start, end), pos_y, pos_z);
    }
}
