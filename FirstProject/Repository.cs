using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstProject;
public class Repository<T> where T : IEntity, new()
{
    private List<T> data = new List<T>();

    public void AddElement(T element)
    {
        if (element != null)
        {
            //now we have possibility to use constructor
            var newElement = new T();
            newElement.Id = 23;

            //T must implement IEntity so it has property Id available
            Console.WriteLine(element.Id);
            data.Add(element);
        } 
    }

    public T GetElementById(int id)
    {
        return data.FirstOrDefault(e => e.Id == id);
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
    where TKey : class 
    where TValue : new()
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
