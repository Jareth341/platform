namespace CatchUpPlatform.API.News.Domain.Model.Commands;

public record CreatedFavoriteSourceCommand(string NewsApiKey, string SourceId);