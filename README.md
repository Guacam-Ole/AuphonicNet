# AuphonicNet
AuphonicNet is a .NET implementation for the [Auphonic](auphonic.com) Api. It uses .Net Standard 2.1 framework and it accessable from .Net Core as well as from .Net Framework

## Feature Completion
At the current state you can Query Userdetails, Presets and Productions. You also can create and start productions

## API-Description
The API-Description can be found at [Auphonic Help](https://auphonic.com/help/api/index.html)

## How to start
Start by downloading the source or add the [NuGet-Package](https://www.nuget.org/packages/AuphonicApiNet/1.0.0) to your solution.

The first thing you have to do is to provide your credentials:
```
AuphonicApi.BasicAuth.SetCredentials("username","password").
```

## Examples

### Retrieve your Credits
```
private async Task GetMyCredits() {
   AuphonicApi.BasicAuth.SetCredentials("username", "password");
   var query=new AuphonicApi.Query();
   var meMyselfAndI=await query.GetUserAsync();
   Console.Write($"I have {meMyselfAndI.Data.Credits} credits left");
}
```

### Show all Presets and Productions
```
private async Task ShowStuff() {
   AuphonicApi.BasicAuth.SetCredentials("username", "password");
   var query=new AuphonicApi.Query();
   var productions=await query.GetProductionsAsync();
   var presets=await query.GetPresetsAsync();
   Console.Write("My Presets:");
   foreach (var p in presets) {
      Console.Write(p.Data.PresetName);
   }
   Console.Write("My Productions:");
   foreach (var p2 in productions) {
      Console.Write(p2.Data.MetaData.Title);
   }
}
```


### Create and start a new Production 
```
private async Task CreateProduction(string presetUuid, string episodeTitle, byte[] mp3file) {
   AuphonicApi.BasicAuth.SetCredentials("username", "password");
   var prod=new AuphonicApi.Production();
   var production= await prod.CreateFromPreset(presetUuid, episodeTitle);
   var productionUuid=production.Data.Uuid;
   await prod.AddFileToProduction(productionUuid, "upload.mp3", mp3file);
   await prod.StartProduction(productionUuid);
}
```

### Create a production with a webhook
```
private async Task CreateWithHook(string presetUuid, string title, byte[] mp3file) {
   AuphonicApi.BasicAuth.SetCredentials("username", "password");
   var prod=new AuphonicApi.Production();
   var production=await _production.CreateFromPreset(
      presetUuid, 
      new Dictionary<string, object> { { "WebHook", "http://example.com/hook/auphonic" } }, 
      new AuphonicApi.Models.Metadata { Title = title }
   );
    
   var productionUuid=production.Data.Uuid;
   await prod.AddFileToProduction(productionUuid, "upload.mp3", mp3file);
   await prod.StartProduction(productionUuid);
}
```

#### Consume a webhook
Auphonic sends successinformation to any finished production. When using Asp.Net WebApi you can collect the response from the webhook the following way:

```
    [ApiController]
    [Route("[controller]")]
    public class HookController:ControllerBase
    {
        [HttpPost] 
        [Route("auphonic")]
        public async void Webhook([FromForm] string uuid, [FromForm(Name ="status_string")] string status, [FromForm(Name ="status")] int statusNumber)
        {
           if (status=="Done") {
              Console.Write($"{uuid} is finished")
           } else {
              Console.Write($"{uuid} failed")
           }
        }
    }

```


