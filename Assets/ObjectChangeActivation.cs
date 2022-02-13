
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ObjectChangeActivation : UdonSharpBehaviour
{
    public GameObject toggleObject;


    // このUdonが付いているオブジェクトをインタラクトしたら呼ばれる関数
    public override void OnPickupUseDown()
    {
        // toggleObjectのアクティブ状態を切り替える
        // !(bool値)　と書くことで、True->False、False->Trueにする（NOT演算）ができます。
        toggleObject.SetActive(!toggleObject.activeSelf);
    }
}
