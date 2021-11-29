using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddEffects : MonoBehaviour
{
    private float multiplier = 0.9f;
    // Start is called before the first frame update
    public IEnumerator Shrink(Collider player)
    {
        player.transform.localScale *= multiplier;
        Debug.Log(RandomPowerUp.powerUps);
        yield return new WaitForSeconds(10);
        Debug.Log("here");
        player.transform.localScale /= multiplier;
        RandomPowerUp.powerUps--;
    }
}
