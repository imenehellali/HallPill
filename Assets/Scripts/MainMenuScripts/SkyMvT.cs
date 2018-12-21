using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyMvT : MonoBehaviour {
    public float _rotationSpeed;

	void Update () {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * _rotationSpeed);

	}
}
