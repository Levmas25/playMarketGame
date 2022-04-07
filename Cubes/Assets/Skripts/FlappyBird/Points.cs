using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        text.text = (player.GetComponent<PlayerJump>().points - 1).ToString();
    }
    void FixedUpdate()
    {
        if (player.GetComponent<PlayerJump>().points == 100)
        {
            SceneManager.LoadScene("End");
        }
    }
}
