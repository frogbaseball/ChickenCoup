using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WalkableArea : MonoBehaviour {
    private void OnDrawGizmos() {
        Gizmos.color = new Color32(0, 0, 0, 100);
        Gizmos.DrawCube(transform.position, transform.localScale);
    }
    public Vector3 GetRandomPosition() {
        var x = Random.Range(-transform.localScale.x / 2 + transform.position.x, transform.localScale.x / 2 + transform.position.x);
        var y = Random.Range(-transform.localScale.y / 2 + transform.position.y, transform.localScale.y / 2 + transform.position.y);
        var z = Random.Range(-transform.localScale.z / 2 + transform.position.z, transform.localScale.z / 2 + transform.position.z);
        return new Vector3(x, y, z);
    }
}