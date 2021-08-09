using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyScript : MonoBehaviour
{
    public int sizeRow, sizeCol;
    int countPoint = 0;
    int countImagekey = 0;

    public List<GameObject> imageKeyList;// run from 0 ---> list.count
    public List<GameObject> imageOfPictureList;
    public List<GameObject> checkPointList;

    GameObject[,] imageKeyMatrix;
    GameObject[,] imageOfPictureMatrix;
    GameObject[,] checkPointMatrix;

    // Start is called before the first frame update
    // Use this for initializetIon 
    void Start()
    {
        //call functiin;
        checkPointManager();
        imageKeyManager();
    }

    void checkPointManager()
    {
        for (int r = 0; r < sizeRow; r++) //run row
        {
            for (int c = 0; c < sizeCol; c++) // run col
            {
                checkPointMatrix[r, c] = checkPointList[countPoint];
                countPoint++;
            }
        }
    }
    void imageKeyManager()
    {
        for (int r = 0; r < sizeRow; r++)
        {
            for (int c = 0; c < sizeCol; c++)
            {
                imageKeyMatrix[r, c] = imageKeyList[countImagekey];
                countImagekey++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ImageOfEasyLevel()
    {
        //9 row
        imageOfPictureMatrix[0, 0] = imageOfPictureList[0];
        imageOfPictureMatrix[0, 1] = imageOfPictureList[2];
        imageOfPictureMatrix[0, 2] = imageOfPictureList[5];
        imageOfPictureMatrix[1, 0] = imageOfPictureList[4];
        imageOfPictureMatrix[1, 1] = imageOfPictureList[1];
        imageOfPictureMatrix[1, 2] = imageOfPictureList[7];
        imageOfPictureMatrix[2, 0] = imageOfPictureList[3];
        imageOfPictureMatrix[2, 1] = imageOfPictureList[6];
        imageOfPictureMatrix[2, 2] = imageOfPictureList[8];
    }

    void ImageOfNormalLevel()
    {
        // 16 row
        imageOfPictureMatrix[0, 0] = imageOfPictureList[4];
        imageOfPictureMatrix[0, 1] = imageOfPictureList[0];
        imageOfPictureMatrix[0, 2] = imageOfPictureList[1];
        imageOfPictureMatrix[0, 3] = imageOfPictureList[2];
        imageOfPictureMatrix[1, 0] = imageOfPictureList[8];
        imageOfPictureMatrix[1, 1] = imageOfPictureList[6];
        imageOfPictureMatrix[1, 2] = imageOfPictureList[7];
        imageOfPictureMatrix[1, 3] = imageOfPictureList[11];
        imageOfPictureMatrix[2, 0] = imageOfPictureList[12];
        imageOfPictureMatrix[2, 1] = imageOfPictureList[5];
        imageOfPictureMatrix[2, 2] = imageOfPictureList[14];
        imageOfPictureMatrix[2, 3] = imageOfPictureList[10];
        imageOfPictureMatrix[3, 0] = imageOfPictureList[13];
        imageOfPictureMatrix[3, 1] = imageOfPictureList[9];
        imageOfPictureMatrix[3, 2] = imageOfPictureList[15];
        imageOfPictureMatrix[3, 3] = imageOfPictureList[3];

    }

    void ImageOfHardLevel()
    {
        //25 row
        imageOfPictureMatrix[0, 0] = imageOfPictureList[5];
        imageOfPictureMatrix[0, 1] = imageOfPictureList[2];
        imageOfPictureMatrix[0, 2] = imageOfPictureList[3];
        imageOfPictureMatrix[0, 3] = imageOfPictureList[4];
        imageOfPictureMatrix[0, 4] = imageOfPictureList[9];
        imageOfPictureMatrix[1, 0] = imageOfPictureList[10];
        imageOfPictureMatrix[1, 1] = imageOfPictureList[1];
        imageOfPictureMatrix[1, 2] = imageOfPictureList[12];
        imageOfPictureMatrix[1, 3] = imageOfPictureList[7];
        imageOfPictureMatrix[1, 4] = imageOfPictureList[10];
        imageOfPictureMatrix[2, 0] = imageOfPictureList[15];
        imageOfPictureMatrix[2, 1] = imageOfPictureList[6];
        imageOfPictureMatrix[2, 2] = imageOfPictureList[13];
        imageOfPictureMatrix[2, 3] = imageOfPictureList[14];
        imageOfPictureMatrix[2, 4] = imageOfPictureList[19];
        imageOfPictureMatrix[3, 0] = imageOfPictureList[20];
        imageOfPictureMatrix[3, 1] = imageOfPictureList[11];
        imageOfPictureMatrix[3, 2] = imageOfPictureList[22];
        imageOfPictureMatrix[3, 3] = imageOfPictureList[17];
        imageOfPictureMatrix[3, 4] = imageOfPictureList[18];
        imageOfPictureMatrix[4, 0] = imageOfPictureList[21];
        imageOfPictureMatrix[4, 1] = imageOfPictureList[16];
        imageOfPictureMatrix[4, 2] = imageOfPictureList[23];
        imageOfPictureMatrix[4, 3] = imageOfPictureList[24];
        imageOfPictureMatrix[4, 4] = imageOfPictureList[0];


    }
}
