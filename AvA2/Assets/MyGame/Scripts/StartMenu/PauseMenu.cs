using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] GameObject target;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            target.SetActive(true);

            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Resume()
    {
        target.SetActive(false);
        Time.timeScale = 1;
    }
}
