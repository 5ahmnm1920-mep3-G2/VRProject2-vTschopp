using UnityEngine;

public class SpawnPowerCells : MonoBehaviour
{
    [Header("Game Objects")]
    [SerializeField] GameObject powerCellPrefab;
    [SerializeField] GameObject spawnCorner1;
    [SerializeField] GameObject spawnCorner2;

    [Header("Variables")]
    [SerializeField, Range(0, 10)] int spawnCount;

    float minPosX;
    float maxPosX;
    float minPosZ;
    float maxPosZ;

    void Start()
    {
        calculateSpawnArea();

        for(int i = 0; i < spawnCount; i++)
        {
            Instantiate(powerCellPrefab,
                new Vector3(Random.Range(minPosX, maxPosX), 0, Random.Range(minPosZ, maxPosZ)),
                Quaternion.identity);
        }
    }

    void calculateSpawnArea()
    {
        float posX1 = spawnCorner1.transform.position.x;
        float posZ1 = spawnCorner1.transform.position.z;

        float posX2 = spawnCorner2.transform.position.x;
        float posZ2 = spawnCorner2.transform.position.z;

        switch(posX1 < posX2)
        {
            case true:
                minPosX = posX1;
                maxPosX = posX2;
                break;

            case false:
                minPosX = posX2;
                maxPosX = posX1;
                break;
        }

        switch (posZ1 < posZ2)
        {
            case true:
                minPosZ = posZ1;
                maxPosZ = posZ2;
                break;

            case false:
                minPosZ = posZ2;
                maxPosZ = posZ1;
                break;
        }
    }
}
