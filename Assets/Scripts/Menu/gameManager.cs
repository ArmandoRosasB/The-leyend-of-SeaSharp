using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static gameManager Instance; 
    public MainController buttonFlags;

    private void Awake()
    {
        if (gameManager.Instance == null)
    {
        gameManager.Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    else
    {
        Destroy(gameObject);
    }
    }

    
}
