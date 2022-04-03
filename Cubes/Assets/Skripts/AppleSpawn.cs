using UnityEngine;

public class AppleSpawn : MonoBehaviour
{
    public GameObject apple, ashik_apple;
    public float start, end, pos_y, pos_z;
    public int random;
    void Start()
    {
        InvokeRepeating("Spawn", 1, 5);
    }

    private void FixedUpdate()
    {
        random = Random.Range(0, 10);
    }

    void Spawn()
    {
        GameObject gameObject = null;
        if (random > 5)
            gameObject = Instantiate(apple);
        else
            gameObject = Instantiate(ashik_apple);  
        gameObject.transform.position = new Vector3(Random.Range(start, end), pos_y, pos_z);
    }
}
