using UnityEngine;
using UnityEngine.UI;

public class MoneyCount : MonoBehaviour
{
    public GameObject player;
    public Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }
    private void Update()
    {
        text.text = player.GetComponent<Player>().money.ToString();
    }
}
