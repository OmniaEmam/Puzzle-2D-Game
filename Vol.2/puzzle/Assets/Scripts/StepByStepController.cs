using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepByStepController : MonoBehaviour
{
    public int row, col;
    GameController gameMN;

    // Start is called before the first frame update
    void Start()
    {
        GameObject gamemaneger = GameObject.Find("GameController");
        gameMN = gamemaneger.GetComponent<GameController>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Row is :" + row + "Col is :" + col);
        gameMN.countStep += 1;
        gameMN.row = row;
        gameMN.col = col;
        gameMN.startContorl = true; 
    }
}
