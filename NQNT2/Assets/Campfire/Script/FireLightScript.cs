using UnityEngine;

public class FireLightScript : MonoBehaviour
{
	public float minIntensity = 0.25f;
	public float maxIntensity = 0.5f;



	float random;

	void Update()
	{
		random = Random.Range(0.0f, 150.0f);
		//float noise = Mathf.PerlinNoise(random, Time.time);

	}
}