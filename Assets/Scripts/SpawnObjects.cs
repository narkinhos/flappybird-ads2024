using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public float maxTime;
    public GameObject prefab;

    public float maxHeight;
    public float minHeight;

    private float timer;

    private void Start()
    {
        InstantiateObject();
    }

    private void Update()
    {
        if (timer > maxTime) {
            InstantiateObject();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void InstantiateObject()
    {
        var instance = Instantiate(prefab);
        var y = Random.Range(minHeight, maxHeight);
        instance.transform.position = transform.position + new Vector3(0, y);

        Destroy(instance, 20f);
    }
}
