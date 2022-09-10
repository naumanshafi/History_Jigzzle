using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Picture : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnMouseDown()
    {
        GameManager.folder_name = gameObject.name;
        SceneManager.LoadScene("GameScene");
    }
}
