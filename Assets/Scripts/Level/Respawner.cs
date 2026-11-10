using System.Collections;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    [SerializeField] Gem gemPrefab;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float respawnDelay;
    
    

    void OnEnable()
    {
        GameEvents.OnTargetDestroyed += RespawnGEM;
    }

    void OnDisable()
    {
        GameEvents.OnTargetDestroyed -= RespawnGEM;
    }
    
    void RespawnGEM(GameItem gameItem)
    {
        if (gemPrefab != null)
        {
            
            StartCoroutine(SpawnGEM());

        }
        Debug.Log($"My gem respawned");
    }
    
    IEnumerator SpawnGEM()
    {
        

        for (int i = 0; i < respawnDelay; i++)
        {
            yield return new WaitForSeconds(respawnDelay);
            Instantiate(gemPrefab, spawnPoint.position, spawnPoint.rotation);
            
            StopAllCoroutines();
        }
        yield return new WaitForSeconds(respawnDelay);

        
    }
}
