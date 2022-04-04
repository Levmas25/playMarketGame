using UnityEngine;
using UnityEngine.SceneManagement;

public class SideWall : MonoBehaviour
{
    public GameObject heart1, heart2, heart3;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(heart1);
            Destroy(heart2);
            Destroy(heart3);
            SceneManager.LoadScene("First");
        }
            
    }
}
