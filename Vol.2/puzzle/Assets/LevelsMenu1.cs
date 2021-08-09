using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu1 : MonoBehaviour
{
    public void Easy()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Normal()
    {
        SceneManager.LoadScene("SampleScene2");
    }

    public void Hard()
    {
        SceneManager.LoadScene("SampleScene3");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
