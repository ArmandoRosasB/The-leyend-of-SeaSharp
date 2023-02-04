using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDiary : MonoBehaviour
{
    public Image image;
    
    public void ChangeOpacity()
    {
        if(image)
        {
            image.enabled = !image.enabled;
        }
        else
        {
            image.enabled = !image.enabled;
        }
    }
}
