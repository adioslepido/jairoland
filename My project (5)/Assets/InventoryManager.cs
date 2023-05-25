using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject InventoryMenu;
    bool menuActivated; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && menuActivated)
        {
            InventoryMenu.SetActive(false);
            menuActivated = false;
            Time.timeScale = 1;
            Debug.Log("ateo");
        }
        else if(Input.GetKeyDown(KeyCode.E) && !menuActivated) 
            { 
            InventoryMenu.SetActive(true);
            menuActivated= true;
            Time.timeScale = 0;
            Debug.Log("Amen");
        }
       
    }
}
