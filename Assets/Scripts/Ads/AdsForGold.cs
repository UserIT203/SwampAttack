using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class AdsForGold : MonoBehaviour, IUnityAdsListener
{
    [SerializeField] private GameObject startWatchingButton;

    private string gameId = "5353223";
    private string myPlacementId = "rewardedVideo";
    private bool testMode = true;

    private void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameId, testMode);

        startWatchingButton.GetComponent<Button>().onClick.AddListener(() =>
        {
            Advertisement.Show(myPlacementId);
            startWatchingButton.SetActive(false);
        });
    }

    public void OnUnityAdsReady(string placementId)
    {
        if (placementId == myPlacementId)
            startWatchingButton.SetActive(true);
    }

    public void OnUnityAdsDidError(string message)
    {

    }

    public void OnUnityAdsDidStart(string placementId)
    {
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if(showResult == ShowResult.Finished)
        {
            Debug.Log("Вам начислено 1000 монеток");
        }
        else if(showResult == ShowResult.Skipped)
        {

        }
        else if (showResult == ShowResult.Failed)
        {

        }
    }
}
