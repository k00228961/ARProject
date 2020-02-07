using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateStarSystem : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public int maxParticles = 100;
    public TextAsset starCSV;
    void Awake()
    {
        particleSystem = GetComponent<ParticleSystem>();
        particleSystem.maxParticles = maxParticles;
        ParticleSystem.Burst[] bursts = new ParticleSystem.Burst[1];
        bursts[0].minCount = (short)maxParticles;
        bursts[0].maxCount = (short)maxParticles;
        bursts[0].time = 0.0f;
        particleSystem.emission.SetBursts(bursts, 1);
    }

    void Start()
    {
        string[] lines = starCSV.text.Split('\n');
        ParticleSystem.Particle[] particleStars = new ParticleSystem.Particle[maxParticles];
        particleSystem.GetParticles(particleStars);
        for (int i = 0; i < maxParticles; i++)
        {
            string[] components = lines[i].Split(',');
            particleStars[i].position = new Vector3(float.Parse(components[1]),
                                                    float.Parse(components[3]),
                                                    float.Parse(components[2]));
            particleStars[i].remainingLifetime = Mathf.Infinity;
        }
        particleSystem.SetParticles(particleStars, maxParticles);
    }
}
