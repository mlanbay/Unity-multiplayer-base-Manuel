using System;
using Unity.Services.Authentication;
using Unity.Services.Core;
using Unity.Services.Lobbies;
using Unity.Services.Lobbies.Models;
using UnityEngine;

public class ClientsManager : MonoBehaviour
{
    
    const int maxClients = 5;
    
    private async void Start()
    {
        await UnityServices.InitializeAsync();

        AuthenticationService.Instance.SignedIn += () =>
        {
            Debug.Log("Signed In " + AuthenticationService.Instance.PlayerId);
        };
         
        await AuthenticationService.Instance.SignInAnonymouslyAsync();

    }

    private async void CreateLobbyWithName(string lobbyName)
    {
        try
        {
            Lobby lobby = await LobbyService.Instance.CreateLobbyAsync(lobbyName, maxClients);
        }
        catch (LobbyServiceException e)
        {
            Debug.Log(e.Message);
        }
    }

    private async void CreateLobby()
    {
        
        string lobbyName = AuthenticationService.Instance.PlayerName + "'s Lobby";
        
        try
        {
            Lobby lobby = await LobbyService.Instance.CreateLobbyAsync(lobbyName,maxClients);
        }
        catch (LobbyServiceException e)
        {
            Debug.Log(e.Message);
        }
    }
    
}
