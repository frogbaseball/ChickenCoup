using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class EndGame : MonoBehaviour {
    [SerializeField] private TMP_Text text;
    [SerializeField] private ChickenSpawner spawner;
    [SerializeField] private BetOnColor betOnColor;
    private int grade;
    private string color;
    public void EndTheGame() {
        color = spawner.ReturnWhatColorHasTheHighestAmount();
        grade = spawner.ReturnGradeForThatColor(color);
        text.gameObject.SetActive(true);
        text.text = $"Winner is {color}, you get the grade {grade}";
    }
}