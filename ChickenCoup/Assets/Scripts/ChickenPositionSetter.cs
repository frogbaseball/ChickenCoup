using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChickenPositionSetter : MonoBehaviour {
    [SerializeField] private WalkableArea walkableArea;
    [SerializeField] private WalkableArea[] walkableAreasForColors;
    private int winningIndex = 0;
    /*
     * 0 = RED 
     * 1 = BLUE
     * 2 = GREEN
     * 3 = YELLOW
     * 4 = PURPLE
     */
    public int WinningIndex { get { return winningIndex; } set { winningIndex = value; } }
    public Vector3 GetRandomDestination() {
        return walkableArea.GetRandomPosition();
    }
    public Vector3 GetRandomDestinationForWinningColor() {
        return walkableAreasForColors[winningIndex].GetRandomPosition();
    }
}