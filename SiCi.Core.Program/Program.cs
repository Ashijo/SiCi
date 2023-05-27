using System.Text.Json;
using Meilisearch;
using SiCi.Core.Program;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();



MeilisearchClient client = new MeilisearchClient("http://localhost:7700", "masterKey");
var options = new JsonSerializerOptions
{
	PropertyNameCaseInsensitive = true
};

// An index is where the documents are stored.
var index = client.Index("movies");
var documents = new Movie[] {
	new Movie { Id = "1", Title = "Carol", Genres = new string[] { "Romance", "Drama" }  },
	new Movie { Id = "2", Title = "Wonder Woman", Genres = new string[] { "Action", "Adventure" } },
	new Movie { Id = "3", Title = "Life of Pi", Genres = new string[] { "Adventure", "Drama" } },
	new Movie { Id = "4", Title = "Mad Max: Fury Road", Genres = new string[] { "Adventure", "Science Fiction"} },
	new Movie { Id = "5", Title = "Moana", Genres = new string[] { "Fantasy", "Action" } },
	new Movie { Id = "6", Title = "Philadelphia", Genres = new string[] { "Drama" } }
};

await index.AddDocumentsAsync<Movie>(documents);

var movies = await index.SearchAsync<Movie>("a");
foreach(var prop in movies.Hits) {
	Console.WriteLine (prop.Title);
}


app.Run();
