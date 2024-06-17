using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class FruitBaseState {

    public abstract void EnterState(FruitManager fruit);

    public abstract void UpdateState(FruitManager fruit);

    public abstract void OnCollisionEnter(FruitManager fruit);
    

}
