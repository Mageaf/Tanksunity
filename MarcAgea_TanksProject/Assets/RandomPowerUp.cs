using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPowerUp : MonoBehaviour
{
    public GameObject powerUp;
    public static int powerUps = 0;
    // Start is called before the first frame update
    void Update()
    {
        if (powerUps == 0){
            StartCoroutine(spawnPowerUp());
        }
    }
    public IEnumerator spawnPowerUp()
    {
        powerUps++;
        yield return new WaitForSeconds(10);
        Instantiate(powerUp, transform.position, transform.rotation);
        PowerUp.destroyed = false;
    }
}
