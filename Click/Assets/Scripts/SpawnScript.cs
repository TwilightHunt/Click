using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public RectTransform SpawnArea;
    public GameObject Sphere;
    public Vector2 MinMaxSphereSize = new Vector2(0.2f, 3f);

    [Header("Gizmos")]
    public float GizmosRadius = 2f;
    public Color GizmosColor = Color.blue;
    private Vector3[] corners = new Vector3[4];


    private void OnDrawGizmos()
    {
        if (SpawnArea == null)
            return;

        Gizmos.color = GizmosColor;        
        SpawnArea.GetWorldCorners(corners);
        foreach(Vector3 pos in corners)
        {
            Gizmos.DrawSphere(pos, GizmosRadius);
        }

    }

    private void Start()
    {
        //https://docs.unity3d.com/ScriptReference/RectTransform.GetWorldCorners.html
        SpawnArea.GetWorldCorners(corners);

        for (int i = 0; i < 25; i++)
        {
            Spawn();
        }
    }

    public void Spawn()
    {
        Vector3 randomPosition = Vector3.zero;
        randomPosition.x = Random.Range(corners[0].x, corners[3].x);
        randomPosition.y = Random.Range(corners[0].y, corners[1].y);

        GameObject sphere = Instantiate(Sphere, randomPosition, Quaternion.identity, transform);
        sphere.transform.localScale = Vector3.one * Random.Range(MinMaxSphereSize.x, MinMaxSphereSize.y);
    }
}
