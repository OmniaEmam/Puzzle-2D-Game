using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu2 : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("Levels");
    }
}
