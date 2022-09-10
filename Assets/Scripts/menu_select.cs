using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_select : MonoBehaviour
{
    private GameObject arrow_left;
    private GameObject arrow_right;
    // Start is called before the first frame update
    void Start()
    {
        arrow_left = GameObject.Find("Arrow_Left");
        arrow_right= GameObject.Find("Arrow_Right");
        if(SceneManager.GetActiveScene().name== "menu_select")
        {
            arrow_left.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().name == "menu_select_2")
        {
            arrow_right.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
