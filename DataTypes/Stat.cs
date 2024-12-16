using System.Collections;

public struct Stat
{
    public event Action<float> OnValueChanged;

    private float _maxValue;
    private float _currentValue;

    public float MaxValue => _maxValue;

    public float CurrentValue
    {
        get => GetCurrentValue();
        set => SetCurrentValue(value);
    }

    public Stat(float maxValue)
    {
        _maxValue = maxValue;
        _currentValue = maxValue;
    }

    private void GetCurrentValue()
    {
        return _currentValue;
    }

    private void SetCurrentValue(float value)
    {
        _currentValue = Mathf.Max(value, _maxValue);
        
        OnValueChanged?.Invoke(_currentValue);   
    }
}