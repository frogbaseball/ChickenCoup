using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class StartButton : MonoBehaviour {
    [SerializeField] private ChickenSpawner spawner;
    [SerializeField] private GameTimer gameTimer;
    [SerializeField] private GameObject gameObjectToHide;
    public void StartGame() {
        spawner.SpawnChickens();
        gameTimer.StartTimer();
        gameObjectToHide.SetActive(false);
    }
}