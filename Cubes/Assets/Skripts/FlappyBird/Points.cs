using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public GameObject player;
    public Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = (player.GetComponent<PlayerJump>().points / 2).ToString();
    }
}
