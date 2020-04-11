using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private const string CHARACTER_SELECTION_SCENE_NAME = "CharacterSelection";

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return) || Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonUp(0))
            StartGame();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(CHARACTER_SELECTION_SCENE_NAME);
    }

    public static void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
