using OpenAI.API.Exampleee;
using OpenAI.API.Exampleee.Services;
using OpenAI.GPT3.Extensions;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddOpenAIService(settings => settings.ApiKey = "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");
        //services.AddHostedService<OpenAICompletionService>();
        services.AddHostedService<OpenAIImageService>();
    })
    .Build();

host.Run();
