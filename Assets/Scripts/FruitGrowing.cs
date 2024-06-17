using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitGrowing : FruitBaseState {

    Vector3 fruitStartSize = new Vector3(1, 1, 1);
    Vector3 fruitGrowth = new Vector3(0.2f, 0.2f, 0.2f);
    float maxFruitSize = 3;
    public override void EnterState(FruitManager fruit) {
        Debug.Log("Enterered Growing State");
    }

    public override void UpdateState(FruitManager fruit) {
        if (fruit.transform.localScale.x < maxFruitSize) {
            fruit.transform.localScale += fruitGrowth * Time.deltaTime;
        } else {
            Debug.Log("Fruit all grown up");
            fruit.SwitchState(fruit.fruitRipe);
        }
    }

    public override void OnCollisionEnter(FruitManager fruit) {

    }
}
