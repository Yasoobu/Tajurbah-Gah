using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DensityController : MonoBehaviour
{
    public TextMeshPro textMeshProDensity;
    public TextMeshPro textMeshProWeightInAir;
    public TextMeshPro textMeshProWeightInWater;

    bool bobWeighted = false;
    bool bobWeightedInWater = false;
    //public SpringBalanceController sbc;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (WeightController.bobWeighted && bobWeighted == false)
        {

            textMeshProWeightInAir.SetText("Weight in Air = {0} g", WeightController.bobWeight);
            bobWeighted = true;
        }

        if (WeightController.bobWeightedinWater && bobWeightedInWater == false)
        {
            
            textMeshProWeightInWater.SetText("Weight in Water = {0} g", WeightController.bobWeightInWater);
            textMeshProDensity.SetText("Density = {0} g / cm^3", WeightController.density);
            bobWeightedInWater = true;
        }
    }
}
