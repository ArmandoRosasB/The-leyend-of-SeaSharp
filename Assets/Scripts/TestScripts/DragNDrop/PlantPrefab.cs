using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPlant", menuName = "Plants")]

public class PlantPrefab : ScriptableObject
{
    public List<GameObject> image;
    public List<Vector2> pos;
    public List<int> target;

    private void Update()
    {
        for(int i=0; i<image.Count; i++)
        {
            pos[i] = new Vector2(image[i].transform.position.x, image[i].transform.position.y);
        }
    }
}
