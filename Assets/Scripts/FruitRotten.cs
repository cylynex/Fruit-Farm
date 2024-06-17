using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitRotten : FruitBaseState {

    public override void EnterState(FruitManager fruit) {
        Debug.Log("Fruit is now Rotten");
        fruit.transform.localScale = new Vector3(2, 1, 2);
    }

    public override void UpdateState(FruitManager fruit) {

    }

    public override void OnCollisionEnter(FruitManager fruit) {

    }

}
