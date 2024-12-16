using System;
using UnityEngine;

[RequireComponent(typeof(Model))]
public abstract class View : MonoBehaviour
{
    protected Model Model;

    protected void OnEnable() => Subscribe();
    protected void OnDisable() => Unsubscribe();

    protected virtual void Awake()
    {
        Model = GetComponent<Model>();
    }

    protected abstract void Subscribe();
    protected abstract void Unsubscribe();
}