using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject[] objectsToSpawn; // Array berisi objek-objek yang akan di-spawn
    [SerializeField] float spawnDelay = 1.0f; // Waktu jeda antara setiap spawn
    [SerializeField] float spawnHeight = 10.0f; // Skala Ketinggian spawn
    [SerializeField] float boundScale; // Skala Batasan Horizontal

    private float spawnTimer = 0.0f;

    private void Update()
    {
        spawnTimer += Time.deltaTime;

        // Cek apakah sudah waktunya untuk spawn objek baru
        if (spawnTimer >= spawnDelay)
        {
            SpawnRandomObject();
            spawnTimer = 0.0f;
        }
    }

    private void SpawnRandomObject()
    {
        // Pilih objek secara acak dari array objectsToSpawn
        int randomIndex = Random.Range(0, objectsToSpawn.Length);
        GameObject objectToSpawn = objectsToSpawn[randomIndex];

        // Tentukan posisi spawn secara acak di atas
        float spawnX = Random.Range(-boundScale, boundScale);
        Vector3 spawnPosition = new Vector3(spawnX, spawnHeight, 0.0f);

        // Buat objek baru di posisi spawn
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}
