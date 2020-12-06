using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour {

  public string sceneLoadedOnPlay; // Main scene name 

  #region Main menu behavior
  /**
   * Main menu
   */
  public GameObject mainMenueUI;
  public void OnClick_PlayButton() {
    SceneManager.LoadScene(sceneLoadedOnPlay);
  }

  public void OnClick_OptionsButton() {
    mainMenueUI.SetActive(false);
    optionsMenuUI.SetActive(true);
  }

  public void OnClick_CreditsButton() {
    // No specific actions, see CreditsButton->Button->OnClick()
  }

  public void OnClick_QuitButton() {
    Debug.Log("Quit Button Pressed");
    Application.Quit();
  }
  #endregion Main menu behavior

  #region Options menu behavior
  /**
   * Options menu
   */
  public GameObject optionsMenuUI;
  public void OnClick_BackButton() {
    optionsMenuUI.SetActive(false);
    mainMenueUI.SetActive(true);
  }
  #endregion Options menu behavior
}
