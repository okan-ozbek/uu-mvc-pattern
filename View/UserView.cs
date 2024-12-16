using System;
using UnityEngine;

public class UserView : View
{
    public TextMesh HealthText;
    public TextMesh DamageText;
    public TextMesh SpeedText;

    protected override void Subscribe()
    {
        Model.Health.OnValueChanged += HealthChanged;
        Model.Damage.OnValueChanged += DamageChanged;
        Model.Speed.OnValueChanged += SpeedChanged;
    }

    protected override void Unsubscribe()
    {
        Model.Health.OnValueChanged -= HealthChanged;
        Model.Damage.OnValueChanged -= DamageChanged;
        Model.Speed.OnValueChanged -= SpeedChanged;
    }

    private void HealthChanged(float value)
    {
        HealthText.text = value.ToString();
    }

    private void DamageChanged(float value)
    {
        DamageText.text = value.ToString();
    }

    private void SpeedChanged(float value)
    {
        SpeedText.text = value.ToString();
    }
}