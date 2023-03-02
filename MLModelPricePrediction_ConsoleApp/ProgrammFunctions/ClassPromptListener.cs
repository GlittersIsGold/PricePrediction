using static System.Console;

namespace MLModelPricePrediction_ConsoleApp.AdditionFunctions
{
	internal static class ClassPromptListener
	{
		static string WelcomeMessage = "\n Hello";
		static string QuestionMessage = "\n\ndo you want to enter own data to make a prediction? \n\nY/N";
		static float RateCode = 1F;
		static float PassengerCount = 1F;
		static float TripTimeSeconds = 900F;

		internal static void SetArguments()
		{
			WriteLine("\nReading your data from CLI");

			RateCodeReading:
			WriteLine("\nEnter rate code");
			string? RateCodeResponse = ReadLine();

			if (RateCodeResponse != null)
			{
				bool isRateCodeSet = float.TryParse(RateCodeResponse, out RateCode);
				if (isRateCodeSet)
				{
					WriteLine($"You`ve set rate code: {RateCode}");
				}
				else
				{
					WriteLine($"Value was not recognised");
					goto RateCodeReading;
				}
			}
			else
			{
				WriteLine("Wrong format, type value again for rate code");
				goto RateCodeReading;
			}


			PassengerCountReading:
			WriteLine("\nEnter number of passengers");
			string? PassengerCountResponse = ReadLine();

			if (PassengerCountResponse != null)
			{
				bool isPassengerCountSet = float.TryParse(PassengerCountResponse, out PassengerCount);
				if (isPassengerCountSet)
				{
					WriteLine($"You`ve set number of passangers: {PassengerCount}");
				}
				else
				{
					WriteLine($"Value was not recognised");
					goto PassengerCountReading;
				}
			}
			else
			{
				WriteLine("Wrong format, type value again for number of passengers");
				goto PassengerCountReading;
			}


			TripTimeSecondsReading:
			WriteLine("\nEnter trip time in seconds");
			string? TripTimeSecondsResponse = ReadLine();

			if (TripTimeSecondsResponse != null)
			{
				bool isTripTimeSecondsSet = float.TryParse(TripTimeSecondsResponse, out TripTimeSeconds);
				if (isTripTimeSecondsSet)
				{
					WriteLine($"You`ve set trip time: {TripTimeSeconds}");
				}
				else
				{
					WriteLine($"Value was not recognised");
					goto TripTimeSecondsReading;
				}
			}
			else
			{
				WriteLine("Wrong format, type value again for trip time");
				goto TripTimeSecondsReading;
			}
		}

		internal static float GetRateCode()
		{
			return RateCode;
		}

		internal static float GetPassengerCount()
		{
			return PassengerCount;
		}

		internal static float GetTripTimeSeconds()
		{
			return TripTimeSeconds;
		}

		internal static string GetWelcomeMessage()
		{
			return WelcomeMessage;
		}

		internal static string GetQuestionMessage() 
		{
			return QuestionMessage;
		}
	}
}
