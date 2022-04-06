using UnityEngine;

public class TubeSpawn : MonoBehaviour
{
    public GameObject tube_perfab;
    public float spawnSpeed;
    public float pos_x, pos_y, pos_z;
    public int scale, start, end;
    private BoxCollider collider;
    private Transform trans;

    public GameObject money_perfab;
    public int up;
    public int money_start, money_end;

    void Start()
    {
        InvokeRepeating("TubesSpawn", 1, spawnSpeed);
        if (money_perfab != null)
            InvokeRepeating("MoneySpawn", 1, spawnSpeed);
    }

    void Update()
    {
        scale = Random.Range(start, end);
        up = Random.Range(money_start, money_end);
    }

    void TubesSpawn()
    {
        GameObject tube = Instantiate(tube_perfab);
        Transform transform = tube.GetComponent<Transform>();
        transform.localScale = new Vector3(transform.localScale.x, scale, transform.localScale.z);
        tube.transform.position = new Vector3(pos_x, pos_y, pos_z);
        collider = tube.GetComponent<BoxCollider>();
        trans = tube.GetComponent<Transform>();
    }

    void MoneySpawn()
    {
        GameObject money = Instantiate(money_perfab);
        money.transform.position = new Vector3(pos_x,pos_y + collider.size.y + trans.localScale.y + scale + up, pos_z);
    }
}
