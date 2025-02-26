using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class Observable<T>
{
    [SerializeField] T value;
    [SerializeField] UnityEvent<T> onValueChanged;

    public Observable(T startValue)
    {
        value = startValue;
        Invoke();
    }
    public T Value
    {
        get => value;
        set => Set(value);
    }

    void Set(T value)
    {
        if (Equals(this.value, value)) return;
        this.value = value;
        Invoke();
    }

    void Invoke()
    {
        onValueChanged.Invoke(value);
    }
}
