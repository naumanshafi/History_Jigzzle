using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class Puzzle : MonoBehaviour
{
    // Start is called before the first frame update
    public bool click = false;
    public bool go_left=false;
    public bool go_right=false;
    public bool go_up=false;
    public bool go_down=false;

    public Vector2 move_amount;
    public bool move = false;

    public Vector3 win_position;
    public float scale_x = 0.09f;
    public float scale_y = 0.09f;
    public float scale_z = 0.09f;
    public Vector3 scale_backup;

    void Start()
    {
        scale_backup = transform.localScale;
        win_position = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        movepuzzle();
    }

    public void OnMouseDown()
    {
        Debug.Log("click tu hoa hai");
        click = true;
    }

    public void OnMouseUp()
    {
        click = false;
        move = false;
    }

    void movepuzzle()
    {
        if(go_left)
        {
            Debug.Log("left");
            transform.position = new Vector3(transform.position.x- 2.03f, transform.position.y,transform.position.z);
            go_left = false;
            move = true;
        }
        else if (go_right)
        {
            Debug.Log("**********");
            Debug.Log("right");
            transform.position = new Vector3(transform.position.x + 2.03f, transform.position.y, transform.position.z);
            go_right = false;
            move = true;
        }
        else if (go_up)
        {
            Debug.Log("-----------");
            Debug.Log("up");
            transform.position = new Vector3(transform.position.x, transform.position.y + 1.52f, transform.position.z);
            go_up = false;
            move = true;
        }
        else if (go_down)
        {
            Debug.Log("down");
            transform.position = new Vector3(transform.position.x , transform.position.y - 1.52f, transform.position.z);
            go_down = false;
            move = true;
        }
    }

   
}

