using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DensityControlllerSpringBalance : MonoBehaviour
{

    public TextMeshPro textMeshProDensity1;
    public TextMeshPro textMeshProWeightInAir1;
    public TextMeshPro textMeshProWeightInWater1;
    bool bobWeighted = false;
    bool bobWeightedInWater = false;
    public SpringBalanceController sbc;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sbc.bobWeighted1 && bobWeighted == false)
        {
            textMeshProWeightInAir1.SetText("Weight in Air = {0} g", sbc.bobWeight1);
            bobWeighted = true;
            Debug.Log("Weighted in Air");
        }

        if ((sbc.bobWeightedinWater1) && bobWeightedInWater == false)
        {
            textMeshProWeightInWater1.SetText("Weight in Water = {0} g", sbc.bobWeightInWater1);
            textMeshProDensity1.SetText("Density = {0} g / cm^3", sbc.density1);
            bobWeightedInWater = true;
            Debug.Log("Weighted in Water");
        }


    }
}
