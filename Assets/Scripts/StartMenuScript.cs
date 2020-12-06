using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour {

  public string sceneLoadedOnPlay; // Main scene name 

  #region Main menu behavior
  /**
   * Main menu
   */
  public GameObject mainMenue;
  public void OnClick_PlayButton() {
    SceneManager.LoadScene(sceneLoadedOnPlay);
  }

  public void OnClick_OptionsButton() {
    mainMenue.SetActive(false);
    optionsMenu.SetActive(true);
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
  public GameObject optionsMenu;
  public void OnClick_BackButton() {
    optionsMenu.SetActive(false);
    mainMenue.SetActive(true);
  }
  #endregion Options menu behavior
}
