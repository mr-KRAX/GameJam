using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

  public void OnClick_QuitButton() {
    //Load StartMenu scene
  }
  #endregion Pause menu behavior

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
