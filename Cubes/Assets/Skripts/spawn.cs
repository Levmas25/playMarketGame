using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject cube;
    public float start, end, pos_y, pos_z;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Spawn", 1, 3);
    }

    // Update is called once per frame
    void Spawn()
    {
        GameObject gameObject = Instantiate(cube);
        gameObject.SetActive(true);
        gameObject.tag = "Stena";
        gameObject.AddComponent<Move>();
        gameObject.transform.position = new Vector3(Random.Range(start, end), pos_y, pos_z);
    }
}
