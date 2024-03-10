using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hardware1 : HardwareBase
{    
    protected override void HardwareWeight()
    {
        base.HardwareWeight();
        // Hardware1의 무게 설정

        // Range 범위 내에서 무작위한 무게를 결정
        hardwareWeight = UnityEngine.Random.Range(10.0f, 50.0f);
    }

    protected override void HardwareSellPrice()
    {
        base.HardwareSellPrice();
        // Hardware1의 가격 설정

        // Range 범위 내에서 무작위한 가격을 결정
        hardwarePrice = UnityEngine.Random.Range(100.0f, 500.0f);
    }
}
