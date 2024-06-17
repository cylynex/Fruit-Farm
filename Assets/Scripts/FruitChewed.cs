using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitChewed : FruitBaseState {
    public override void EnterState(FruitManager fruit) {
        fruit.EatFruit();
    }

    public override void UpdateState(FruitManager fruit) {

    }

    public override void OnCollisionEnter(FruitManager fruit) {

    }
}
