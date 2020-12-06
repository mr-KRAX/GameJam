using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour {

  public static bool gameIsPaused = false;
  void Update() {
    if (Input.GetKeyDown(KeyCode.Escape)) {
      if (gameIsPaused)
        Resume();
      else
        Pause();
    }
  }
  #region Pause menu behavior
  /**
   * Pause menu
   */
  public GameObject pauseMenuUI;

  public void OnClick_ResumeButton() {
    Resume();
  }

  public void OnClick_OptionsButton() {
    //Open Options 
    //pauseMenuUI.SetActive(false);
    //optionsMenuUI.SetActive(true);
  }

  public string sceneLoadedOnQuit; // Main scene name 
  public void OnClick_QuitButton() {
    //Load StartMenu scene
    SceneManager.LoadScene(sceneLoadedOnQuit);
  }
  #endregion Pause menu behavior

  #region Options menu behavior
  /**
   * Options menu
   */
  public GameObject optionsMenuUI;

  // TODO: options menu
  #endregion Oprions menu behavior

  void Pause() {
    pauseMenuUI.SetActive(true);
    Time.timeScale = 0f;
    gameIsPaused = true;
  }

  void Resume() {
    pauseMenuUI.SetActive(false);
    Time.timeScale = 1f;
    gameIsPaused = false;
  }

}
