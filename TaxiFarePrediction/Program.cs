
using TaxiFarePrediction;

Console.WriteLine("Прогнозирование цен с ML.NET");

//Load sample data
var sampleData = new MLModelTaxiFarePrediciton.ModelInput()
{
	Vendor_id = @"CMT",
	Rate_code = 1F,
	Passenger_count = 1F,
	Trip_time_in_secs = 474F,
	Payment_type = @"CRD",
};

//Load model and predict output
var result = MLModelTaxiFarePrediciton.Predict(sampleData);

Console.WriteLine(result.);