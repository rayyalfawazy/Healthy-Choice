using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectMainMenu : MonoBehaviour
{
    [SerializeField] GameObject[] objectsToSpawn; // Array berisi objek-objek yang akan di-spawn
    [SerializeField] float spawnDelay; // Waktu jeda antara setiap spawn
    [SerializeField] float spawnHeight; // Skala Ketinggian spawn
    [SerializeField] float boundScale; // Skala Batasan Horizontal
    [SerializeField] float minValue; // Skala Batasan Minumum Fall
    [SerializeField] float maxValue; // Skala Batasan Maksimum Fall
    [SerializeField] GameObject spawnerParrent;

    private float spawnTimer = 0.0f;

    void Update()
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
        GameObject foods = Instantiate(
            objectToSpawn, 
            spawnPosition, 
            Quaternion.identity, 
            spawnerParrent.transform);

        // Atur Kecepatan Jatuh Obeject
        foods.GetComponent<Foods>().SetMinMax(minValue, maxValue);
    }
}
