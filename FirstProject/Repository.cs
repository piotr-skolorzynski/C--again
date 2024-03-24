using System;
using System.Collections.Generic;

namespace FirstProject;
public class Repository<T>
{
    private List<T> data = new List<T>();

    public void AddElement(T element)
    {
        if (element != null)
        {
            data.Add(element);
        } 
    }

    public T GetElement(int index)
    {
        if (index < data.Count) 
        {
            return data[index];
        }
        else
        {
            // if index out of range of List return default value
            // null or zero for int
            return default(T);
        }
    }
}

public class Repository<TKey, TValue>
{
    private Dictionary<TKey, TValue> data = new Dictionary<TKey, TValue>();

    public void AddElement(TKey key, TValue element)
    {
        if (element != null)
        {
            data.Add(key, element);
        } 
    }

    public TValue GetElement(TKey key)
    {
        if (data.TryGetValue(key, out TValue result)) 
        {
            return result;
        }
        else
        {
            // if index out of range of List return default value
            // null or zero for int
            return default(TValue);
        }
    }
}
