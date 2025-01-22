using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(ChickenPositionSetter))]
public class ChickenSpawner : MonoBehaviour {
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private int spawnCount;
    [SerializeField] private GameObject chickenPrefab;
    private List<GameObject> chickenPrefabs = new List<GameObject>();
    [Header("Scripts")]
    [SerializeField] private BetOnColor betOnColor;
    private Color32[] colors = {
        new Color32(192, 99, 75, 0),
        new Color32(9, 95, 70, 0),
        new Color32(19, 96, 76, 0),
        new Color32(152, 99, 60, 0),
        new Color32(110, 100, 60, 0)
    };
    public List<GameObject> ChickenPrefabs { get { return chickenPrefabs; } set { chickenPrefabs = value; } }
    public void SpawnChickens() {
        int index = 0;
        for (int i = 0; i < spawnCount; i++) {
            if (i % 2 == 0) {
                index = 0;
            }
            else {
                index = 1;
            }
            var chicken = Instantiate(chickenPrefab, spawnPoints[index].position, Quaternion.identity);
            chicken.GetComponent<ChickenMovement>().ChickenPositionSetter = gameObject.GetComponent<ChickenPositionSetter>();
            chickenPrefabs.Add(chicken);
        }
    }
    public string ReturnWhatColorHasTheHighestAmount() {
        int red = 0, green = 0, blue = 0, yellow = 0, purple = 0;
        for (int i = 0; i < chickenPrefabs.Count; i++) {
            if (chickenPrefabs[i].GetComponent<ChickenColor>().CurrentColor.r == colors[0].r) {
                red++;
            }
            if (chickenPrefabs[i].GetComponent<ChickenColor>().CurrentColor.r == colors[1].r) {
                blue++;
            }
            if (chickenPrefabs[i].GetComponent<ChickenColor>().CurrentColor.r == colors[2].r) {
                green++;
            }
            if (chickenPrefabs[i].GetComponent<ChickenColor>().CurrentColor.r == colors[3].r) {
                yellow++;
            }
            if (chickenPrefabs[i].GetComponent<ChickenColor>().CurrentColor.r == colors[4].r) {
                purple++;
            }
        }
        if (red >= green && red >= blue && red >= yellow && red >= purple) {
            return "red";
        }
        if (blue >= green && blue >= red && blue >= yellow && blue >= purple) {
            return "blue";
        }
        if (green >= red && green >= blue && green >= yellow && green >= purple) {
            return "green";
        }
        if (yellow >= red && yellow >= blue && yellow >= green && yellow >= purple) {
            return "yellow";
        }
        return "purple";
    }
    public int ReturnGradeForThatColor(string color) {
        switch (color) {
            case "red":
                return betOnColor.Grades[0];
            case "blue":
                return betOnColor.Grades[1];
            case "green":
                return betOnColor.Grades[2];
            case "yellow":
                return betOnColor.Grades[3];
            case "purple":
                return betOnColor.Grades[4];
            default:
                return 1;
        }
    }
}