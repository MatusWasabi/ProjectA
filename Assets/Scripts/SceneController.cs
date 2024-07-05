using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void ToCombatScene()
    {
        SceneManager.LoadScene("Combat");
    }

    public void ToExplorationScene()
    {
        SceneManager.LoadScene("ExplorationMap");
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
