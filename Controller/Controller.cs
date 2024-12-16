using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Model))]
public abstract class Controller : MonoBehaviour
{
    protected Model Model;

    protected void OnEnable() => Subscribe();
    protected void OnDisable() => Unsubscribe();

    protected virtual void Awake()
    {
        Model = GetComponent<Model>();
    }

    protected virtual void Subscribe() {}
    protected virtual void Unsubscribe() {}
}