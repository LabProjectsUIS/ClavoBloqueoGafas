using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour {

    private GameObject Camera;
    private GameObject Guia;
    private GameObject clavo;
    private GameObject sc;
    public GameObject cube;
    private float distance = 0.3f;

    // Use this for initialization
    void Start()
    {
        //Camera = GameObject.Find("GafasFrame");
        Guia = GameObject.Find("guia_model");
        clavo = GameObject.Find("clavomodel");
        sc = GameObject.Find("sc");
        Debug.Log("print");
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.F))
        {
            cube.transform.position = Camera.transform.position + Camera.transform.right * distance;
            Guia.transform.position = Camera.transform.position + Camera.transform.forward * distance;
            clavo.transform.position = Camera.transform.position + Camera.transform.forward * distance;
            sc.transform.position = Camera.transform.position + Camera.transform.forward * distance + Camera.transform.up*distance/100;
            sc.transform.rotation = new Quaternion(0.0f, Camera.transform.rotation.y, 0.0f, Camera.transform.rotation.w);
            Debug.Log("press F");
        }
       

    }

    // Start constructing an item
   /* public void StartConstructingItem(Item item)
    {
        Object itemPrefab = Resources.Load("Prefabs/" + item.prefabName);

        itemObject = (GameObject)Instantiate(itemPrefab);
    }*/
}
