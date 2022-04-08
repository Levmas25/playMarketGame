using UnityEngine;
using UnityEngine.UI;

public class AppleCount : MonoBehaviour
{
    public GameObject player;
    public Text text;


    private void Start()
    {
        text = GetComponent<Text>();
    }
    private void Update()
    {
        text.text = player.GetComponent<Player>().apple.ToString();
    }
}
