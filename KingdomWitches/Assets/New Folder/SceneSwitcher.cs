using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void SwitchToOne()
    {
        SceneManager.LoadScene("move1");
    }

    public void SwitchToTwo()
    {
        SceneManager.LoadScene("move2");
    }

    public void SwitchToThree()
    {
        SceneManager.LoadScene("move3");
    }

    public void SwitchToFour()
    {
        SceneManager.LoadScene("move4");
    }


}
