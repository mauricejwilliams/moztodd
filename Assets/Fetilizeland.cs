using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Fetilizeland : MonoBehaviour
{
    public GameObject Mud;
    public GameObject tillered;

 

    public void tillerMud (bool yes) 
    {
        if (yes)
        {
            Mud.SetActive(false);
            tillered.SetActive(true);
        }      
    }

    public void Addseed(GameObject seed)
    {


    }


}
