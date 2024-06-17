using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitGrowing : FruitBaseState {

    Vector3 fruitStartSize = new Vector3(1, 1, 1);
    Vector3 fruitGrowth = new Vector3(0.2f, 0.2f, 0.2f);
    float maxFruitSize = 3;

    void Start() {
        float randomSize = Random.Range(2, 4);
        fruitGrowth = new Vector3(randomSize, randomSize, randomSize);
    }

    public override void EnterState(FruitManager fruit) {
    }

    public override void UpdateState(FruitManager fruit) {
        if (fruit.transform.localScale.x < maxFruitSize) {
            fruit.transform.localScale += fruitGrowth * Time.deltaTime;
        } else {
            fruit.SwitchState(fruit.fruitRipe);
        }
    }

    public override void OnCollisionEnter(FruitManager fruit) {
    }
}
