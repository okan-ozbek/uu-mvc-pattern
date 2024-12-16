using UnityEngine;
using System.Collections;

public class EnemyController : Controller
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Model.Health.CurrentValue = 0.0f; // Debug code to check death.
        }
    }

    protected override void Subscribe()
    {
        Model.OnDeath += Death;
    }

    protected override void Unsubscribe()
    {
        Model.OnDeath -= Death;
    }

    private void Death()
    {
        Destroy(gameObject);
    }
}