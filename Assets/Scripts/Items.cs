using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour
{

    public bool mouseOnOff = true;

    public int ItemSelected = 0;
    public int wood = 1;
    public int stone = 2;
    public int Grass = 3;
    public int Mud = 4;

    public Text ChosenItem;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerStats playerStats = GetComponent<PlayerStats>();
        if (playerStats.CurrentHealth > 0)
        {
            
               // Cursor.visible = false;
               // Cursor.lockState = CursorLockMode.Locked;
         }
            else
            {
               // Cursor.visible = true;
               // Cursor.lockState = CursorLockMode.None;
            }
        

        




        if (ItemSelected == 0)
        {
            ChosenItem.text = "None";
        }
        if (ItemSelected == 1)
        {
            ChosenItem.text = "Wood";
        }
        if (ItemSelected == 2)
        {
            ChosenItem.text = "Stone";
        }
        if (ItemSelected == 3)
        {
            ChosenItem.text = "Grass";
        }
        if (ItemSelected == 4)
        {
            ChosenItem.text = "Mud";
        }


        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ItemSelected += 1;
        }
        if (ItemSelected >= 5)
        {
            ItemSelected = 0;
        }
    }
}
