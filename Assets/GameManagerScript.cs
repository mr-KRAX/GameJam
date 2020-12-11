using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour {
  [SerializeField] Canvas canvas;
  [SerializeField] Text text;
  static string[] lines = { ""+"You are taking part in a famous TV show called \"Would You Dare???\". The first round was done and while the ad break you desid to go to the Bathroom... ",
                            ""+"Such a mess! You find a note, it has bloody fingerprints on it... It sais: \"RUN AWAY!!! THEY ARE KILLING ALL PARTICIPANTS!!! "+
                            "You have a little time before before the next round! This key card will let you out. HURRY!!!\"\n" +
                            "You are scared... You shoud hurry...",
                            ""+"You are about to get out! Hurry!!!"};
  static int i = 0;
  static bool isActive = false;

  private void Start() {
    NextMessage();
  }
  public float timeRemaining = 180;
  public bool timerIsRunning = true;
  public Canvas timeCanvas;
  public Text timeText;

  void DisplayTime(float timeToDisplay) {
    timeToDisplay += 1;

    float minutes = Mathf.FloorToInt(timeToDisplay / 60);
    float seconds = Mathf.FloorToInt(timeToDisplay % 60);

    timeText.text = string.Format("Time left\n{0:00}:{1:00}", minutes, seconds);
  }

  private void Update() {
    if (timerIsRunning) {
      if (timeRemaining > 0) {
        timeRemaining -= Time.deltaTime;
        DisplayTime(timeRemaining);
      }
      else {
        Debug.Log("Time has run out!");
        timeRemaining = 0;
        timerIsRunning = false;
        GameOver(false);
      }
    }
    if (!isActive)
      return;
    if (Input.GetKey("space")) {
      canvas.gameObject.SetActive(false);
      isActive = false;
    }
  }

  public void NextMessage() {
    canvas.gameObject.SetActive(true);
    text.text = lines[i++];
    isActive = true;
  }

  [SerializeField] Canvas successScreen;
  [SerializeField] Canvas failureScreen;

  public void GameOver(bool state=true) {
    timeCanvas.gameObject.SetActive(false);
    canvas.gameObject.SetActive(false);
    if (state)
      successScreen.gameObject.SetActive(true);
    else
      failureScreen.gameObject.SetActive(true);
  }

  public void OnExitToMenuButtonClick() {
    SceneManager.LoadScene("UITestingScene");
  }

}