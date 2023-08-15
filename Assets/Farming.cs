using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Farming : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject blockObject;


    void Start()
    {
       
    }
    /*
    // Update is called once per frame
    void Update()
    {

        var items = GetComponent<Items>().ItemSelected;
        if (Input.GetMouseButtonDown(0) && items == 0)
        {
            if (Physics.Raycast(shootingPoint.position, shootingPoint.forward, out RaycastHit hitInfo))
            {

                if (hitInfo.transform.tag == "Block")
                {
                    var hit = hitInfo.transform.gameObject;

                    hit.GetComponent<Fetilizeland>().tillerMud(true);

                }
            }
        }
    }
    */

    void PrepareSoil()
    {
        
        
      
        
    }




}
