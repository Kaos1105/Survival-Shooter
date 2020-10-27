using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public float restartDelay = 5f;
    public Text scoreText;


    Animator anim;
    float restartTimer;

    void Awake()
    {
        anim = GetComponent<Animator>();
        
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            restartTimer += Time.deltaTime;
            anim.SetTrigger("GameOver");
            if (restartTimer >= restartDelay)
            {
                SceneManager.LoadScene("Level01");
            }
        }
    }
}
