using MLModelPricePrediction_ConsoleApp.AdditionFunctions;
using MLModelPricePrediction_ConsoleApp.ProgrammFunctions;
using static System.Console;

WriteLine(ClassPromptListener.GetWelcomeMessage());

AnswerTransition:
WriteLine(ClassPromptListener.GetQuestionMessage());

string? Answer = ReadLine();

    if (Answer == string.Empty || Answer == "N" || Answer == "n")
    {
        WriteLine("\nBase data for prediction");
        ClassPredictionCall.BasePrediction(
            ClassPromptListener.GetRateCode(),
            ClassPromptListener.GetPassengerCount(),
            ClassPromptListener.GetTripTimeSeconds()
            );
    }
    else if (Answer == "Y" || Answer == "y")
    {
        ClassPromptListener.SetArguments();
        
        ClassPredictionCall.BasePrediction(
            ClassPromptListener.GetRateCode(),
            ClassPromptListener.GetPassengerCount(),
            ClassPromptListener.GetTripTimeSeconds()
            );
    }
    else
    {
        WriteLine("\nAnswer was not recognised");
        goto AnswerTransition;
    }

WriteLine("=============== End of process, hit any key to finish ===============");
ReadKey();