using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Vector3 center; // координаты центра
    public Vector3 size; // координаты в которых будут появляться объекты
 
    public GameObject sphere; // сфера

    void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        Vector3 pos2 = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Instantiate(sphere, pos2, Quaternion.identity);
    }
}
