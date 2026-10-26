using UnityEngine;

public class RandomTargetSpawn : MonoBehaviour
{
    public GameObject targetPrefab;
    
    void Start()
    {
        spawnTarget();
    }
    
    public void spawnTarget()
    {
        Vector3 randomPosition = new Vector3(
            Random.Range(-2.5f, 2.5f),
            0,
            Random.Range(-2.5f, 2.5f)
        );
        
        Instantiate(targetPrefab, randomPosition, Quaternion.identity, transform);
    }
}
