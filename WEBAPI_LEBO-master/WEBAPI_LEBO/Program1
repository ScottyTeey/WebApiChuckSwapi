using System;
using System.Net.Http;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
					
public class Program
{
	private static readonly HttpClient client = new HttpClient();
	
	public static void Main()
	{
		//["animal","career","celebrity","dev","explicit","fashion","food","history","money","movie","music","political","religion","science","sport","travel"]
		Console.WriteLine(GetJokeFromCategory("career"));
		Console.WriteLine(JokeFromSearch("ninja"));
	}
	
	public static string GetJokeFromCategory(string category)
	{
		Joke joke = new Joke();
		string Url = "https://api.chucknorris.io/jokes/random?category=" + category;

		try
		{
			string stringResult = HttpWebRequest("GET", Url);
			joke = JsonConvert.DeserializeObject<Joke>(stringResult);

			return joke.Value;
		}catch(Exception)
		{
			//Normally, I would handle this exception instead of swallowing it, passing it up to the line, or logging it. However, in this excercise, I am unsure what I should do with it.
			return null;
		}
	}
	
	public static string JokeFromSearch(string search)
	{
		JokesResult jokeResult = new JokesResult();
		string Url = "https://api.chucknorris.io/jokes/search?query=" + search;

		try
		{
			string stringResult = HttpWebRequest("GET", Url);
			jokeResult = JsonConvert.DeserializeObject<JokesResult>(stringResult);
			
			Random randomNumber = new Random(); //Setup, and return random joke from search result list.
			string randomJokeFromList = jokeResult.result[randomNumber.Next(0, jokeResult.result.Count)].Value;
			return randomJokeFromList;
		}
		catch (Exception)
		{
			//Normally, I would handle this exception instead of swallowing it, passing it up to the line, or logging it. However, in this excercise, I am unsure what I should do with it.
			return null;
		}
	}
	
	public static string HttpWebRequest(string method, string url)
	{
		WebRequest request = WebRequest.Create(url);
		request.Method = method;

		try
		{
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			string streamResponses = string.Empty;
			using (Stream dataStream = response.GetResponseStream())
			{
				StreamReader reader = new StreamReader(dataStream);

				streamResponses = reader.ReadToEnd();
			}

			response.Close();

			return streamResponses;
		}
		catch (Exception ex)
		{
			throw ex; //Passsing exception up the line.
		}
	}
		
}

public class JokesResult
{
	public string Total { get; set; }
	public List<Joke> result { get; set; }
}

public class Joke
{
	public string[] Categories { get; set; }
	public string Created_at { get; set; }
	public string Icon_url { get; set; }
	public string Id { get; set; }
	public string Updated_at { get; set; }
	public string Url { get; set; }
	public string Value { get; set; }
}

