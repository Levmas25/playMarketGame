using UnityEngine;

public class TubeSpawn : MonoBehaviour
{
    public GameObject lower_perfab;
    public GameObject upper_perfab;
    public float spawnSpeed;
    public float pos_x, pos_z;

    public float upper_y, upper_start, upper_end, upper_scale;
    public float lower_y, lower_start, lower_end, lower_scale;

    private BoxCollider lower_collider;

    public GameObject coin_perfab;
    public float coin_up;
    public float coin_start, coin_end;

    private void Start()
    {
        InvokeRepeating("LowerSpawn", 1, spawnSpeed);
        InvokeRepeating("UpperSpawn", 1, spawnSpeed);
        InvokeRepeating("CoinSpawn", 1, spawnSpeed);
    }

    private void Update()
    {
        upper_scale = Random.Range(upper_start, upper_end);
        lower_scale = Random.Range(lower_start, lower_end);
        coin_up = Random.Range(coin_start, coin_end);
    }

    void UpperSpawn()
    {
        GameObject upper = Instantiate(upper_perfab);
        upper.transform.localScale = new Vector3(upper.transform.localScale.x, upper_scale, upper.transform.localScale.z);
        upper.transform.localPosition = new Vector3(pos_x, upper_y, pos_z);
    }

    void LowerSpawn()
    {
        GameObject lower = Instantiate(lower_perfab);
        lower.transform.localScale = new Vector3(lower.transform.localScale.x, lower_scale, lower.transform.localScale.z);
        lower.transform.position = new Vector3(pos_x, lower_y, pos_z);
        lower_collider = lower.GetComponent<BoxCollider>();
    }

    void CoinSpawn()
    {
        GameObject coin = Instantiate(coin_perfab);
        coin.transform.position = new Vector3(pos_x, lower_y + lower_scale + coin_up + lower_collider.size.y, pos_z);
    }
}
