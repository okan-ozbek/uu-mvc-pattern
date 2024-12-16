using System;
using UnityEngine;

public class User : Model
{
    public UserStatConfig statConfig;

    public event Action OnDeath;

    public Stat Health;
    public Stat Damage;
    public Stat Speed;

    public override void Initialize()
    {
        Health = new Stat(statConfig.Health);
        Damage = new Stat(statConfig.Damage);
        Speed = new Stat(statConfig.Speed);

        Health.OnValueChanged += HealthChanged;
    }

    public void HealthChanged()
    {
        if (Health.CurrentValue <= 0.0f)
        {
            OnDeath?.Invoke();
        }
    }
}