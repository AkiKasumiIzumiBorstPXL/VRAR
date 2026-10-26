using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private Renderer cubeRenderer;
    public RandomTargetSpawn targetSpawner;
    
    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
        ChangeColor(Color.blue);
    }
    
    void OnTriggerEnter(Collider other)
    {
        ChangeColor(Color.green);
        
        if (other.transform.parent != null && 
            other.transform.parent.GetComponent<RandomTargetSpawn>() != null)
        {
            other.transform.parent.GetComponent<RandomTargetSpawn>().spawnTarget();
        }
    }
    
    public void OnTriggerExit(Collider other)
    {
        ChangeColor(Color.blue);
        Destroy(other.gameObject);
    }
    
    public void ChangeColor(Color color)
    {
        if (cubeRenderer != null)
        {
            cubeRenderer.material.color = color;
        }
    }
}