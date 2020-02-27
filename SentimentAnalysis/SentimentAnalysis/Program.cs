using System;
using SentimentAnalysis;
using SentimentAnalysisML.Model;
namespace SentimentAnalysis
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = new ModelInput();
      input.SentimentText = "harmony between people of this village";

      ModelOutput results = ConsumeModel.Predict(input);
      Console.WriteLine($"Text: {input.SentimentText}\n Toxic: {results.Prediction}");
    }
  }
}
