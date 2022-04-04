using UnityEngine;

public class TubeSpawn : MonoBehaviour
{
    public GameObject tube_perfab;
    public float spawnSpeed;
    public float pos_x, pos_y, pos_z;
    public int scale, start, end;

    void Start()
    {
        InvokeRepeating("Spawn", 1, spawnSpeed);
    }

    void Update()
    {
        scale = Random.Range(start, end);
    }

    void Spawn()
    {
        GameObject tube = Instantiate(tube_perfab);
        Transform transform = tube.GetComponent<Transform>();
        transform.localScale = new Vector3(transform.localScale.x, scale, transform.localScale.z);
        tube.transform.position = new Vector3(pos_x, pos_y, pos_z);
    }
}
