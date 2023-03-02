﻿
// This file was auto-generated by ML.NET Model Builder. 

using MLModelPricePrediction_ConsoleApp;

// Create single instance of sample data from first line of dataset for model input
MLModelTaxiFarePrediciton.ModelInput sampleData = new MLModelTaxiFarePrediciton.ModelInput()
{
    Vendor_id = @"CMT",
    Rate_code = 1F,
    Passenger_count = 1F,
    Trip_time_in_secs = 100F,
    Payment_type = @"CRD",
};


Console.WriteLine("Using model to make single prediction -- Comparing actual Fare_amount with predicted Fare_amount from sample data...\n\n");


Console.WriteLine($"Vendor_id: {sampleData.Vendor_id}");
Console.WriteLine($"Rate_code: {sampleData.Rate_code}");
Console.WriteLine($"Passenger_count: {sampleData.Passenger_count}");
Console.WriteLine($"Trip_time_in_secs: {sampleData.Trip_time_in_secs}");
Console.WriteLine($"Payment_type: {sampleData.Payment_type}");
Console.WriteLine($"Fare_amount: {sampleData.Fare_amount}");

Console.WriteLine("\n");


// Make a single prediction on the sample data and print results
var predictionResult = MLModelTaxiFarePrediciton.Predict(sampleData);
Console.WriteLine($"\n\nPredicted price: {predictionResult.Score}\n\n");

Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();