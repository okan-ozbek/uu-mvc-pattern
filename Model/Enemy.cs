using System;
using UnityEngine;

public class Enemy : Model
{
    public EnemyStatConfig statConfig;

    public event Action OnDeath;

    public Stat Health;
    public Stat Damage;
    public Stat Speed;

    public override void Initialize()
    {
        Health = new Stat(statConfig.Health);
        Damage = new Stat(statConfig.Damage);
        Speed = new Stat(statConfig.Speed);
    }

    public void HealthChanged()
    {
        if (Health.CurrentValue <= 0.0f)
        {
            OnDeath?.Invoke();
        }
    }
}