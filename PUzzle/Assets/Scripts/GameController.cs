using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int level;
    public int row, col,countStep;
    public int rowBlank, colBlank;
    public int sizlRaw, sizeCol;
    int countPoint = 0;
    int countImageKey = 0;
    int countComplete = 0;

    public bool startControl = false;
    public bool checkComplete;
    public bool gameIsComplete;
    GameObject temp;

    public List<GameObject> imageKeyList;
    public List<GameObject> imageOfPictureList;
    public List<GameObject> checkPointList;
    GameObject[,] imageKeyMatrics;
    GameObject[,] imageOfPictureMatrics;
    GameObject[,] checkPointMatrics;
    // Start is called before the first frame update
    void Start()
    {
        imageKeyMatrics = new GameObject[sizlRaw, sizeCol];
        imageOfPictureMatrics = new GameObject[sizlRaw, sizeCol];
        checkPointMatrics = new GameObject[sizlRaw, sizeCol];
        if(level==1)
        {
            ImageOfEasyLevel();

        }else if(level==2)
        {
            ImageOfNormalLevel();
        }else if(level==3)
        {
            ImageOfHardLevel();
        }
        CheckPointManager();
        ImageKeyManager();
        for (int r = 0; r < sizlRaw; r++)
        {
            for (int c = 0; c < sizeCol; c++)
            {
              if(  imageOfPictureMatrics[r, c].name.CompareTo("blank") ==0)
                {
                    rowBlank = r;
                    colBlank = c;
                    break;
                }
              //  countPoint++;
            }
        }

    }
    void CheckPointManager()
    {
        for (int r = 0; r < sizlRaw; r++)
        {
            for (int c = 0; c < sizeCol; c++)
            {
                checkPointMatrics[r, c] = checkPointList[countPoint];
                countPoint++;
            }
        }
    }

    void ImageKeyManager()
    {
        for (int r = 0; r < sizlRaw; r++)
        {
            for (int c = 0; c < sizeCol; c++)
            {
                imageKeyMatrics[r, c] = imageKeyList[countImageKey];
                countImageKey++;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(startControl)
        {
            startControl = false;
            if (countStep == 1)
            {
                if ( imageOfPictureMatrics[row,col]!=null&&imageOfPictureMatrics[row, col].name.CompareTo("blank") != 0)
                {
                    if(rowBlank!=row && colBlank==col)
                    {
                        if (Mathf.Abs(row - rowBlank) == 1)
                        {
                            SortImage();
                            countStep = 0;
                        }
                        else
                        {
                            countStep = 0;
                        }
                    }
                    else if(rowBlank==row&& colBlank!=col)
                    {
                        if (Mathf.Abs(col - colBlank ) == 1)
                        {
                            SortImage();
                            countStep = 0;
                        }
                        else
                        {
                            countStep = 0;
                        }
                    }
                    else if((rowBlank==row && colBlank==col)||(rowBlank!=row && colBlank!=col))
                    {
                        countStep = 0;
                    }
                    else
                    {
                        countStep = 0;
                    }
                }
            }
        }
    }
    void FixedUpdate()
    {
        if(checkComplete)
        {
            checkComplete = false;
            for(int r=0;r<sizlRaw;r++)
            {
                for(int c=0;c<sizeCol;c++)
                {
                    if(imageKeyMatrics[r,c].gameObject.name.CompareTo(imageOfPictureMatrics[r,c].gameObject.name) == 0)
                    {
                        countComplete++;
                    }else
                    {
                        break;
                    }
                }
            }
            if(countComplete==checkPointList.Count)
            {
                gameIsComplete = true;
                Debug.Log("Game Is Complete");

            }
            else
            {
                countComplete = 0;
            }
        }
    }
    void SortImage()
    {
        temp = imageOfPictureMatrics[rowBlank,colBlank];
        imageOfPictureMatrics[rowBlank, colBlank] = null;
        imageOfPictureMatrics[rowBlank, colBlank] = imageOfPictureMatrics[row, col];
        imageOfPictureMatrics[row, col]=null;
        imageOfPictureMatrics[row, col] = temp;
        imageOfPictureMatrics[rowBlank, colBlank].GetComponent<ImageController>().target = checkPointMatrics[rowBlank, colBlank];
        imageOfPictureMatrics[row, col].GetComponent<ImageController>().target = checkPointMatrics[row, col];

        imageOfPictureMatrics[rowBlank, colBlank].GetComponent<ImageController>().startMove = true;
        imageOfPictureMatrics[row, col].GetComponent<ImageController>().startMove = true;

        rowBlank = row;
        colBlank = col;
    }
    void ImageOfEasyLevel()
    {
        imageOfPictureMatrics[0, 0] = imageOfPictureList[0];
        imageOfPictureMatrics[0, 1] = imageOfPictureList[2];
        imageOfPictureMatrics[0, 2] = imageOfPictureList[5];
        imageOfPictureMatrics[1, 0] = imageOfPictureList[4];
        imageOfPictureMatrics[1,1] = imageOfPictureList[1];
        imageOfPictureMatrics[1,2] = imageOfPictureList[7];
        imageOfPictureMatrics[2, 0] = imageOfPictureList[3];
        imageOfPictureMatrics[2,1] = imageOfPictureList[6];
        imageOfPictureMatrics[2,2] = imageOfPictureList[8];

    }
    void ImageOfNormalLevel()
    {
        imageOfPictureMatrics[0, 0] = imageOfPictureList[4];
        imageOfPictureMatrics[0, 1] = imageOfPictureList[0];
        imageOfPictureMatrics[0, 2] = imageOfPictureList[1];
        imageOfPictureMatrics[0, 3] = imageOfPictureList[2];
        imageOfPictureMatrics[1, 0] = imageOfPictureList[8];
        imageOfPictureMatrics[1, 1] = imageOfPictureList[6];
        imageOfPictureMatrics[1,2] = imageOfPictureList[7];
        imageOfPictureMatrics[1,3] = imageOfPictureList[11];
        imageOfPictureMatrics[2, 0] = imageOfPictureList[12];
        imageOfPictureMatrics[2,1] = imageOfPictureList[5];
        imageOfPictureMatrics[2,2] = imageOfPictureList[14];
        imageOfPictureMatrics[2,3] = imageOfPictureList[10];
        imageOfPictureMatrics[3, 0] = imageOfPictureList[13];
        imageOfPictureMatrics[3,1] = imageOfPictureList[9];
        imageOfPictureMatrics[3,2] = imageOfPictureList[15];
        imageOfPictureMatrics[3,3] = imageOfPictureList[3];
    }
    void ImageOfHardLevel()
    {
        imageOfPictureMatrics[0, 0] = imageOfPictureList[5];
        imageOfPictureMatrics[0, 1] = imageOfPictureList[2];
        imageOfPictureMatrics[0, 2] = imageOfPictureList[3];
        imageOfPictureMatrics[0, 3] = imageOfPictureList[4];
        imageOfPictureMatrics[0, 4] = imageOfPictureList[9];
        imageOfPictureMatrics[1, 0] = imageOfPictureList[10];
        imageOfPictureMatrics[1,1] = imageOfPictureList[1];
        imageOfPictureMatrics[1,2] = imageOfPictureList[12];
        imageOfPictureMatrics[1,3] = imageOfPictureList[7];
        imageOfPictureMatrics[1,4] = imageOfPictureList[8];
        imageOfPictureMatrics[2,0] = imageOfPictureList[15];
        imageOfPictureMatrics[2,1] = imageOfPictureList[6];
        imageOfPictureMatrics[2,2] = imageOfPictureList[13];
        imageOfPictureMatrics[2,3] = imageOfPictureList[14];
        imageOfPictureMatrics[2,4] = imageOfPictureList[19];
        imageOfPictureMatrics[3, 0] = imageOfPictureList[20];
        imageOfPictureMatrics[3,1] = imageOfPictureList[11];
        imageOfPictureMatrics[3,2] = imageOfPictureList[22];
        imageOfPictureMatrics[3,3] = imageOfPictureList[17];
        imageOfPictureMatrics[3,4] = imageOfPictureList[18];
        imageOfPictureMatrics[4, 0] = imageOfPictureList[21];
        imageOfPictureMatrics[4,1] = imageOfPictureList[16];
        imageOfPictureMatrics[4,2] = imageOfPictureList[23];
        imageOfPictureMatrics[4,3] = imageOfPictureList[24];
        imageOfPictureMatrics[4,4] = imageOfPictureList[0];

    }
}
