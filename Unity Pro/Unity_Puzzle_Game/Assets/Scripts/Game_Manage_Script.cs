using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Game_Manage_Script : MonoBehaviour
{
    public GameObject block1;//클래스 타입은 대문자 게임 오브젝트
    public GameObject block2;
    public GameObject block3;

    public int[] array_1D = new int[3];
    public int[,] array_2D = new int[3,3];

    private int score_num = 0;
    public int time_counter = 600;


    public Text countText;
    public Text TimeText;

    // Start is called before the first frame update
    void Start()
    {
        array_1D[0] = 10;
        array_1D[1] = 20;
        array_1D[2] = 30;

        for(int j=0;j<3;j++)
        {
            Debug.Log(array_1D[j]);
        }

        array_2D[0, 0] = 1;
        array_2D[0, 1] = 1;
        array_2D[0, 2] = 1;

        array_2D[1, 0] = 2;
        array_2D[1, 1] = 2;
        array_2D[1, 2] = 2;

        array_2D[2, 0] =3;
        array_2D[2, 1] = 3;
        array_2D[2, 2] = 3;

        //
        for(int j=0; j<3;j++)
        {
            for(int k=0;k<3;k++)
            {
                float x_pos = j * 3.0f;
                float y_pos = k * 3.0f;

                if(array_2D[j,k]==1)
                {
                    Instantiate(block1, new Vector3(x_pos, y_pos, 0), Quaternion.identity);
                }

                else if (array_2D[j, k] == 2)
                {
                    Instantiate(block2, new Vector3(x_pos, y_pos, 0), Quaternion.identity);
                }

                else if (array_2D[j, k] == 3)
                {
                    Instantiate(block3, new Vector3(x_pos, y_pos, 0), Quaternion.identity);
                }
                //Debug.Log(array_2D[j, k]);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        Collider2D clickColl = null;
        Vector3 worldPos;
        Vector2 clickPos;

        time_counter -= 1;
        TimeText.text = "Time: " + time_counter.ToString();
        
        if(Input.GetMouseButtonDown(0))
        {
            worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            clickPos = new Vector2(worldPos.x, worldPos.y);
            clickColl = Physics2D.OverlapPoint(clickPos);

            if(clickColl.gameObject.tag == "Block1")
            {
                score_num += 1;
                Debug.Log("Block1 detected!");
                countText.text = "Count: " + score_num.ToString();
            }

            else if (clickColl.gameObject.tag == "Block2")
            {
                score_num += 2;
                Debug.Log("Block2 detected!");
                countText.text = "Count: " + score_num.ToString();
            }

            else if (clickColl.gameObject.tag == "Block3")
            {
                score_num += 3;
                Debug.Log("Block3 detected!");
                countText.text = "Count: " + score_num.ToString();
            }


        }

    }
}
