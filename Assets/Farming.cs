using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Farming : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject blockObject;
    private int items;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        items = GetComponent<Items>().ItemSelected;
        if (Input.GetMouseButtonDown(0) && items == 0)
        {
            PrepareSoil();
        }
    }


    void PrepareSoil()
    {
        
        
            if (Physics.Raycast(shootingPoint.position, shootingPoint.forward, out RaycastHit hitInfo))
            {

                if (hitInfo.transform.tag == "Block")
                {
                    GameObject hitObject = hitInfo.transform.gameObject;
                    hitObject.GetComponent<Fetilizeland>();
                    hitObject.GetComponent<Fetilizeland>().tillerMud(true);

                }
            }
        
    }




}
