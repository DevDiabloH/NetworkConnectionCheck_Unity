# NetworkConnectionCheck_Unity
```
 Do not use Application.internetReachability.
 https://docs.unity3d.com/ScriptReference/Application-internetReachability.html
 Note: Do not use this property to determine the actual connectivity.
 ```

how to use?

```
if(true == ConnectionCheck.IsConnected())
{
   YourConnectedEvent(); 
}
else
{
   YourDisconnectedEvent(); 
}
```

default timeout = 3s
