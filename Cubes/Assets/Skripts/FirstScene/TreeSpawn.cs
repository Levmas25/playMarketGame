using UnityEngine;

public class TreeSpawn : MonoBehaviour
{
    public float start, end, pos_y, pos_z;
    public float seconds;
    public int pos;
    public GameObject tree_perfab;
    void Start()
    {
        InvokeRepeating("Spawn", 1, 7);
    }
    private void Update()
    {
        pos = Random.Range(0, 10000);
    }

    void Spawn()
    {
        GameObject tree = Instantiate(tree_perfab);
        if (pos > 5000)
            tree.transform.position = new Vector3(start, pos_y, pos_z);
        else if (pos > 4000 && pos < 6000)
        {
            tree.transform.position = new Vector3(start, pos_y, pos_z);
            GameObject tree2 = Instantiate(tree_perfab);
            tree2.transform.position = new Vector3(end, pos_y, pos_z);
        }

        else
            tree.transform.position = new Vector3(end, pos_y, pos_z);

    }
}
