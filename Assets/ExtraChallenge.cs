using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraChallenge : MonoBehaviour
{
    public List<Example> finalList;
    // Start is called before the first frame update
    void Start()
    {
        finalList = InstantiateClass<Example>(new Example(), 4);
    }

    private List<T> InstantiateClass<T>(T example, int amount)
    {
        List<T> list = new List<T>();

        for (int i = 0; i < amount; i++)
        {
            list.Add(example);
        }

        return list;
    }
}

public class Example
{
    public Example() { }
}
