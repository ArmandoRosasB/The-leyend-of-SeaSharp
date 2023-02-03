using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public int level;
    private gameManager GameManager;

    private void Start()
    {
        GameManager = gameManager.Instance;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            GameManager.buttonFlags.Active2 = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + level);

        }
    } 
}
