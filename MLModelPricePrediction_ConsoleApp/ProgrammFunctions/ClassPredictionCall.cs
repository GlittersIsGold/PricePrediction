using static System.Console;

namespace MLModelPricePrediction_ConsoleApp.ProgrammFunctions
{
	internal static class ClassPredictionCall
	{
		internal static void BasePrediction(float rateCode, float passengerCount, float tripTimeSeconds)
		{
			WriteLine("\nUsing model to make single prediction -- Comparing actual Fare_amount with predicted Fare_amount from sample data...\n\n");

			MLModelTaxiFarePrediciton.ModelInput sampleData = new()
			{
				Vendor_id = @"CMT",
				Rate_code = rateCode,
				Passenger_count = passengerCount,
				Trip_time_in_secs = tripTimeSeconds,
				Payment_type = @"CRD",
			};

			WriteLine($"Vendor_id: {sampleData.Vendor_id}");
			WriteLine($"Rate_code: {sampleData.Rate_code}");
			WriteLine($"Passenger_count: {sampleData.Passenger_count}");
			WriteLine($"Trip_time_in_secs: {sampleData.Trip_time_in_secs}");
			WriteLine($"Payment_type: {sampleData.Payment_type}");
			WriteLine($"Fare_amount: {sampleData.Fare_amount}");
			WriteLine("\n");

			var predictionResult = MLModelTaxiFarePrediciton.Predict(sampleData);
			WriteLine($"\n\nPredicted price: {predictionResult.Score}\n\n");
		}
	}
}
