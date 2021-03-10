using System;
using System.Collections.Generic;

public class CharacterStats
{
    public float BaseValue;

    public float Value
    {
        get
        {
            if (isDirty)
            {
                _value = CalculateFinalValue();
                isDirty = false;
            }
            return _value;
        }
    }

    private bool isDirty = true;
    private float _value;

    private readonly List<StatModifier> statModifiers;

    public CharacterStats(float baseValue)
    {
        BaseValue = baseValue;
        statModifiers = new List<StatModifier>();
    }

    public void AddModifier(StatModifier mod)
    {
        isDirty = true;
        statModifiers.Add(mod);
        statModifiers.Sort();
    }
    
    private int CompareModifiersOrder(StatModifier a, StatModifier b)
    {
        if (a.Order < b.Order)
            return -1;
        else if (a.Order > b.Order)
            return 1;
        return 0; // if (a.Order == b.Order)
    }
    public void RemoveModifier(StatModifier mod)
    {
        isDirty = true;
        statModifiers.Remove(mod);
    }

    private float CalculateFinalValue()
    {
        float finalValue = BaseValue;

        for (int i = 0; i < statModifiers.Count; i++)
        {
            StatModifier mod = statModifiers[i];

            if (mod.Type == StatModType.Flat)
            {
                finalValue += statModifiers[i].Value;
            }
            else if (mod.Type == StatModType.Percent)
            {
                finalValue *= 1 + mod.Value;
            }
        }
        //12.0001f != 12f
        return (float)Math.Round(finalValue, 4);
    }
}
