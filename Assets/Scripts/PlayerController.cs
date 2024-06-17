using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Camera cam;

    private void Start() {
        cam = Camera.main;
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) {
                hit.transform.gameObject.GetComponent<FruitManager>().AttemptHarvest();
            }
        }
    }

}
