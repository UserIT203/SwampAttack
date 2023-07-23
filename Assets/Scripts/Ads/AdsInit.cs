using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsInit : MonoBehaviour
{
    private string gameId = "5353223";
    private bool testMode = true;

    private void Start()
    {
        Advertisement.Initialize(gameId, testMode);
        StartCoroutine(ShowBannerWhenReady());
    }

    private IEnumerator ShowBannerWhenReady()
    {
        while (!Advertisement.IsReady("MainBottom"))
        {
            yield return new WaitForSeconds(0.5f);
        }

        Advertisement.Banner.Show("MainBottom");
    }
}
