using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour, IUnityAdsShowListener
{
    public static AdsManager Instance;
    private string _gameID = "5287580";


    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }


    void Start()
    {
        Advertisement.Initialize(_gameID);
    }


    void Update()
    {
        if (Input.GetMouseButton(0))
            ShowRewardedAds();
    }


    public void ShowAds()
    {
        Advertisement.Show("Interstitial_Android");
    }


    public void ShowRewardedAds()
    {
        Advertisement.Show("Rewarded_Android");
    }


    public void OnUnityAdsShowFailure(string placementId, UnityAdsShowError error, string message)
    {
        throw new System.NotImplementedException();
    }


    public void OnUnityAdsShowStart(string placementId)
    {
        throw new System.NotImplementedException();
    }


    public void OnUnityAdsShowClick(string placementId)
    {
        throw new System.NotImplementedException();
    }


    public void OnUnityAdsShowComplete(string placementId, UnityAdsShowCompletionState showCompletionState)
    {
        throw new System.NotImplementedException();
    }
}
