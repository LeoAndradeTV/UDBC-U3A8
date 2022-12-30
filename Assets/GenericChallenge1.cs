using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericChallenge1 : MonoBehaviour
{
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateGameObject<BoxCollider>(cube);
        InstantiateGameObject<Rigidbody>(cube);
    }

    private void InstantiateGameObject<T>(GameObject gameObj) where T : Component
    {
        var objectInstatiated = Instantiate(gameObj);

        var component = objectInstatiated.AddComponent<T>();

        objectInstatiated.SetActive(false);

        Debug.Log($"Component is of Type: {typeof(T)}");
    }
}
