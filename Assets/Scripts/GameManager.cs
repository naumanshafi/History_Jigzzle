using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager: MonoBehaviour
{
    [HideInInspector]
    public set_text set;
    public Puzzle puzzle_prefab;
    private List<Puzzle> puzzle_prefabe_list=new List<Puzzle>();
    private List<Vector3> puzzlePosition = new List<Vector3>();
    private List<int> random_num = new List<int>();

    private Vector2 start_position = new Vector2(-3.55f,1.77f);
    private Vector2 offset = new Vector2(2.03f,1.52f);

    public LayerMask collisionMask;
    Ray ray_up,ray_down,ray_right,ray_left;
    RaycastHit hit;
    private BoxCollider collider1;
    private Vector3 collider_size;
    private Vector3 collider_center;

    [HideInInspector]
    public static string folder_name;

    [HideInInspector]
    public GameObject FullPicture;
    public static Game_status game_status = new Game_status();

    // Start is called before the first frame update

    void Start()
    {
        spawnpuzzle(15);
        SetStartPosition();
        //apply_material();
    }
    // Update is called once per frame
    void Update()
    { 
            switch (game_status.status)
            {
                case Game_status.Game_stat.start:

                apply_material();
                break;

                case Game_status.Game_stat.start_pressed:
                    mix_puzzle();
                    game_status.status = Game_status.Game_stat.play;
                    Arrow.flag = 1;
                    break;

                case Game_status.Game_stat.play:
                    if(haswewon()==true)
                    {
                        game_status.status = Game_status.Game_stat.win;
                    }
                    move_puzzle();
                    break;

            case Game_status.Game_stat.win:
                SceneManager.LoadScene("History");
                game_status.status = Game_status.Game_stat.start;
                break;

            case Game_status.Game_stat.giveup:
                for (int i = 0; i < puzzle_prefabe_list.Count; i++)
                {
                    puzzle_prefabe_list[i].transform.position = puzzlePosition[i];
                }
                set_puzzle_on_start(true);
                game_status.status = Game_status.Game_stat.start;
                SceneManager.LoadScene("History");
                break;


        }
    }    
    
    private void spawnpuzzle(int number)
    {
        for (int i = 0; i < number; i++)
        {
            puzzle_prefabe_list.Add(Instantiate(puzzle_prefab, new Vector3(0.0f, 0.0f, 0.0f), new Quaternion(0.0f,0.0f,180.0f,0.0f)) as Puzzle);
        }
    }

    void SetStartPosition()
    {
        puzzle_prefabe_list[0].transform.position = new Vector3(start_position.x, start_position.y, 0.0f);
        puzzle_prefabe_list[1].transform.position = new Vector3(start_position.x + offset.x, start_position.y, 0.0f);
        puzzle_prefabe_list[2].transform.position = new Vector3(start_position.x + (2 * offset.x), start_position.y, 0.0f);

        puzzle_prefabe_list[3].transform.position = new Vector3(start_position.x, start_position.y - offset.y, 0.0f);
        puzzle_prefabe_list[4].transform.position = new Vector3(start_position.x + offset.x, start_position.y - offset.y, 0.0f);
        puzzle_prefabe_list[5].transform.position = new Vector3(start_position.x + (2 * offset.x), start_position.y - offset.y, 0.0f);
        puzzle_prefabe_list[6].transform.position = new Vector3(start_position.x + (3 * offset.x), start_position.y - offset.y, 0.0f);

        puzzle_prefabe_list[7].transform.position = new Vector3(start_position.x, start_position.y - (2 * offset.y), 0.0f);
        puzzle_prefabe_list[8].transform.position = new Vector3(start_position.x + offset.x, start_position.y - (2 * offset.y), 0.0f);
        puzzle_prefabe_list[9].transform.position = new Vector3(start_position.x + (2 * offset.x), start_position.y - (2 * offset.y), 0.0f);
        puzzle_prefabe_list[10].transform.position = new Vector3(start_position.x + (3 * offset.x), start_position.y - (2 * offset.y), 0.0f);

        puzzle_prefabe_list[11].transform.position = new Vector3(start_position.x, start_position.y - (3 * offset.y), 0.0f);
        puzzle_prefabe_list[12].transform.position = new Vector3(start_position.x + offset.x, start_position.y - (3 * offset.y), 0.0f);
        puzzle_prefabe_list[13].transform.position = new Vector3(start_position.x + (2 * offset.x), start_position.y - (3 * offset.y), 0.0f);
        puzzle_prefabe_list[14].transform.position = new Vector3(start_position.x + (3 * offset.x), start_position.y - (3 * offset.y), 0.0f);
    }

    void move_puzzle()
    {
        foreach(Puzzle puzle_prefab in puzzle_prefabe_list)
        {
            puzzle_prefab.move_amount = offset; 

            if(puzle_prefab.click)
            {
                collider1 = puzzle_prefab.GetComponent<BoxCollider>();
                collider_size = collider1.size;
                collider_center = collider1.center;

                float move_amount = offset.x;
                float direction = Mathf.Sign(move_amount);

                float x = (puzle_prefab.transform.position.x + collider_center.x - collider_size.x / 2) + collider_size.x / 2;
                float y_up = puzle_prefab.transform.position.y + collider_center.y + collider_size.y / 2 *direction;
                float y_down = puzle_prefab.transform.position.y + collider_center.y + collider_size.y / 2 * -direction;

                ray_up = new Ray(new Vector2(x,y_up),new Vector2(0f,direction));
                ray_down = new Ray(new Vector2(x, y_down), new Vector2(0f, -direction));

                Debug.DrawRay(ray_up.origin,ray_up.direction);
                Debug.DrawRay(ray_down.origin, ray_down.direction);

                float y = (puzle_prefab.transform.position.y + collider_center.y - collider_size.y / 2) + collider_size.y / 2;
                float x_right = puzle_prefab.transform.position.x + collider_center.x + collider_size.x / 2 * direction;
                float x_left= puzle_prefab.transform.position.x + collider_center.x + collider_size.x / 2 * -direction;

                ray_left = new Ray(new Vector2(x_left, y), new Vector2(-direction,0f));
                ray_right = new Ray(new Vector2(x_right, y), new Vector2(direction,0f));

                Debug.DrawRay(ray_left.origin, ray_left.direction);
                Debug.DrawRay(ray_right.origin, ray_right.direction);
                //Debug.Log(puzle_prefab.transform.position.y);
                //Debug.Log(start_position.y);
                if (Physics.Raycast(ray_up, out hit, 1.0f, collisionMask) == false && (puzle_prefab.move == false) && (puzle_prefab.transform.position.y < start_position.y))
                {
                    Debug.Log("Move up Allowed");
                    puzle_prefab.go_up = true;
                }
                else if (Physics.Raycast(ray_left, out hit, 1.0f, collisionMask) == false && (puzle_prefab.move == false) && (puzle_prefab.transform.position.x > start_position.x))
                {
                    Debug.Log("Move left Allowed");
                    puzle_prefab.go_left = true;
                }
                else if (Physics.Raycast(ray_right, out hit, 1.0f, collisionMask) == false && (puzle_prefab.move == false) && (puzle_prefab.transform.position.x < start_position.x + 3 * offset.x))
                {
                    Debug.Log("Move right Allowed");
                    puzle_prefab.go_right = true;
                }
                else if (Physics.Raycast(ray_down, out hit, 1.0f, collisionMask) == false && (puzle_prefab.move == false) && puzle_prefab.transform.position.y > (start_position.y - 3 * offset.y))
                {
                    Debug.Log("Move down Allowed");
                    puzle_prefab.go_down = true;
                }
            }
        }
    }

    void  apply_material()
    {
        string filepath;
        for (int i = 1; i <= puzzle_prefabe_list.Count; i++)
        {
            if (i > 3)
            {
                filepath = "PuzzleGameGraphics/" + "Puzzles/" + folder_name + "/Cube" + (i + 1);
            }
            else
            {
                filepath = "PuzzleGameGraphics/" + "Puzzles/" + folder_name + "/Cube" + i;
            }
            Texture2D mat = Resources.Load(filepath, typeof(Texture2D)) as Texture2D;
            puzzle_prefabe_list[i-1].GetComponent<Renderer>().material.mainTexture = mat;
        }

        filepath = "PuzzleGameGraphics/" + "Puzzles/" + folder_name + "/pic";
        Texture2D mat1 = Resources.Load(filepath, typeof(Texture2D)) as Texture2D;
        FullPicture.GetComponent<Renderer>().material.SetTexture("_MainTex",mat1);
    }

    void mix_puzzle()
    {
        int number;
        foreach (Puzzle p in puzzle_prefabe_list)
        {
            puzzlePosition.Add(p.transform.position); 
        }

        foreach (Puzzle p in puzzle_prefabe_list)
        {
            number = Random.Range(0, puzzle_prefabe_list.Count);
            while(random_num.Contains(number))
            {
                number = Random.Range(0, puzzle_prefabe_list.Count);
            }
            random_num.Add(number);
            p.transform.position = puzzlePosition[number];
        }
    }

    bool haswewon()
    {
        foreach (Puzzle p in puzzle_prefabe_list)
        {
            if(p.transform.position!=p.win_position)
            {
                return false;
            }

        }
        return true;
    }

    void set_puzzle_on_start(bool giveup)
    {
        Debug.Log("gya kai nai");
        StartCoroutine(move_position(2.2f,giveup));
    }
    IEnumerator move_position(float delay_time,bool giveup)
    {
        for (int i = 0; i < puzzle_prefabe_list.Count; i++)
        {
            for (float timer = 0; timer < delay_time; timer+=Time.deltaTime)
            {
                Debug.Log("aya kai nai");
                puzzle_prefabe_list[i].transform.localScale = new Vector3(puzzle_prefabe_list[i].scale_backup.x + puzzle_prefabe_list[i].scale_x, puzzle_prefabe_list[i].scale_backup.y + puzzle_prefabe_list[i].scale_y, puzzle_prefabe_list[i].transform.localScale.z);
                yield return 0;
            }
        }
    }
}
