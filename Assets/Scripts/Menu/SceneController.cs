using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private Button lvl2;
    private Button lvl3;
    private gameManager GameManager;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = gameManager.Instance;
        lvl2 = GameObject.FindWithTag("Level_2").GetComponent<Button>();
        lvl3 = GameObject.FindWithTag("Level_3").GetComponent<Button>();


        lvl2.interactable = GameManager.buttonFlags.Active2;
        lvl3.interactable =  GameManager.buttonFlags.Active3;

    }

    // Update is called once per frame
  
    public void goLevelOne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void goLevelTwo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void goLevelThree()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

}
