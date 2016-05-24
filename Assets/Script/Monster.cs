using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour
{
    //dir in c# array: 1 = up, 2 = right, 3 = down, 4 = left
    //dir in game: 1 = left, 2 = up, 3 = right, 4 = down
    private int[,] maze = GameObject.Find("GameMenager").GetComponent<GameMenager>().getMaze();// = Maze.maze;
    int x = 1, y = 1, dir = 1, r, move = 0;
    int speed = 4; //divide speed

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //for slower walking
        if (move == speed)
        {
            switch (dir)
            {
                case 1://direction is up
                       //crossroads with path in direction
                    if (maze[x - 1, y] == 1)
                    {
                        if (maze[x, y - 1] == 0 && maze[x, y + 1] == 0)
                        {
                            x--;
                        }
                        else
                        {
                            if (maze[x, y - 1] == 1 && maze[x, y + 1] == 1)
                            {
                                r = UnityEngine.Random.Range(0, 3);
                                switch (r)
                                {
                                    case 0:
                                        x--;
                                        break;
                                    case 1:
                                        dir = 2;
                                        y++;
                                        break;
                                    case 2:
                                        dir = 4;
                                        y--;
                                        break;
                                    default:
                                        //?
                                        break;
                                }
                            }
                            else
                            {
                                if (maze[x, y - 1] == 1)
                                {
                                    r = UnityEngine.Random.Range(0, 2);
                                    if (r == 1)
                                    {
                                        x--;
                                    }
                                    else if (r == 0)
                                    {
                                        dir = 4;
                                        y--;
                                    }
                                }
                                else if (maze[x, y + 1] == 1)
                                {
                                    r = UnityEngine.Random.Range(0, 2);
                                    if (r == 1)
                                    {
                                        x--;
                                    }
                                    else if (r == 0)
                                    {
                                        dir = 2;
                                        y++;
                                    }
                                }
                            }
                        }
                    }
                    //crossroads with wall in direction
                    else
                    {
                        if (maze[x, y - 1] == 0 && maze[x, y + 1] == 0)
                        {
                            dir = 3;
                            x++;
                        }
                        else
                        {
                            if (maze[x, y - 1] == 1 && maze[x, y + 1] == 1)
                            {
                                r = UnityEngine.Random.Range(0, 2);
                                if (r == 1)
                                {
                                    dir = 2;
                                    y++;
                                }
                                else if (r == 0)
                                {
                                    dir = 4;
                                    y--;
                                }
                            }
                            else
                            {
                                if (maze[x, y - 1] == 1)
                                {
                                    dir = 4;
                                    y--;
                                }
                                else if (maze[x, y + 1] == 1)
                                {
                                    dir = 2;
                                    y++;
                                }
                            }

                        }
                    }
                    break;
                //-----------------------------------------------------------
                case 2://direction is right
                       //crossroads with path in direction
                    if (maze[x, y + 1] == 1)
                    {
                        if (maze[x - 1, y] == 0 && maze[x + 1, y] == 0)
                        {
                            y++;
                        }
                        else
                        {
                            if (maze[x - 1, y] == 1 && maze[x + 1, y] == 1)
                            {
                                r = UnityEngine.Random.Range(0, 3);
                                switch (r)
                                {
                                    case 0:
                                        y++;
                                        break;
                                    case 1:
                                        dir = 1;
                                        x--;
                                        break;
                                    case 2:
                                        dir = 3;
                                        x++;
                                        break;
                                    default:
                                        //?
                                        break;
                                }
                            }
                            else
                            {
                                if (maze[x - 1, y] == 1)
                                {
                                    r = UnityEngine.Random.Range(0, 2);
                                    if (r == 1)
                                    {
                                        y++;
                                    }
                                    else if (r == 0)
                                    {
                                        dir = 1;
                                        x--;
                                    }
                                }
                                else if (maze[x + 1, y] == 1)
                                {
                                    r = UnityEngine.Random.Range(0, 2);
                                    if (r == 1)
                                    {
                                        y++;
                                    }
                                    else if (r == 0)
                                    {
                                        dir = 3;
                                        x++;
                                    }
                                }
                            }
                        }
                    }
                    //crossroads with wall in direction
                    else
                    {
                        if (maze[x - 1, y] == 0 && maze[x + 1, y] == 0)
                        {
                            dir = 4;
                            y--;
                        }
                        else
                        {
                            if (maze[x - 1, y] == 1 && maze[x + 1, y] == 1)
                            {
                                r = UnityEngine.Random.Range(0, 2);
                                if (r == 1)
                                {
                                    dir = 1;
                                    x--;
                                }
                                else if (r == 0)
                                {
                                    dir = 3;
                                    x++;
                                }
                            }
                            else
                            {
                                if (maze[x - 1, y] == 1)
                                {
                                    dir = 1;
                                    x--;
                                }
                                else if (maze[x + 1, y] == 1)
                                {
                                    dir = 3;
                                    x++;
                                }
                            }

                        }
                    }
                    break;
                //-----------------------------------------------------------
                case 3://direction is down
                       //crossroads with path in direction
                    if (maze[x + 1, y] == 1)
                    {
                        if (maze[x, y - 1] == 0 && maze[x, y + 1] == 0)
                        {
                            x++;
                        }

                        else
                        {
                            if (maze[x, y - 1] == 1 && maze[x, y + 1] == 1)
                            {
                                r = UnityEngine.Random.Range(0, 3);
                                switch (r)
                                {
                                    case 0:
                                        x++;
                                        break;
                                    case 1:
                                        dir = 2;
                                        y++;
                                        break;
                                    case 2:
                                        dir = 4;
                                        y--;
                                        break;
                                    default:
                                        //?
                                        break;
                                }
                            }
                            else
                            {
                                if (maze[x, y - 1] == 1)
                                {
                                    r = UnityEngine.Random.Range(0, 2);
                                    if (r == 1)
                                    {
                                        x++;
                                    }
                                    else if (r == 0)
                                    {
                                        dir = 4;
                                        y--;
                                    }
                                }
                                else if (maze[x, y + 1] == 1)
                                {
                                    r = UnityEngine.Random.Range(0, 2);
                                    if (r == 1)
                                    {
                                        x++;
                                    }
                                    else if (r == 0)
                                    {
                                        dir = 2;
                                        y++;
                                    }
                                }
                            }
                        }
                    }
                    //crossroads with wall in direction
                    else
                    {
                        if (maze[x, y - 1] == 0 && maze[x, y + 1] == 0)
                        {
                            dir = 1;
                            x--;
                        }
                        else
                        {
                            if (maze[x, y - 1] == 1 && maze[x, y + 1] == 1)
                            {
                                r = UnityEngine.Random.Range(0, 2);
                                if (r == 1)
                                {
                                    dir = 2;
                                    y++;
                                }
                                else if (r == 0)
                                {
                                    dir = 4;
                                    y--;
                                }
                            }
                            else
                            {
                                if (maze[x, y - 1] == 1)
                                {
                                    dir = 4;
                                    y--;
                                }
                                else if (maze[x, y + 1] == 1)
                                {
                                    dir = 2;
                                    y++;
                                }
                            }

                        }
                    }
                    break;
                //-----------------------------------------------------------
                case 4://direction is left
                       //crossroads with path in direction
                    if (maze[x, y - 1] == 1)
                    {
                        if (maze[x - 1, y] == 0 && maze[x + 1, y] == 0)
                        {
                            y--;
                        }
                        else
                        {
                            if (maze[x - 1, y] == 1 && maze[x + 1, y] == 1)
                            {
                                r = UnityEngine.Random.Range(0, 3);
                                switch (r)
                                {
                                    case 0:
                                        y--;
                                        break;
                                    case 1:
                                        dir = 1;
                                        x--;
                                        break;
                                    case 2:
                                        dir = 3;
                                        x++;
                                        break;
                                    default:
                                        //?
                                        break;
                                }
                            }
                            else
                            {
                                if (maze[x - 1, y] == 1)
                                {
                                    r = UnityEngine.Random.Range(0, 2);
                                    if (r == 1)
                                    {
                                        y--;
                                    }
                                    else if (r == 0)
                                    {
                                        dir = 1;
                                        x--;
                                    }
                                }
                                else if (maze[x + 1, y] == 1)
                                {
                                    r = UnityEngine.Random.Range(0, 2);
                                    if (r == 1)
                                    {
                                        y--;
                                    }
                                    else if (r == 0)
                                    {
                                        dir = 3;
                                        x++;
                                    }
                                }
                            }
                        }
                    }
                    //crossroads with wall in direction
                    else
                    {
                        if (maze[x - 1, y] == 0 && maze[x + 1, y] == 0)
                        {
                            dir = 2;
                            y++;
                        }
                        else
                        {
                            if (maze[x - 1, y] == 1 && maze[x + 1, y] == 1)
                            {
                                r = UnityEngine.Random.Range(0, 2);
                                if (r == 1)
                                {
                                    dir = 1;
                                    x--;
                                }
                                else if (r == 0)
                                {
                                    dir = 3;
                                    x++;
                                }
                            }
                            else
                            {
                                if (maze[x - 1, y] == 1)
                                {
                                    dir = 1;
                                    x--;
                                }
                                else if (maze[x + 1, y] == 1)
                                {
                                    dir = 3;
                                    x++;
                                }
                            }

                        }
                    }
                    break;
                default:
                    //start position?
                    //dir = 1;
                    //x = 1; y = 1;
                    break;
            }
            move = 0;
        }
        else
            move++;
        transform.Translate(x, y, 0);
    }
}