using UnityEngine;

public class MoneySpawn : MonoBehaviour
{
    public GameObject moneySpawn;
    public float start, end, pos_y, pos_z;
    void Start()
    {
        InvokeRepeating("Spawn", 1, 3);
    }

    void Spawn()
    {
        GameObject coin = Instantiate(moneySpawn);
        coin.SetActive(true);
        coin.tag = "Coin";
        coin.AddComponent<Move>();
        coin.transform.position = new Vector3(Random.Range(start, end), pos_y, pos_z);
    }
}
