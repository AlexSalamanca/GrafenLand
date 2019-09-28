using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public int woodValue;
    public int rockValue;
    public int woodStartValue = 50;
    public int rockStartValue = 50;

    public string woodTag = "Wood";
    public string rockTag = "Rock";



    // Use this for initialization
    void Start()
    {
        woodValue = woodStartValue;
        rockValue = rockStartValue;
    }

    // Update is called once per frame
    void Update () {
        GatherMaterials();
	}

    public void GatherMaterials()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if(Physics.Raycast(ray, out hitInfo))
            {
                if(hitInfo.collider.gameObject.tag == "Wood")
                {
                    Debug.Log("I am Wood");
                    woodValue += MatsValue.gatheredWoodValue;
                }
                else if(hitInfo.collider.gameObject.tag == rockTag)
                {
                    rockValue += MatsValue.gatheredRockValue;
                }
            }
        }
    }


}

