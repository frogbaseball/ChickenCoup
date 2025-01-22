using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ColorChanger : MonoBehaviour {
    [SerializeField] private Color32 color;
    private void OnTriggerStay(Collider other) {
        other.gameObject.GetComponentInParent<ChickenColor>().ChangeColor(color);
    }
}