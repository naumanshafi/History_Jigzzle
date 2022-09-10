using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Arrow : MonoBehaviour
{
    // Start is called before the first frame update
    public static int flag = 0;
    private void OnMouseDown()
    {
        if(gameObject.name== "Arrow_Left")
        {
            SceneManager.LoadScene("Main_Select");
        }
        if (gameObject.name == "Arrow_Right")
        {
            SceneManager.LoadScene("Main_Select_2");
        }
        if (gameObject.name == "go_home")
        {
            SceneManager.LoadScene("Menu 3D");
        }
        if (gameObject.name == "give_up")
        {
            GameManager.game_status.status = Game_status.Game_stat.giveup;
            flag = 0;
        }
        if (gameObject.name == "menu")
        {
            SceneManager.LoadScene("Menu 3D");
            flag = 0;
        }
        if (gameObject.name == "play"&&flag==0)
        {
            GameManager.game_status.status = Game_status.Game_stat.start_pressed;
        }

    }
}
