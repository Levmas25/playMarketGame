using UnityEngine;

public class TubeSpawn : MonoBehaviour
{
    public GameObject tube_perfab;
    public float spawnSpeed;
    public float pos_x, pos_y, pos_z;
    public int scale, start, end;

    public GameObject money_perfab;
    public int up;

    void Start()
    {
        InvokeRepeating("TubesSpawn", 1, spawnSpeed);
        if (money_perfab != null)
            InvokeRepeating("MoneySpawn", 1, spawnSpeed);
    }

    void Update()
    {
        scale = Random.Range(start, end);
    }

    void TubesSpawn()
    {
        GameObject tube = Instantiate(tube_perfab);
        Transform transform = tube.GetComponent<Transform>();
        transform.localScale = new Vector3(transform.localScale.x, scale, transform.localScale.z);
        tube.transform.position = new Vector3(pos_x, pos_y, pos_z);
    }

    void MoneySpawn()
    {
        GameObject money = Instantiate(money_perfab);
        money.transform.position = new Vector3(pos_x, pos_y + scale + up, pos_z);
    }
}
