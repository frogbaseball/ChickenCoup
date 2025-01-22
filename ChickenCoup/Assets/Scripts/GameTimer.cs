using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
public class GameTimer : MonoBehaviour {
    [SerializeField] private float gameLength; //for how long will the game go
    [SerializeField] private float whatTimeToRigTheGame;
    [Header("UI")]
    [SerializeField] private TMP_Text text;
    [Header("Scripts")]
    [SerializeField] private ChickenSpawner spawner;
    [SerializeField] private EndGame endGameScript;
    private float timer;
    private bool gameStarted = false;
    private bool gameRigged = false;
    public void StartTimer() {
        timer = gameLength;
        gameStarted = true;
    }
    private void Update() {
        if (!gameStarted) {
            return;
        }
        if (timer > 0) {
            timer -= Time.deltaTime;
            UpdateText();
        } else {
            Time.timeScale = 0;
            endGameScript.EndTheGame();
        }
        if (whatTimeToRigTheGame > timer && !gameRigged) {
            RigChickens();
            gameRigged = true;
        }
    }
    private void UpdateText() {
        text.text = timer.ToString();
    }
    private void RigChickens() {
        for (int i = 0; i < spawner.ChickenPrefabs.Count / 2; i++) {
            spawner.ChickenPrefabs[i].GetComponent<ChickenMovement>().IsRigged = true;
        }
    }
}