using UnityEngine;
using System.Collections;

public interface IModel
{
    void Initialize();
}

public abstract class Model : MonoBehaviour, IModel
{
    public virtual void Awake()
    {
        Initialize();
    }

    public abstract void Initialize();
}