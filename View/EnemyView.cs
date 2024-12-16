using UnityEngine;
using System.Collections;

public class EnemyView : View
{
    [SerializeField] private GameObject healthBarPrefab;
    [SerializeField] private Transform healthBarAnchor;
    [SerializeField] private Transform healthBarContainer;

    private GameObject _healthBar;
    private Slider _slider;

    protected override void Awake()
    {
        base.Awake();

        _healthBar = Instantiate(healthBarPrefab, healthBarContainer);
        _slider = _healthBar.GetComponent<Slider>();
    }

    protected override void Subscribe()
    {
        Model.Health.OnValueChanged += HealthChanged;
        Model.OnDeath += Death;
    }

    protected override void Unsubscribe()
    {
        Model.Health.OnValueChanged -= HealthChanged;
        Model.OnDeath -= Death;
    }

    private void HealthChanged()
    {
        _healthBar.value = Model.Health.CurrentValue / Model.Health.MaxValue;
    }

    private void Death()
    {
        Destroy(_healthBar);
    }
}