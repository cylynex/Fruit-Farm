using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitRipe : FruitBaseState {

    float rotTime = 10f;
    float rotTimer = 0;
    public override void EnterState(FruitManager fruit) {
        fruit.GetComponent<Rigidbody>().useGravity = true;
        rotTimer = rotTime;
    }

    public override void UpdateState(FruitManager fruit) {
        rotTimer -= Time.deltaTime;
        if (rotTimer <= 0) {
            fruit.SwitchState(fruit.fruitRotten);
        }
    }

    public override void OnCollisionEnter(FruitManager fruit) {

    }
}
