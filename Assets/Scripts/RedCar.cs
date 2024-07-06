using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCar : Car
{
    
    public override void Start()
    {
        base.Start();
        _model = "RedCar";
        _movable = new EvenSpeed();
        _speed = 30f;
    }

    private void Update()
    {
        _movable.Move(_rb, _finish, _speed);
    }

}
