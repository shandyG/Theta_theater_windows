
using System;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class DofW : UdonSharpBehaviour
{
    /// <summary>
    /// スクリプト対象のテキスト
    /// </summary>
    [SerializeField] private Text targetText;
    /// <summary>
    /// 現在時間
    /// </summary>
    [SerializeField] private DateTime now;

    void Start()
    {
        targetText = this.GetComponent<Text>();

        targetText.text = DateTime.Now.ToString("ddd");
    }
}
