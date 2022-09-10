using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_status : MonoBehaviour
{
    public enum Game_stat
    {
        start,
        start_pressed,
        play,
        win,
        giveup,
    }

    public Game_stat status;

    public Game_status()
    {
        status = Game_stat.start;
    }
}
