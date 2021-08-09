using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageController : MonoBehaviour
{
    public GameObject target;
    public bool startMove = false;
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
        if (startMove)
        {
            startMove = false;
            this.transform.position = target.transform.position;
            gameMN.checkComplete = true;
        }
    }
}
