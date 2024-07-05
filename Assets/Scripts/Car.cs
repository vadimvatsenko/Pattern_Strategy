using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    protected string _model;
    protected Rigidbody _rb;
    protected float _speed;
    [SerializeField] protected Vector3 _finish;
    public IMovable _movable { get; protected set; }    

    public virtual void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _speed = 30f;
    }
    
}
