using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    public PlantPrefab plant;
    public SlotPrefab slot;

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<slot.pos.Count; i++)
        {
            var newSlot = Instantiate(slot.image, slot.pos[i], Quaternion.identity);
            newSlot.transform.SetParent(canvas.transform, false);
        }

        for(int i=0; i<plant.image.Count; i++)
        {
            var newPlant = Instantiate(plant.image[i], plant.pos[i], Quaternion.identity);
            newPlant.transform.SetParent(canvas.transform, false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(plant.transform.position);
        for(int i=0; i<plant.image.Count; i++)
        {
            Debug.Log(plant.image[i].transform.position);
            /*if(plant.pos[i] == slot.pos[plant.target[i]])
            {
                Debug.Log("FUNCIONAAA");
            }*/
        }
    }
}

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.EventSystems;

public class CanvasManager : MonoBehaviour
{
    public GameObject slot;
    public GameObject player;
    [SerializeField] private Canvas canvas;

    private List<GameObject> itemSlots;
    private GameObject playerItem;

    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<3; i++)
        {
            for(int j=0; j<3; j++)
            {
                var newSlot = Instantiate(slot, new Vector2(700 + (i * 330), 300 + (j * 330)), Quaternion.identity) as GameObject;
                newSlot.transform.SetParent(canvas.transform, false);

                itemSlots.Add(newSlot);
            }
        }

        var newPlayer = Instantiate(player, new Vector2(600, 300), Quaternion.identity) as GameObject;
        newPlayer.transform.SetParent(canvas.transform, false);
        playerItem = newPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        *if(itemSlots[0].transform.position == playerItem.transform.position)
        {
            Debug.Log("FUNCIONAAAAAA");
        }/*
    }
}*/
