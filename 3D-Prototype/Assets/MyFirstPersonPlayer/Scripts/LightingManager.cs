using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingManager : MonoBehaviour
{
    public Light mainLight;
    public float flashing;

    public AudioSource LightningStrikeSound;

    // Start is called before the first frame update
    void Start()
    {
        mainLight = GameObject.Find("LightMainDirectional").GetComponent<Light>();
        StartCoroutine(LightningFlashes());
        flashing = .5f;
        mainLight.intensity = 0f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator LightningFlashes()
    {
        //float waitTime = Random.Range(1f, 3f);
        do
        {
            yield return new WaitForSeconds(Random.Range(8, 10));

            mainLight.intensity = .2f;
            LightningStrikeSound.Play();

            yield return new WaitForSeconds(flashing);

            mainLight.intensity = 0f;

            yield return new WaitForSeconds(flashing);

            mainLight.intensity = .2f;

            yield return new WaitForSeconds(flashing);

            mainLight.intensity = 0f;

            yield return new WaitForSeconds(flashing);

            mainLight.intensity = .2f;

            yield return new WaitForSeconds(flashing);

            mainLight.intensity = 0f;
        } while (true);
    }
}
