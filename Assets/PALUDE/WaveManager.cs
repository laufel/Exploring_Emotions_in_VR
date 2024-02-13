using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Experimental.Rendering;

public class WaveManager : MonoBehaviour
{
    public Material waveMaterial;
    public ComputeShader waveCompute;
    public RenderTexture NState, Nm1State, Np1State;
    public Vector2Int resolution;
    public RenderTexture obstaclesTex;

    public Vector3 effect;
    public float dispersion = 0.98f;

    // Start is called before the first frame update
    void Start()
    {
        InitializeTexture(ref NState);
        InitializeTexture(ref Nm1State);
        InitializeTexture(ref Np1State);
        obstaclesTex.enableRandomWrite = true;
        Debug.Assert(obstaclesTex.width==resolution.x && obstaclesTex.height==resolution.y);

        waveMaterial.mainTexture = NState;


    }

    private void InitializeTexture(ref RenderTexture tex)
    {    

        tex = new RenderTexture(resolution.x, resolution.y, 1, UnityEngine.Experimental.Rendering.DefaultFormat.HDR);
        tex.enableRandomWrite = true;
        tex.Create();

    }

    // Update is called once per frame
    void Update()
    {
        Graphics.CopyTexture(NState, Nm1State);
        Graphics.CopyTexture(Np1State, NState);

        waveCompute.SetTexture(0, "NState", NState);
        waveCompute.SetTexture(0, "Nm1State", Nm1State);
        waveCompute.SetTexture(0, "Np1State", Np1State);
        waveCompute.SetVector("effect", effect);
        waveCompute.SetVector("resolution", new Vector2(resolution.x, resolution.y));
        waveCompute.SetFloat("dispersion", dispersion);
        waveCompute.SetTexture(0, "obstaclesTex", obstaclesTex);
        waveCompute.Dispatch(0, resolution.x / 8, resolution.y / 8, 1);

    }
}
