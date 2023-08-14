using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildSystem : MonoBehaviour
{

    public Transform shootingPoint;
    public GameObject blockObject;

    public Transform parent;

    public Color normalColor;
    public Color highlightedColor;
    public bool selectOneTime = false;
    GameObject lastHightlightedBlock;

    public GameObject WoodObject;
    public GameObject StoneObject;
    public GameObject GrassObject;
    public GameObject MudObject;

    public void Start()
    {

    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var items = GetComponent<Items>();
            if (items.ItemSelected == 0)
            {
                
            }
            if (items.ItemSelected == 1)
            {
                BuildBlock(WoodObject);
            }
            if (items.ItemSelected == 2)
            {
                BuildBlock(StoneObject);
            }
            if (items.ItemSelected == 3)
            {
                BuildBlock(GrassObject);
            }
            if (items.ItemSelected == 4)
            {
                BuildBlock(MudObject);
            }

        }
        if (Input.GetMouseButtonDown(1))
        {
            DestroyBlock();
        }
        HighlightBlock();
    }

    void BuildBlock(GameObject block)
    {
        if (Physics.Raycast(shootingPoint.position, shootingPoint.forward, out RaycastHit hitInfo))
        {

            if (hitInfo.transform.tag == "Block")
            {
                Vector3 spawnPosition = new Vector3(Mathf.RoundToInt(hitInfo.point.x + hitInfo.normal.x / 2), Mathf.RoundToInt(hitInfo.point.y + hitInfo.normal.y / 2), Mathf.RoundToInt(hitInfo.point.z + hitInfo.normal.z / 2));
                Instantiate(block, spawnPosition, Quaternion.identity, parent);
            }
            else
            {
                Vector3 spawnPosition = new Vector3(Mathf.RoundToInt(hitInfo.point.x), Mathf.RoundToInt(hitInfo.point.y), Mathf.RoundToInt(hitInfo.point.z));
                Instantiate(block, spawnPosition, Quaternion.identity, parent);
            }
        }
    }

    void DestroyBlock()
    {
        if (Physics.Raycast(shootingPoint.position, shootingPoint.forward, out RaycastHit hitInfo))
        {
            if (hitInfo.transform.tag == "Block")
            {
                Destroy(hitInfo.transform.gameObject);
            }
        }
    }

    void HighlightBlock()
    {
        if (Physics.Raycast(shootingPoint.position, shootingPoint.forward, out RaycastHit hitInfo))
        {


            if (hitInfo.transform.tag == "Block")
            {
                if (selectOneTime == false && lastHightlightedBlock == null)
                {
                    normalColor = hitInfo.transform.gameObject.GetComponent<Renderer>().material.color;
                    lastHightlightedBlock = hitInfo.transform.gameObject;
                   // hitInfo.transform.gameObject.GetComponent<Renderer>().material.color = highlightedColor;
                    selectOneTime = true;
                }

            }
             else 
                                {
                if (lastHightlightedBlock != null)
                {
                    lastHightlightedBlock.GetComponent<Renderer>().material.color = normalColor;
                    lastHightlightedBlock = null;
                    selectOneTime = false;
                }
             }
            

            }
        }
    }
