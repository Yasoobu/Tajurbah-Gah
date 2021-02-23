using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpringBalanceController : MonoBehaviour
{
    float weight1 = 0.0f;
    public float bobWeight1 = 20.0f;
    public float bobWeightInWater1 = 0.0f;
    public float density1 = 0.0f;
    public bool bobInBeaker1 = false;
    bool BeakerBobOnScale = false;
    public TextMeshPro textMeshPro;
   // public TextMeshPro textMeshProDensity;
    public bool bobWeighted1 = false;
    public bool bobWeightedinWater1 = false;
    //public DensityControlllerSpringBalance dcsb;


    // Start is called before the first frame update
    void Start()
    {
        weight1 = bobWeight1;
        bobWeighted1 = true;
        textMeshPro.SetText("{0}g", bobWeight1);

        //Tajurbah_Gah.StepsLabelController.UpdateStep(0,false);
        GameObject.Find("Steps Tab").GetComponent<Tajurbah_Gah.StepsLabelController>().UpdateStep(0,true);
        GameObject.Find("Steps Tab").GetComponent<Tajurbah_Gah.StepsLabelController>().UpdateStep(1, false);


    }

    // Update is called once per frame
    void Update()
    {
        if(WaterCollision.bobinBeaker && bobInBeaker1==false)
        {
            bobWeightInWater1 = bobWeight1 / 2.5f;
            weight1 = bobWeightInWater1;
            density1 = bobWeight1 / (bobWeight1 - bobWeightInWater1);
            bobWeightedinWater1 = true;
            bobInBeaker1 = true;
            GameObject.Find("Steps Tab").GetComponent<Tajurbah_Gah.StepsLabelController>().UpdateStep(1, true);

        }
        else if(WaterCollision.bobinBeaker==false && bobInBeaker1)
        {
            weight1 = bobWeight1;
            bobInBeaker1 = false;
        }
        textMeshPro.SetText("{0}g", weight1);
    }
}
