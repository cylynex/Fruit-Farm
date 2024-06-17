using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour {

    FruitBaseState currentState;

    public FruitGrowing fruitGrowing = new FruitGrowing();
    public FruitRipe fruitRipe = new FruitRipe();
    public FruitChewed fruitChewed = new FruitChewed();
    public FruitRotten fruitRotten = new FruitRotten();

    private void Start() {
        currentState = fruitGrowing;
        currentState.EnterState(this);
    }

    private void Update() {
        currentState.UpdateState(this);
    }

    public void SwitchState(FruitBaseState state) {
        currentState = state;
        state.EnterState(this);
    }

    public void AttemptHarvest() {
        if (currentState == fruitRipe) {
            SwitchState(fruitChewed);
            currentState.EnterState(this);
        }
    }

    public void EatFruit() {
        Destroy(gameObject);
    }

}
