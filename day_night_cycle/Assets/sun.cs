using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sun : MonoBehaviour {

    public Material skyDay;
    public Material skyNight;
    public Light Sun;
    public Light Moon;
    float exposure=2.0f;
    
    //Set the value of exposure
    void setExposure(float exposure)
    {
        RenderSettings.skybox.SetFloat("_Exposure", exposure);
    }

	// Use this for initialization
	void Start () {
        setExposure(2.0f);
    }
	
	// Update is called once per frame
	void Update () {
        Sun.transform.RotateAround(Vector3.zero, Vector3.right, 2f * Time.deltaTime);
        Sun.transform.LookAt(Vector3.zero);
        Moon.transform.RotateAround(Vector3.zero, Vector3.right, 2f * Time.deltaTime);
        Moon.transform.LookAt(Vector3.zero);
        if(Sun.transform.position.y > 0 && Sun.transform.position.z >0 && Sun.transform.position.z <500)
        {
            exposure -= 0.00075f;
            setExposure(exposure);
        }
        else if(Sun.transform.position.y > 0 && Sun.transform.position.z < 0 && Sun.transform.position.z > -500)
        {
            exposure += 0.00075f;
            setExposure(exposure);
        }


        /*
        if (Sun.transform.position.z >= 0 && Sun.transform.position.y > 0)
        {
            for (float i = exposure; i >= 0.0f; i -= 0.02f)
            {
                RenderSettings.skybox.SetFloat("_Exposure", i);
            }
        }
        else if (Sun.transform.position.z <= 0 && Sun.transform.position.y > 0)
        {
            for (float i = exposure; i >= 0.0f; i += 0.02f)
            {
                RenderSettings.skybox.SetFloat("_Exposure", i);
            }
        }
        */
        //baja el sol
        /*
        if(Sun.transform.position.z >= 200 && Sun.transform.position.z < 325 && Sun.transform.position.y > 0)
        {
            RenderSettings.skybox.SetFloat("_Exposure", 1.5f);
        }
        else if (Sun.transform.position.z >= 325 && Sun.transform.position.z < 375 && Sun.transform.position.y > 0)
        {
            RenderSettings.skybox.SetFloat("_Exposure", 1.0f);
        }
        else if (Sun.transform.position.z >= 375 && Sun.transform.position.z < 425 && Sun.transform.position.y > 0)
        {
            RenderSettings.skybox.SetFloat("_Exposure", 0.5f);
        }
        else if (Sun.transform.position.z >= 425 && Sun.transform.position.z < 470 && Sun.transform.position.y > 0)
        {
            RenderSettings.skybox.SetFloat("_Exposure", 0.25f);
        }
        else if (Sun.transform.position.z >= 470 && Sun.transform.position.z < 490 && Sun.transform.position.y > 0)
        {
            RenderSettings.skybox.SetFloat("_Exposure", 0.1f);
        }
        //sube el sol
        else if (Sun.transform.position.z >= -490 && Sun.transform.position.z < -470 && Sun.transform.position.y > 0)
        {
            RenderSettings.skybox.SetFloat("_Exposure", 0.1f);
        }
        else if (Sun.transform.position.z >= -470 && Sun.transform.position.z < -375 && Sun.transform.position.y > 0)
        {
            RenderSettings.skybox.SetFloat("_Exposure", 0.5f);
        }
        else if (Sun.transform.position.z >= -375 && Sun.transform.position.z < -325 && Sun.transform.position.y > 0)
        {
            RenderSettings.skybox.SetFloat("_Exposure", 1.0f);
        }
        else if (Sun.transform.position.z >= -325 && Sun.transform.position.z < -200 && Sun.transform.position.y > 0)
        {
            RenderSettings.skybox.SetFloat("_Exposure", 1.5f);
        }
        else if (Sun.transform.position.z >= -200 && Sun.transform.position.z < 0 && Sun.transform.position.y > 0)
        {
            RenderSettings.skybox.SetFloat("_Exposure", 2.0f);
        }
        */


        if (Sun.transform.position.y > 0)
        {
            RenderSettings.skybox = skyDay;
        }
        else
        {
            RenderSettings.skybox = skyNight;
        }
	}
}
