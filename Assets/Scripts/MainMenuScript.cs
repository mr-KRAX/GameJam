using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {
  
  public string sceneLoadedOnPlay; // Main scene name 
  public void OnClick_PlayButton() {
    SceneManager.LoadScene(sceneLoadedOnPlay);
  }

  public void OnClick_OptionsButton() {
    // No specific actions, see OptionsButton->Button->OnClick()
  }

  public void OnClick_CreditsButton() {
    // No specific actions, see CreditsButton->Button->OnClick()
  }

  public void OnClick_QuitButton() {
    Debug.Log("Quit Button Pressed");
    Application.Quit();
  }
}
