using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class BetOnColor : MonoBehaviour {
    [SerializeField] private TMP_Text[] texts;
    [SerializeField] private ChickenPositionSetter chickenPositionSetter;
    private int[] grades = new int[5];
    public int[] Grades { get { return grades; } }
    /*
    * 0 = RED 
    * 1 = BLUE
    * 2 = GREEN
    * 3 = YELLOW
    * 4 = PURPLE
    */
    private void Start() {
        grades[0] = 1;
        grades[1] = 2;
        grades[2] = 3;
        grades[3] = 4;
        grades[4] = 5;
    }
    public void BetOnColorGrade(int index) {
        grades[index] = 1;
        int znamka = 1;
        for (int i = index; i < grades.Length; i++) {
            grades[i] = znamka;
            znamka++;
        }
        for (int i = 0; i < index; i++) {
            grades[i] = znamka;
            znamka++;
        }
        UpdateTexts();
        chickenPositionSetter.WinningIndex = index;
    }
    private void UpdateTexts() {
        for (int i = 0; i < texts.Length; i++) {
            texts[i].text = grades[i].ToString();
        }
    }
}