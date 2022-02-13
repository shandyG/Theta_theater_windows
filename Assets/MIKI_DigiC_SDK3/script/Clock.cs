
using System;
using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class Clock : UdonSharpBehaviour
{
    #region プライベート定義群
    /// <summary>
    /// スクリプト対象のテキスト
    /// </summary>
    [SerializeField] private Text targetText;
    /// <summary>
    /// 現在時間
    /// </summary>
    [SerializeField] private DateTime now;
    #endregion

    void Start()
    {
        now = DateTime.Now;
        targetText = this.GetComponent<Text>();

        targetText.text = now.ToString("HH:mm:ss");
    }

    void Update()
    {
        now = DateTime.Now;
        targetText = this.GetComponent<Text>();

        targetText.text = now.ToString("HH:mm:ss");
    }

}
