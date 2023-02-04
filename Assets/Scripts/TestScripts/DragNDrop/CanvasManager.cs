using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    public PlantPrefab plant;
    public SlotPrefab slot;
    public List<GameObject> plantInstance;
    public List<GameObject> slotInstance;

    void Start()
    {
        for(int i=0; i<slot.pos.Count; i++)
        {
            var newSlot = Instantiate(slot.image, slot.pos[i], Quaternion.identity);
            slotInstance.Add(newSlot);
            newSlot.transform.SetParent(canvas.transform, false);
        }

        for(int i=0; i<plant.image.Count; i++)
        {
            var newPlant = Instantiate(plant.image[i], plant.pos[i], Quaternion.identity);
            plantInstance.Add(newPlant);
            newPlant.transform.SetParent(canvas.transform, false);
        }
    }

    void Update()
    {
        for(int i=0; i<plantInstance.Count; i++)
        {
            if(plantInstance[i].transform.position == slotInstance[plant.target[i]].transform.position)
            {
                Debug.Log("FUNCIONAAA");
                Debug.Log(i);
                Debug.Log(plant.target[i]);
            }
        }
    }
}
